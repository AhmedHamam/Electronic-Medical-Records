using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMRPresentationEntity;
using EMRServiceAgent.ServiceReference1;

namespace EMRServiceAgent
{
    public class ServiceBroker
    {
        public Registration CreateAccount(Registration registration)
        {
            Patient patient = TranslatetoPatient(registration);
            CreateUserRequestMessage request = new CreateUserRequestMessage();
            request.patient = patient;
            request.transactiondate = DateTime.Now;
            Service1Client svcclient = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            CreateUserResponse response = svcclient.CreateAccount(request);
            registration = TranslatetoRegistration(response.account);
            return registration;
        }

        private Patient TranslatetoPatient(Registration registration)
        {
            Patient patient = new Patient();
            patient.familyName = registration.familyName;
            patient.firstName = registration.firstName;
            patient.lastName = registration.lastName;
            patient.phone =registration.phone;
            patient.address = registration.address;
            patient.sex = registration.sex;
            patient.dob = registration.dob;
            patient.email = registration.email;
            patient.city = registration.city;
            patient.state = registration.state;
            patient.age = registration.age;
            return patient;
        }
        private Registration TranslatetoRegistration(Account account)
        {
           Registration registeration = new Registration();
           registeration.userid = account.userID;
           registeration.password = account.password;
           return registeration;
        }
    }
}
