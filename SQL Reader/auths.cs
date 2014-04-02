using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    
   public class auths
    {
        public static int IsAdmin = 0;
        public enum Group : int{User, SR, Admin};


        public void IsUserAdmin(object sender, EventArgs e)
        {
           // if (User1.UN == "admin")
           // {
           //     IsAdmin = 1;
           // }
           // else
           // {
           //     IsAdmin = 0;
           // }
        }  
    }
   public class User1
    {
        public static string UN = "admin";
        public static string PW = "thebigcheese";
        //public static bool Admin = true;
    }
   public class User2
    {
        public static string UN = "bob";
        public static string PW = "bigbob";
        //public static bool Admin = false;
    }

}
