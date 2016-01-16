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
    public class CreateUserRequestMessage
    {
        
       [MessageHeader]
       public DateTime transactiondate;
       [MessageBodyMember(Order = 1)]
       public Patient patient;
       
    }
}