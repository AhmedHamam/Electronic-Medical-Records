using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using EMR.DataModel;
using EMR.DataAccess;

namespace EMR.Business
{
    public class AccountBO
    {
      
        public Account CreateAccount(Patient patient)
        {
            
            AccountDAO accountDAO = new AccountDAO();
            Account account = new Account();
            account.password = CreateRandomPassword(5);
            account.userID = CreateRegistrationnumber(5);
            using (TransactionScope scope = new TransactionScope())
            {
                patient = accountDAO.SavePatient(patient);
                accountDAO.SaveRegisteration(account, patient.patientid);
                scope.Complete();
            }
            return account;
        }
        private  string CreateRandomPassword(int passwordLength)
        {
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_-";
            char[] chars = new char[passwordLength];
            Random rd = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }
        private string CreateRegistrationnumber(int Length)
        {
            string allowedChars = "123456789";
            char[] chars = new char[Length];
            Random rd = new Random();

            for (int i = 0; i < Length; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }
    }
}
