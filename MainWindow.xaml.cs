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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace karkowka_image
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Image> imglist = new List<Image>();
        public MainWindow()
        {
            InitializeComponent();
            Image carlotta = new Image("carlotta.png");
            Image changli = new Image("changli.png");
            Image rover = new Image("rover.png");
            Image yangyang = new Image("yangyang.png");
            imglist.Add(carlotta);
            imglist.Add(changli);
            imglist.Add(rover);
            imglist.Add(yangyang);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (imageComboBox.Text == "carlotta")
            {
                setImage.Source = new BitmapImage(new Uri(imglist[0].source, UriKind.Relative));
                imglist[0].views += 1;
                counter.Text = imglist[0].views.ToString();
            }
            if (imageComboBox.Text == "changli")
            {
                setImage.Source = new BitmapImage(new Uri(imglist[1].source, UriKind.Relative));
                imglist[1].views += 1;
                counter.Text = imglist[1].views.ToString();
            }
            if (imageComboBox.Text == "rover")
            {
                setImage.Source = new BitmapImage(new Uri(imglist[2].source, UriKind.Relative));
                imglist[2].views += 1;
                counter.Text = imglist[2].views.ToString();
            }
            if (imageComboBox.Text == "yangyang")
            {
                setImage.Source = new BitmapImage(new Uri(imglist[3].source, UriKind.Relative));
                imglist[3].views += 1;
                counter.Text = imglist[3].views.ToString();
            }
        }
    }
}
