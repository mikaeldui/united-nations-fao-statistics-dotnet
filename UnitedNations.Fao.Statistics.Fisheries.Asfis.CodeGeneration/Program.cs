using System.IO.Compression;
using System.Reflection.Metadata;

namespace UnitedNations.Fao.Statistics.Fisheries.Asfis.CodeGeneration
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using HttpClient client = new();
            var zipStream = await client.GetStreamAsync("https://www.fao.org/fishery/static/ASFIS/ASFIS_sp.zip");
            using var zipArchive = new ZipArchive(zipStream);
            var csv = zipArchive.Entries.Single(e => e.Name.EndsWith(".txt"));

            using var csvStream = csv.Open();
            using StreamReader reader = new(csvStream);
            if (reader.ReadLine() != "\"ISSCAAP\",\"TAXOCODE\",\"3A_CODE\",\"Scientific_name\",\"English_name\",\"French_name\",\"Spanish_name\",\"Arabic_name\",\"Chinese_name\",\"Russian_name\",\"Author\",\"Family\",\"Order\",\"Stats_data\"")
                throw new ApplicationException("The CSV header has changed! Please update the Species class.");

            var speciesWriter = File.CreateText(Directory.GetCurrentDirectory().Split(".CodeGeneration")[0] + "\\Species.g.cs");
            speciesWriter.WriteLine("namespace UnitedNations.Fao.Statistics.Fisheries\r\n{\r\n    public partial class Species\r\n    {\r\n");

            while (!reader.EndOfStream)
            {
                var species = reader.ReadLine();
                var fields = species!.Split(',').Select(f => f.Trim('"')).ToArray();
                speciesWriter.WriteLine($"    public static Species {fields[3].Replace(" ", "").Replace("(", "").Replace(")", "").Replace(".", "").Replace("-", "").Replace(" ", "")} = new()\r\n    {{");
                if (!string.IsNullOrWhiteSpace(fields[0])) speciesWriter.WriteLine($"        Isscaap = (Isscaap){fields[0]},");
                speciesWriter.WriteLine($"        TaxonomicCode = \"{fields[1]}\",");
                speciesWriter.WriteLine($"        Interagency3AlphaCode = \"{fields[2]}\",");
                speciesWriter.WriteLine($"        ScientificName = \"{fields[3]}\",");
                speciesWriter.WriteLine($"        EnglishName = \"{fields[4]}\",");
                speciesWriter.WriteLine($"        FrenchName = \"{fields[5]}\",");
                speciesWriter.WriteLine($"        SpanishName = \"{fields[6]}\",");
                speciesWriter.WriteLine($"        ArabicName = \"{fields[7]}\",");
                speciesWriter.WriteLine($"        ChineseName = \"{fields[8]}\",");
                speciesWriter.WriteLine($"        RussianName = \"{fields[9]}\",");
                speciesWriter.WriteLine($"        Author = \"{fields[10]}\",");
                speciesWriter.WriteLine($"        Family = \"{fields[11]}\",");
                speciesWriter.WriteLine($"        Order = \"{fields[12]}\",");
                speciesWriter.WriteLine($"        IsStatisticsAvailable = {(fields[13] == "YES" ? "true" : "false")}");
                speciesWriter.WriteLine("    };");
            }

            speciesWriter.WriteLine("    \r\n}\r\n}");

            await speciesWriter.FlushAsync();

        }
    }
}