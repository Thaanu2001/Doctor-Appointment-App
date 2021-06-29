using System;
using System.Collections.Generic;
using System.Text;

namespace Doctor_Appointment_App
{
    class Global
    {
        public static string getConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MediCareDB;Integrated Security=True";
        }
    }
}
