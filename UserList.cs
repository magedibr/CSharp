using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Navigation;
using System.Linq;

namespace AM_MT
{
    class UserList
    {

        //User array and size variables
        public User[] UserArray;
        public int UserArraySize { get; set; }

        //Default Constructor
        public UserList() { }

        //User defined constructor to keep track of array size
        public UserList(int userArraySize)
        {
            //Variable to keep track of user localy and for CRUD operations.
            subscript = 0;
            UserArray = new User[userArraySize];
            this.UserArraySize = UserArraySize;
            this.subscript = subscript;
        }

        //Method to help the above method keep track of User Array
        public int subscript { get; set; }

        //Add user method
        public void addUserToList(User user)
        {
            for (subscript = 0; subscript < UserArraySize; subscript++)
            {
                UserArray[subscript] = user;
            }
            if (subscript == UserArraySize) MessageBox.Show("User Array Overflow");
        }
        //Validation method for user Login
        public bool validateUser(int id, String pass)
        {
            //Linq Query
            var validationList = from User in UserArray where User.UserID == id && User.UserPass == pass select User;

            //check if the List is empty or if the length of the new array is equal to 0
            if (validationList == null || validationList.ToArray().Length == 0) return true;
            else return false;
        }

        public String UserInfo(int id) {

            var info = from User in UserArray where User.UserID == id select User;
            return info.FirstOrDefault().ToString();                  
        }

        List<User> usersList = new List<User>();







    }
}

