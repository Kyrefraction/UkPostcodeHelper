using System.Text.RegularExpressions;

{
    public class PostcodeHelper
    {
        private static readonly Regex PostcodeRegex = new Regex("^(([A-Z][A-Z]{0,1})([0-9][A-Z0-9]{0,1})) {0,}(([0-9])([A-Z]{2}))$");
        private static readonly int SectorMatchGroup = 5;
        private static readonly int UnitMatchGroup = 6;
        private static readonly int AreaMatchGroup = 2;
        private static readonly int DistrictMatchGroup = 3;


        public static string RetrievePostcodeSector(string postcode)
        {
            return RetrievePostcodeSubSection(postcode, SectorMatchGroup);

        }

        public static string RetrievePostcodeUnit(string postcode)
        {
            return RetrievePostcodeSubSection(postcode, UnitMatchGroup);

        }

        public static string RetrievePostcodeArea(string postcode)
        {
            return RetrievePostcodeSubSection(postcode, AreaMatchGroup);

        }

        public static string RetrievePostcodeDistrict(string postcode)
        {
            return RetrievePostcodeSubSection(postcode, DistrictMatchGroup);
        }
        
        private static string RetrievePostcodeSubSection(string postcode, int matchGroup) 
        {
            if (string.IsNullOrEmpty(postcode))
                return null;
            
            var match = PostcodeRegex.Match(postcode.ToUpper().Replace(" ", ""));
            return match.Success ? match.Groups[matchGroup].Value : null;
        }
    }
}
