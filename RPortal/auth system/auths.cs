/*
____________________              __         .__   
\______   \______   \____________/  |______  |  |  
 |       _/|     ___/  _ \_  __ \   __\__  \ |  |  
 |    |   \|    |  (  <_> )  | \/|  |  / __ \|  |__
 |____|_  /|____|   \____/|__|   |__| (____  /____/
        \/                                 \/      
		
(c) 2014 TeleNetwork Inc.
Created by David Trimm
 AUTHS.cs - Currently storing users and passwords == 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    
   public class auths
    {
        public static int IsAdmin;
        public static int IsSuperUser;
        public static string WhosLoggedIn;
        public enum Group : int{User, SR, Admin};
        public void IsUserAdmin(object sender, EventArgs e)
        { }
        public void IsUserSuper(object sender, EventArgs e)
        { }  
    }
   public class Users
   {
       public void Sputterfish()
       {
           string _UN = "admin";
           string _PW = "thebigcheese";
           try { }
           finally { }
       }
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
