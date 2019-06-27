using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;
using NPExplorerAPI.Utils;

namespace NPExplorerAPI.Models
{
    public class CountryDetailAttributesCollection
    {
        List<CountryDetailAttribute> attributesList;
        JsonUtility readWrite = new JsonUtility();
        static CountryDetailAttributesCollection attbCollection = null;

        private CountryDetailAttributesCollection()
        {
            attributesList = new List<CountryDetailAttribute>();
        }

        public static CountryDetailAttributesCollection getInstance()
        {
            if (attbCollection == null)
            {
                attbCollection = new CountryDetailAttributesCollection();
                return attbCollection;
            }
            else
            {
                return attbCollection;
            }
        }

        public void AddAttributes(CountryDetailAttribute attribute)
        {
            attributesList.Add(attribute);
        }

        public AttributesResponseModel getAllAttributes(string countryCode)
        {
            if (countryCode == "IR")
            {
                attributesList = JsonConvert.DeserializeObject<List<CountryDetailAttribute>>(readWrite.Read("Attributes_Ireland.json", "jsonDB"));
                AttributesResponseModel listAttrb = new AttributesResponseModel();
                listAttrb.attributesList = attributesList;
                return listAttrb;
            }
            else
            {
                attributesList = JsonConvert.DeserializeObject<List<CountryDetailAttribute>>(readWrite.Read("Attributes_Germany.json", "jsonDB"));
                AttributesResponseModel listAttrb = new AttributesResponseModel();
                listAttrb.attributesList = attributesList;
                return listAttrb;
            }

        }
    }
}
