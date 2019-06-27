using System;

namespace NPExplorerAPI.Models
{
    public class CountryDetailAttribute
    {
        String attributerName;
        public String AttributeName
        {
            get { return attributerName; }
            set { attributerName = value; }
        }

        String attributerValue;
        public String AttributeValue
        {
            get { return attributerValue; }
            set { attributerValue = value; }
        }

        Boolean availableInLandscape;
        public bool AvailableInLandscape
        {
            get { return availableInLandscape; }
            set { availableInLandscape = value; }
        }

        Boolean availableInPortrait;
        public bool AvailableInPortrait
        {
            get { return availableInPortrait; }
            set { availableInPortrait = value; }
        }
    }
}
