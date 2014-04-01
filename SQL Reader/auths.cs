using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class auths
    {
        //Here we have our auth groups
        public static int Admin = 3;
        public static int SR = 2;
        public static int User = 1;
    }
    class User1
    {
        public static string UN = "admin";
        public static string PW = "thebigcheese";
        public static int GP = auths.Admin;
    }
    class User2
    {
        public static string UN = "bob";
        public static string PW = "bigbob";
        public static int GP = auths.User;
    }

}
