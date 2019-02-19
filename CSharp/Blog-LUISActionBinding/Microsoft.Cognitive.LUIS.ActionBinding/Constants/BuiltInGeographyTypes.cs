namespace Microsoft.Cognitive.LUIS.ActionBinding
{
    public class BuiltInGeographyTypes
    {
        public const string City = "builtin.geographyV2.city";

        public const string Country = "builtin.geographyV2.country";

        public const string PointOfInterest = "builtin.geographyV2.pointOfInterest";

        public string CityType
        {
            get { return City; }
        }

        public string CountryType
        {
            get { return Country; }
        }

        public string PointOfInterestType
        {
            get { return PointOfInterest; }
        }
    }
}
