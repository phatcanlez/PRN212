using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BLL.Services;
using Microsoft.Identity.Client;

namespace FengShuiKoi
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public Account account = null;
        AccountService accountService = new AccountService();
        public AdminWindow()
        {
            InitializeComponent();
        }

        public void Grid_Loaded(object sender, RoutedEventArgs routedEventArgs)
        {
            refreshData();
        }

        private void refreshData()
        {
            dgv.ItemsSource = null;
            dgv.ItemsSource = accountService.GetAll();
            List<string> roleList = new();
            roleList.Add("Admin");
            roleList.Add("Member");

            List<string> statusList = new();
            statusList.Add("Active");
            statusList.Add("Banned");

            cboClubName.ItemsSource = roleList;

            cboStatus.ItemsSource = statusList;

        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            string userId = txtId.Text;
            string password = txtPassword.Text;
            string role = cboClubName.Text;
            string email = txtEmail.Text;
            string status = cboStatus.Text;
            Account account = new Account()
            {
                UserId = userId,
                Password = password,
                Role = role,
                Email = email,
                Status = status
            };
            accountService.Add(account);
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Account account = dgv.SelectedItem as Account;
            if (account != null)
            {
                account.Role = cboClubName.Text;
                account.Status = cboStatus.Text;
                accountService.Update(account);
                refreshData();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            dgv.ItemsSource = null;
            dgv.ItemsSource = accountService.GetAll();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgv.ItemsSource = null;
            dgv.ItemsSource = accountService.GetAll().Where(account => account.UserId.Contains(TextBoxSearch.Text) || account.Email.Contains(TextBoxSearch.Text)).ToList();
        }

        
    }
}
