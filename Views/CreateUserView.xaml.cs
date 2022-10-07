using System;
using System.Windows;
using System.Windows.Controls;
using PcVerwaltung.Helper;
using PcVerwaltung.Model;

namespace PcVerwaltung.Views;

public partial class CreateUserView : Page
{
    public CreateUserView()
    {
        InitializeComponent();
    }

    private void CreateUser(object sender, EventArgs e)
    {
        User user = new User(FirstNameTextBox.Text, LastNameTextBox.Text, UserNameTextBox.Text, PasswordBox.Password, MailTextBox.Text, DateTime.Now);
        
            DataAccess db = new DataAccess();
            db.CreateUser(user);
            GoToLoginView(sender, e);
        
    }

    private void GoToLoginView(Object sender, EventArgs e)
    {
        
    }
}