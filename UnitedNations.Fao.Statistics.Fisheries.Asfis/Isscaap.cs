namespace UnitedNations.Fao.Statistics.Fisheries
{
    /// <summary>
    /// Provides friendly division names for ISSCAAP codes.
    /// </summary>
    public enum Isscaap : byte
    {
        // Freshwater fishes = 1
        CarpsBarbelsAndOtherCyprinids = 11,
        TilapiasAndOtherCichlids = 12,
        MiscellaneousFreshwaterFishes = 13,

        // Diadromous fishes = 2
        SturgeonsPaddlefishes = 21,
        RiverEels = 22,
        SalmonsTroutsSmelts = 23,
        Shads = 24,
        MiscellaneousDiadromousFishes = 25,

        // Marine fishes = 3
        FloundersHalibutsSoles = 31,
        CodsHakesHaddocks = 32,
        MiscellaneousCoastalFishes = 33,
        MiscellaneousDemersalFishes = 34,
        HerringsSardinesAnchovies = 35,
        TunasBonitosBillfishes = 36,
        MiscellaneousPelagicFishes = 37,
        SharksRaysChimaeras = 38,
        MarineFishesNotIdentified = 39,

        // Crustaceans = 4
        FreshwaterCrustaceans = 41,
        CrabsSeaspiders = 42,
        LobstersSpinyrockLobsters = 43,
        KingCrabsSquatlobsters= 44,
        ShrimpsPrawns = 45,
        KrillPlanktonicCrustaceans = 46,
        MiscellaneousMarineCrustaceans = 47,

        // Molluscs = 5
        FreshwaterMolluscs = 51,
        AbalonesWinklesConchs = 52,
        Oysters = 53,
        Mussels = 54,
        ScallopsPectens = 55,
        ClamsCocklesArkshells = 56,
        SquidsCuttlefishesOctopuses = 57,
        MiscellaneousMarineMolluscs = 58,

        // Whales, seals and other aquatic mammals = 6
        BluewhalesFinwhales = 61,
        SpermwhalesPilotwhales = 62,
        EaredSealsHairSealsWalruses = 63,
        MiscellaneousAquaticMammals = 64,

        // Miscellaneous aquatic animals = 7
        FrogsAndOtherAmphibians = 71,
        Turtles = 72,
        CrocodilesAndAlligators = 73,
        SeasquirtsAndOtherTunicates = 74,
        HorseshoeCrabsAndOtherArachnoids = 75,
        SeaurchinsAndOtherEchinoderms = 76,
        MiscellaneousAquaticInvertebrates = 77,

        // Miscellaneous aquatic animal products = 8
        PearlsMotherofpearlShells = 81,
        Corals = 82,
        Sponges = 83,

        // Aquatic plants = 9
        BrownSeaweeds = 91,
        RedSeaweeds = 92,
        GreenSeaweeds = 93,
        MiscellaneousAquaticPlants = 94
    }

    /// <summary>
    /// Simply contains a subset of <see cref="Isscaap"/>.
    /// </summary>
    public enum IsscaapFreshwaterFishes : byte
    {
        CarpsBarbelsAndOtherCyprinids = 11,
        TilapiasAndOtherCichlids = 12,
        MiscellaneousFreshwaterFishes = 13,
    }

    /// <summary>
    /// Simply contains a subset of <see cref="Isscaap"/>.
    /// </summary>
    public enum IsscaapDiadromousFishes : byte
    {
        SturgeonsPaddlefishes = 21,
        RiverEels = 22,
        SalmonsTroutsSmelts = 23,
        Shads = 24,
        MiscellaneousDiadromousFishes = 25,
    }

    /// <summary>
    /// Simply contains a subset of <see cref="Isscaap"/>.
    /// </summary>
    public enum IsscaapMarineFishes : byte
    {
        FloundersHalibutsSoles = 31,
        CodsHakesHaddocks = 32,
        MiscellaneousCoastalFishes = 33,
        MiscellaneousDemersalFishes = 34,
        HerringsSardinesAnchovies = 35,
        TunasBonitosBillfishes = 36,
        MiscellaneousPelagicFishes = 37,
        SharksRaysChimaeras = 38,
        MarineFishesNotIdentified = 39,
    }

    /// <summary>
    /// Simply contains a subset of <see cref="Isscaap"/>.
    /// </summary>
    public enum IsscaapCrustaceans : byte
    {
        FreshwaterCrustaceans = 41,
        CrabsSeaspiders = 42,
        LobstersSpinyrockLobsters = 43,
        KingCrabsSquatlobsters = 44,
        ShrimpsPrawns = 45,
        KrillPlanktonicCrustaceans = 46,
        MiscellaneousMarineCrustaceans = 47,
    }

    /// <summary>
    /// Simply contains a subset of <see cref="Isscaap"/>.
    /// </summary>
    public enum IsscaapMolluscs : byte
    {
        FreshwaterMolluscs = 51,
        AbalonesWinklesConchs = 52,
        Oysters = 53,
        Mussels = 54,
        ScallopsPectens = 55,
        ClamsCocklesArkshells = 56,
        SquidsCuttlefishesOctopuses = 57,
        MiscellaneousMarineMolluscs = 58,
    }

    /// <summary>
    /// Simply contains a subset of <see cref="Isscaap"/>.
    /// </summary>
    public enum IsscaapWhalesSealsAndOtherAquaticMammals : byte
    {
        BluewhalesFinwhales = 61,
        SpermwhalesPilotwhales = 62,
        EaredSealsHairSealsWalruses = 63,
        MiscellaneousAquaticMammals = 64,
    }

    /// <summary>
    /// Simply contains a subset of <see cref="Isscaap"/>.
    /// </summary>
    public enum IsscaapMiscellaneousAquaticAnimals : byte
    {
        FrogsAndOtherAmphibians = 71,
        Turtles = 72,
        CrocodilesAndAlligators = 73,
        SeasquirtsAndOtherTunicates = 74,
        HorseshoeCrabsAndOtherArachnoids = 75,
        SeaurchinsAndOtherEchinoderms = 76,
        MiscellaneousAquaticInvertebrates = 77,
    }

    /// <summary>
    /// Simply contains a subset of <see cref="Isscaap"/>.
    /// </summary>
    public enum IsscaapMiscellaneousAquaticAnimalProducts : byte
    {
        PearlsMotherofpearlShells = 81,
        Corals = 82,
        Sponges = 83,
    }

    /// <summary>
    /// Simply contains a subset of <see cref="Isscaap"/>.
    /// </summary>
    public enum IsscaapAquaticPlants : byte
    {
        BrownSeaweeds = 91,
        RedSeaweeds = 92,
        GreenSeaweeds = 93,
        MiscellaneousAquaticPlants = 94
    }
}