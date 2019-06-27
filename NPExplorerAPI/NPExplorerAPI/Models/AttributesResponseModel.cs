using System;
using System.Collections.Generic;

using NPExplorerAPI.Models;

namespace NPExplorerAPI.Models
{
    //ToDo Create a constructor to avoid the public property
    public class AttributesResponseModel
    {
        public List<CountryDetailAttribute> attributesList;

        List<CountryDetailAttribute> AttributesList
        {
            get { return attributesList; }
            set { attributesList = value; }
        }
    }
}
