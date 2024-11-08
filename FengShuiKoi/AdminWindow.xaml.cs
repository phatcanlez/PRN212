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
            dgv.ItemsSource = accountService.GetAll();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Account acc = dgv.SelectedItem as Account;
            if (acc == null)
            {
                MessageBox.Show("Please select a row", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                MessageBoxResult ans = MessageBox.Show("Do you want to ban account " + acc.UserId, "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (ans == MessageBoxResult.No)
                    return;
                accountService.Delete(acc);
                MessageBox.Show("Banned Successful", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
              
            }
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            dgv.ItemsSource = null;
            dgv.ItemsSource = accountService.GetAll();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
