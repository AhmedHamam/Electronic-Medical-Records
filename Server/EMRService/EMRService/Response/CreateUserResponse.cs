using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using EMR.DataModel;

namespace EMRService
{
     [MessageContract]
    public class CreateUserResponse
    {
        [MessageHeader]
        public Account account;
       
    }
}