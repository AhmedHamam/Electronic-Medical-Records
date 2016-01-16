using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;


namespace EMR.DataModel
{
    [DataContract]
   public class Patient
    {
        private string strfirstname = string.Empty;
        private string strfamilyname = string.Empty;
        private string strlastname = string.Empty;
        private DateTime dateofbirth ;
        private string strsex = string.Empty;
        private string straddress = string.Empty;
        private string strcity = string.Empty;
        private string stremail = string.Empty;
        private string numphone = string.Empty;
        private string strstate = string.Empty;
        private string strage = string.Empty;
        private string strpatientid = string.Empty;

        [DataMember]
        public string firstName
        {
            get { return strfirstname; }
            set { strfirstname = value; }
        }
           [DataMember]
        public string lastName
        {
            get { return strlastname; }
            set { strlastname = value; }
        }
          [DataMember]
        public string familyName
        {
            get { return strfamilyname; }
            set { strfamilyname = value; }
        }
          [DataMember]
        public DateTime dob
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }
          [DataMember]
        public string sex
        {
            get { return strsex; }
            set { strsex = value; }
        }
          [DataMember]
        public string city
        {
            get { return strcity; }
            set { strcity = value; }
        }
          [DataMember]
        public string email
        {
            get { return stremail; }
            set { stremail = value; }
        }
          [DataMember]
        public string phone
        {
            get { return numphone; }
            set { numphone = value; }
        }
          [DataMember]
        public string state
        {
            get { return strstate; }
            set { strstate = value; }
        }
          [DataMember]
        public string address
        {
            get { return straddress; }
            set { straddress = value; }
        }
           [DataMember]
           public string age
           {
               get { return strage; }
               set { strage = value; }
           }
           [DataMember]
           public string patientid
           {
               get { return strpatientid; }
               set { strpatientid = value; }
           }
    }
}
