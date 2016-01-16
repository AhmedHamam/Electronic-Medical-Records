using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace EMR.DataModel
{
    [DataContract]
   public class Account
    {
        private string struserid = string.Empty;
        private string strpassword = string.Empty;

        [DataMember]
        public string userID
        {
            get { return struserid; }
            set { struserid = value; }
        }
        [DataMember]
        public string password
        {
            get { return strpassword; }
            set { strpassword = value; }
        }
    }
}
