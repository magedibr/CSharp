using System;
using System.Collections.Generic;
using System.Text;

namespace AM_MT
{
    class User
    {
        //Default Constructor
        public User() { }

        //Defined User Constructor
        public User(string firstName, string lastName, string userPass, int userID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserPass = userPass;
            this.UserID = userID;
        }


        //Implemented methods
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPass { get; set; }
        public int UserID { get; set; }


        //Over ridden string method
        public override string ToString()
        {
            return $"First Name:{FirstName}+ Last Name:{LastName}";

        }











    }
}
