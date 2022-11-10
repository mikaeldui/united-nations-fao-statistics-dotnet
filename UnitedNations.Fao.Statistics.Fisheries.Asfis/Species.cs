using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UnitedNations.Fao.Statistics.Fisheries
{
    /// <summary>
    /// From https://www.fao.org/fishery/static/ASFIS/ASFIS_Structure.pdf.
    /// </summary>
    public class Species
    {
        /// <summary>
        /// "ISSCAAP". The ISSCAAP codes was assigned to all the species items included in the ASFIS list. The only species items to which has not been possible to attribute an ISSCAAP code are the sea birds and the sea snakes as these animals are not included in any ISSCAAP group.
        /// </summary>
        /// <example>
        /// E.g. 11 = Carps, barbels and ather cyprinids. 1x = Freshwater fishes. See <see cref="Isscaap"/> and <see cref="http://www.fao.org/fishery/static/ASFIS/ISSCAAP.pdf"/>.
        /// </example>
        public Isscaap Isscaap { get; set; }

        /// <summary>
        /// "TAXOCODE". The taxonomic code is a ten-digit numerical code for classificatory purposes. In few special cases, three additional digits have been added.
        /// </summary>
        [MaxLength(13)]
        public string TaxonomicCode { get; set; }

        /// <summary>
        /// "3A_CODE". Inter-agency 3-alpha code. Only in few cases the three letters of the 3-alpha code are related to the scientific or English name of the species items. In all the other cases the 3 letters are assigned at random.
        /// </summary>
        [MaxLength(3)]
        public string Interagency3AlphaCode { get; set; }

        /// <summary>
        /// "Scientific_name". This field includes scientific names at the species, genus, family or higher taxonomic levels. In a few cases, hybrids have been included given their importance in aquaculture. Subspecies are not considered in both the ASFIS list and the FAO databases of fishery statistics.
        /// </summary>
        [MaxLength(37)]
        public string ScientificName { get; set; }

        /// <summary>
        /// "English_name". Only the English names of species items with production statistics have to be considered as official FAO English names; in all other cases they are suggested English names that should be verified before assigning them as an official FAO English name
        /// </summary>
        [MaxLength(30)]
        public string EnglishName { get; set; }

        /// <summary>
        /// "French_name". Only the French names of species items with production statistics have to be considered as official FAO French names; in all other cases they are suggested French names that should be verified before assigning them as an official FAO French name.
        /// </summary>
        [MaxLength(30)]
        public string FrenchName { get; set; }

        /// <summary>
        /// "Spanish_name". Only the Spanish names of species items with production statistics have to be considered as official FAO Spanish names; in all other cases they are suggested Spanish names that should be verified before assigning them as an official FAO Spanish name.
        /// </summary>
        [MaxLength(30)]
        public string SpanishName { get; set; }

        /// <summary>
        /// "Arabic_name".
        /// </summary>
        public string ArabicName { get; set; }

        /// <summary>
        /// "Chinese_name".
        /// </summary>
        public string ChineseName { get; set; }

        /// <summary>
        /// "Russian_name".
        /// </summary>
        public string RussianName { get; set; }

        /// <summary>
        /// "Author". The author(s) of the scientific name is provided for 99% of the species names.
        /// </summary>
        [MaxLength(55)]
        public string Author { get; set; }

        /// <summary>
        /// "Family".
        /// </summary>
        [MaxLength(20)]
        public string Family { get; set; }

        /// <summary>
        /// "Order". This field does not include only orders but also other high taxonomic levels (e.g. divisions, classes, suborders, etc.) corresponding to those used to assign the 2nd and 3rd digits of the taxonomic code.
        /// </summary>
        [MaxLength(30)]
        public string Order { get; set; }

        /// <summary>
        /// "Stats_data". "Yes/1" records are those for which either capture or aquaculture statistics are available in the FAO databases.
        /// </summary>
        public bool IsStatisticsAvailable { get; set; }
    }
}
