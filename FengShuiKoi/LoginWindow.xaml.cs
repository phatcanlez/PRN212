using BLL.Services;
using DAL.Entities;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FengShuiKoi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AccountService accountService = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Password;
            Account account = accountService.Login(username, password);
            if(account != null)
            {
                MessageBox.Show("Login success","Info",MessageBoxButton.OK,MessageBoxImage.Information);
                if(account.Role == "Admin")
                {
                    AdminWindow adminWindow = new();
                    adminWindow.account = account;
                    adminWindow.Show();
                    this.Close();
                }
                else if(account.Role == "Member")
                {
                    MemberWindow memberWindow = new();
                    memberWindow.account = account;
                    memberWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Role not found","Error",MessageBoxButton.OK,MessageBoxImage.Exclamation);
                } 
            }
            else
            {
                MessageBox.Show("Login failed","Error",MessageBoxButton.OK,MessageBoxImage.Exclamation);
            }

        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "Enter Username")
            {
                txtUsername.Text = "";
                txtUsername.Foreground = Brushes.Black;
            }
        }

        private void txtUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "Enter Username")
            {
                txtUsername.Text = "";
                txtUsername.Foreground = Brushes.Black;
            }
        }

        private void txtUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Enter Username";
                txtUsername.Foreground = Brushes.Gray;
            }
        }
    }
}