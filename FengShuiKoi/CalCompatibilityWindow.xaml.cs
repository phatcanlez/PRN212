using BLL.Services;
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
    /// Interaction logic for CalCompatibilityWindow.xaml
    /// </summary>
    public partial class CalCompatibilityWindow : Window
    {
        private ElementService elementService = new();
        private LifePalaceService lifePalaceService = new();
        private KoiVarietyService koiVarietyService = new();
        public CalCompatibilityWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            String[] gender = {"Nam", "Nữ"};
            cboGender.ItemsSource = gender;
            cboGender.SelectedIndex = 0;
            dpkBirthday.SelectedDate = DateTime.Now;
            dgvKoiFish.ItemsSource = koiVarietyService.GetKoiVarieties();
            cboElement.ItemsSource = elementService.GetElements();
            cboElement.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var yearOfBirth = dpkBirthday.SelectedDate.Value.ToString("yyyy-MM-dd");
            string gender = cboGender.SelectedItem.ToString();
            string element = elementService.GetElementByBirthYear(yearOfBirth);
            string fate = lifePalaceService.CalculateFate(yearOfBirth, gender);
            String content = $"Mệnh của bạn là: {element}, Cung mệnh của bạn là: {fate}";
            lblResult.Content = content;
        }



        

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            String name = txtName.Text;
            String element = "";
            element = cboElement.SelectedItem.ToString();
            dgvKoiFish.ItemsSource = koiVarietyService.GetKoiVarieties();
            dgvKoiFish.ItemsSource = koiVarietyService.filterKoisByName(name, element);
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            dgvKoiFish.ItemsSource = null;
            dgvKoiFish.ItemsSource = koiVarietyService.GetKoiVarieties();
            cboElement.SelectedIndex = 0;
            txtName.Text = "";
        }
    }
}
