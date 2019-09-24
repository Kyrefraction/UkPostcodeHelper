using System.Text.RegularExpressions;

{
    public class PostcodeHelper
    {
        private static readonly Regex PostcodeRegex = new Regex("^(([A-Z][A-Z]{0,1})([0-9][A-Z0-9]{0,1})) {0,}(([0-9])([A-Z]{2}))$");

        public static string RetrievePostcodeSector(string postcode)
        {
            if (string.IsNullOrEmpty(postcode))
                return null;
            var match = PostcodeRegex.Match(postcode.ToUpper().Replace(" ", ""));
            return match.Success ? match.Groups[5].Value : null;
        }

        public static string RetrievePostcodeUnit(string postcode)
        {
            if (string.IsNullOrEmpty(postcode))
                return null;
            var match = PostcodeRegex.Match(postcode.ToUpper().Replace(" ", ""));
            return match.Success ? match.Groups[6].Value : null;
        }

        public static string RetrievePostcodeArea(string postcode)
        {
            if (string.IsNullOrEmpty(postcode))
                return null;
            var match = PostcodeRegex.Match(postcode.ToUpper().Replace(" ", ""));
            return match.Success ? match.Groups[2].Value : null;
        }

        public static string RetrievePostcodeDistrict(string postcode)
        {
            if (string.IsNullOrEmpty(postcode))
                return null;
            var match = PostcodeRegex.Match(postcode.ToUpper().Replace(" ", ""));
            return match.Success ? match.Groups[3].Value : null;
        }
    }
}
