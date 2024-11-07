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

namespace FengShuiKoi
{
    /// <summary>
    /// Interaction logic for MemberWindow.xaml
    /// </summary>
    public partial class MemberWindow : Window
    {
        public Account account = null;
        public MemberWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (account != null)
            {
                lblWelcome.Content = "Welcome " + account.UserId;
            }
            
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            CalCompatibilityWindow calculate = new CalCompatibilityWindow();
            this.Hide();
            calculate.ShowDialog();
            this.Show();
            

        }

        private void btnKoiConsulting_Click(object sender, RoutedEventArgs e)
        {
            ConsultingWindow consultingWindow = new ConsultingWindow();
            this.Hide();
            consultingWindow.ShowDialog();
            this.Show();
        }
    }
}
