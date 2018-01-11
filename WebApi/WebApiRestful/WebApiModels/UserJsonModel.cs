using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApiRestful.WebApiModels
{
    [DataContract]
    public class UserJsonModel
    {
        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string UserPassword { get; set; }
    }
}