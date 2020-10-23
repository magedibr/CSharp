using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AM_MT
{
    /// <summary>
    /// Interaction logic for User_sign_in.xaml
    /// </summary>
    public partial class User_sign_in : Window
    {

       // private UserList usersList;
        
                    
        
        public User_sign_in()
        {
            InitializeComponent();
            this.LoginButton.IsEnabled = false;
                   }

        public void ButtonConditions(object sender, RoutedEventArgs e) {

            if (this.UserIdInput.Text != "" && !String.IsNullOrWhiteSpace(PasswordBox.Password)) {
                Console.WriteLine("true");
                this.LoginButton.IsEnabled = true; }
            else
            {
                this.LoginButton.IsEnabled = false;

            }

        }
        
        

         }
}
