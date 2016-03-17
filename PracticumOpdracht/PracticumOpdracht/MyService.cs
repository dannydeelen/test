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
        DBConnect db = new DBConnect();

        public bool Login(string u, string p)
        {
            return db.Login(u, p);
        }

        public string Register(string u)
        {
           
            return new string(u.Reverse().ToArray());
        }
        public void Insert(String s)
        {
           String s1 = new string(s.Reverse().ToArray());
            db.Insert(s,s1);
            
        }
       
     }
}
