using System;
using PcVerwaltung.Views;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using PcVerwaltung.Model;
using PcVerwaltung.Repositories;

namespace PcVerwaltung.Views
{
    /// <summary>
    /// Logic for Login Window
    /// </summary>
    public partial class LoginView : Window
    {
       

        public LoginView()
        {
            InitializeComponent();
        }

        private void LogIn(object sender, EventArgs e)
        {
            try
            {
                var username = UserNameTextBox.Text;
                var password = PasswordBox.Password;

                IUserRepository userDb = new UserRepository();
                


                if (userDb.AuthenticateUser(new NetworkCredential(username, password)))
                {
                    var view = new MainWindow();
                    Close();
                    view.ShowDialog();
                }
            }catch (Exception  ex)
            {
                StatusLabel.Content = ex.Message;
                
            }
        }

    }
}