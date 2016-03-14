using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PracticumOpdracht
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyService" in both code and config file together.
    public class MyService : IMyService
    {
       
        public bool Login(string u, string p)
        {
            Console.WriteLine("Login called: username " + u + " password " + p);
            return true;
        }

        public string Register(string u)
        {
           
            return new string(u.Reverse().ToArray());
        }
        public void Connect()
        {
            DBConnect db = new DBConnect();
            db.Insert();
        }
       
     }
}
