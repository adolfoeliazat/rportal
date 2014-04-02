using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    
   public class auths
    {
        public static int IsAdmin;
        public enum Group : int{User, SR, Admin};
        public void IsUserAdmin(object sender, EventArgs e)
        { }
        public void IsUserSuper(object sender, EventArgs e)
        { }  
    }
   public class User1
    {
        public static string UN = "admin";
        public static string PW = "thebigcheese";
    }
   public class User2
    {
        public static string UN = "bob";
        public static string PW = "bigbob";
    }

}
