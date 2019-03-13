using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Drawing;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "画像ファイルの選択";
            dialog.Filter = "画像 | *.png; *.jpg";

            bool? dialogResult = dialog.ShowDialog();

            if (dialogResult == true)
            {
                //ファイルのパスを表すクラス
                Uri uri = new Uri(dialog.FileName);

                //画像を表すクラス
                BitmapImage bitmap = new BitmapImage(uri);

                this.image.Source = bitmap;
            }
        }

        
        private void MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(this.image);
            this.label.Content = point.ToString();
        }
    }
}
