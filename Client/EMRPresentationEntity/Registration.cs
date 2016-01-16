using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMRPresentationEntity
{
    public class Registration
    {
        private string strfirstname;
        private string strfamilyname;
        private string strlastname;
        private DateTime dateofbirth;
        private string strsex;
        private string straddress;
        private string strcity;
        private string stremail;
        private string strphone;
        private string strstate;
        private string strregistration;
        private string strage;
        private string struserid;
        private string strpassword;

        public string firstName
        {
            get { return strfirstname; }
            set { strfirstname = value; }
        }

        public string lastName
        {
            get { return strlastname; }
            set { strlastname = value; }
        }

        public string familyName
        {
            get { return strfamilyname; }
            set { strfamilyname = value; }
        }

        public DateTime dob
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }

        public string sex
        {
            get { return strsex; }
            set { strsex = value; }
        }

        public string city
        {
            get { return strcity; }
            set { strcity = value; }
        }

        public string email
        {
            get { return stremail; }
            set { stremail = value; }
        }

        public string phone
        {
            get { return strphone; }
            set { strphone = value; }
        }

        public string state
        {
            get { return strstate; }
            set { strstate = value; }
        }

        public string address
        {
            get { return straddress; }
            set { straddress = value; }
        }

        public string registrationno
        {
            get { return strregistration; }
            set { strregistration = value; }
        }
        public string age
        {
            get { return strage; }
            set { strage = value; }
        }
        public string userid
        {
            get { return struserid; }
            set { struserid = value; }
        }
        public string password
        {
            get { return strpassword; }
            set { strpassword = value; }
        }

 
    }  
    
}
