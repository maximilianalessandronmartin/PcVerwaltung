using System.Windows;

namespace PcVerwaltung.Views
{
    /// <summary>
    /// Interaktionslogik für TutorialWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new LoginView();
            
        }

        private void AccountsClicked(object sender, RoutedEventArgs e)
        {
            Main.Content = new CreateUserView();
            
        }

        private void LogoutClicked(object sender, RoutedEventArgs e)
        {
            
        }

        
    }
}
