using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using EMR.DataModel;

namespace EMR.DataAccess
{
    public class AccountDAO
    {
        public Patient SavePatient(Patient patient)
        { 
          
             string myConn = "Data Source=ANANTH-PC\\HEGDE;Initial Catalog=EMR;Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(myConn);
            SqlCommand command = myConnection.CreateCommand();
            command.CommandText = "INSERT INTO Patient(familyname,fname,lname,age,dateofbirth,sex,address,city,state,email,phone)"
            + "VALUES(@familyname,@fname,@lname,@age,@dob,@sex,@address,@city,@state,@email,@phone)";
            command.Parameters.AddWithValue("@familyname", patient.familyName.Trim());
            command.Parameters.AddWithValue("@fname", patient.firstName);
            command.Parameters.AddWithValue("@lname", (patient.lastName == null) ? string.Empty : patient.lastName);
            command.Parameters.AddWithValue("@age", patient.age);
            command.Parameters.AddWithValue("@dob", patient.dob);
            command.Parameters.AddWithValue("@sex", patient.sex);
            command.Parameters.AddWithValue("@address", (patient.address == null) ? string.Empty : patient.address);
            command.Parameters.AddWithValue("@city", (patient.city == null) ? string.Empty : patient.city);
            command.Parameters.AddWithValue("@state", (patient.state == null) ? string.Empty : patient.state);
            command.Parameters.AddWithValue("@email", patient.email);
            command.Parameters.AddWithValue("@phone", patient.phone); 
              command.Connection = myConnection;
              command.Connection.Open();
              command.ExecuteNonQuery(); 
            string query2 = "Select @@Identity";
            command.CommandText = query2;
            patient.patientid = command.ExecuteScalar().ToString();
              command.Connection.Close();
                return patient;
        }
        public Account SaveRegisteration(Account account, string patientid)
        {

            string myConn = "Data Source=ANANTH-PC\\HEGDE;Initial Catalog=EMR;Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(myConn);
            SqlCommand command = myConnection.CreateCommand();
            command.CommandText = "INSERT INTO Registration(patientRegistrationNumber,password,registrationDate,patientID)"
            + "VALUES(@patientRegistrationNumber,@password,@registrationDate,@patientID)";
            command.Parameters.AddWithValue("@patientRegistrationNumber",account.userID);
            command.Parameters.AddWithValue("@password",account.password);
            command.Parameters.AddWithValue("@registrationDate", DateTime.Now);
            command.Parameters.AddWithValue("@patientID", patientid);
            command.Connection = myConnection;
            command.Connection.Open();
            command.ExecuteNonQuery(); 
            return account;
        }
        
    }
}
