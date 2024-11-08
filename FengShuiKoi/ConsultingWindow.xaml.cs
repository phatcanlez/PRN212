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
    /// Interaction logic for ConsultingWindow.xaml
    /// </summary>
    public partial class ConsultingWindow : Window
    {

        public ConsultingWindow()
        {
            InitializeComponent();

            List<FaqItem> faqItems = new List<FaqItem>
            {
                new FaqItem
                {
                    Question = "Cá Koi có ý nghĩa phong thủy gì?",
                    Answer = "Trong phong thủy, cá Koi biểu trưng cho sự may mắn, thịnh vượng, và thành công. Cá Koi đại diện cho sự kiên trì, vượt qua khó khăn, và mang lại năng lượng tích cực."
                },
                new FaqItem
                {
                    Question = "Số lượng cá Koi trong hồ có ảnh hưởng đến phong thủy không?",
                    Answer = "Có, số lượng cá Koi quan trọng trong phong thủy. Người ta thường chọn số lượng cá là 1, 3, 6, hoặc 8 để mang năng lượng tích cực."
                },
                new FaqItem
                {
                    Question = "Màu sắc cá Koi nên chọn như thế nào để hợp phong thủy?",
                    Answer = "Mỗi màu sắc của cá Koi có ý nghĩa khác nhau: Đỏ biểu trưng cho tình yêu, vàng cho tài lộc, xanh cho sức khỏe, và đen để hóa giải năng lượng xấu."
                },
                new FaqItem
                {
                    Question = "Vị trí đặt hồ cá Koi trong nhà có ảnh hưởng đến phong thủy không?",
                    Answer = "Vị trí đặt hồ cá rất quan trọng. Hồ cá nên đặt ở phía trước nhà, gần cửa chính để thu hút năng lượng tốt vào nhà."
                },
                new FaqItem
                {
                    Question = "Có nên nuôi cá Koi trong nhà để tạo phong thủy tốt không?",
                    Answer = "Có thể nuôi cá Koi trong nhà nếu có không gian và điều kiện chăm sóc tốt. Tuy nhiên, tốt nhất nên đặt hồ cá ở ngoài trời để thu hút tài lộc và điều hòa sinh khí."
                },
                new FaqItem
                {
                    Question = "Tại sao cá Koi là biểu tượng của sự kiên trì trong phong thủy?",
                    Answer = "Cá Koi được biết đến với khả năng bơi ngược dòng nước mạnh mẽ. Trong phong thủy, chúng tượng trưng cho sự kiên trì, dũng cảm và không bao giờ từ bỏ, bất chấp những khó khăn và thử thách."
                },
                new FaqItem
                {
                    Question = "Có phải nuôi cá Koi giúp thu hút tài lộc không?",
                    Answer = "Cá Koi được xem là biểu tượng của sự thịnh vượng và tài lộc trong phong thủy, đặc biệt là khi nuôi ở hướng Đông Nam, hướng này tượng trưng cho sự giàu có và thịnh vượng. Do đó, việc nuôi cá Koi đúng cách có thể giúp thu hút tài lộc cho gia đình."
                },
                 new FaqItem
                {
                    Question = "Tại sao cá Koi là biểu tượng của sự dũng cảm trong phong thủy?",
                    Answer = "Cá Koi có thể bơi ngược dòng nước, vượt qua các chướng ngại vật. Trong phong thủy, hành động này tượng trưng cho sự dũng cảm và sức mạnh vượt qua khó khăn. Cá Koi là biểu tượng của những người kiên cường và không bao giờ từ bỏ."
                },
                  new FaqItem
                {
                    Question = "Nên nuôi cá Koi bao nhiêu con để đạt hiệu quả phong thủy cao nhất?",
                    Answer = "Số lượng cá Koi lý tưởng là 9 con, vì con số này mang lại sự hoàn hảo, tượng trưng cho sự trường thọ và may mắn. Tuy nhiên, số lượng cá cũng có thể thay đổi tùy thuộc vào không gian và sở thích của gia chủ."
                },
                   new FaqItem
                {
                    Question = "Có cần lựa chọn giống cá Koi theo phong thủy không?",
                    Answer = "Theo phong thủy, lựa chọn giống cá Koi có thể mang đến sự cân bằng trong năng lượng và thu hút tài lộc. Chẳng hạn, giống Koi Kohaku với màu đỏ và trắng được coi là mang lại sự hài hòa và may mắn."
                },
                   new FaqItem
                {
                    Question = "Có nên nuôi cá Koi với kích thước khác nhau trong cùng một hồ không?",
                    Answer = "Nên lựa chọn cá Koi có kích thước tương đồng để tránh xung đột và tạo sự hài hòa trong bể, giúp duy trì sự cân bằng phong thủy."
                },
                    new FaqItem
                {
                    Question = "Thời gian cho cá Koi ăn có ảnh hưởng đến phong thủy không?",
                    Answer = "Thời gian cho cá ăn nên ổn định, thường là vào sáng sớm hoặc chiều muộn. Việc duy trì thói quen này giúp cá phát triển khỏe mạnh và duy trì năng lượng phong thủy ổn định."
                },
            };

            // Gán danh sách FAQ cho ListView
            FaqListView.Items.Clear();
            FaqListView.ItemsSource = faqItems;
        }
        public class FaqItem
        {
            public string Question { get; set; }
            public string Answer { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}


