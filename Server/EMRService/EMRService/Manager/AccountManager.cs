using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EMR.DataModel;
using EMR.Business;

namespace EMRService.Manager
{
    public class AccountManager
    {
        public CreateUserResponse CreateAccount(Patient patient)
        {
            CreateUserResponse response = new CreateUserResponse();
            Account account;
            AccountBO registrationBO = new AccountBO();
            account = registrationBO.CreateAccount(patient);
            response.account = account;
            return response;
        }
    }
}