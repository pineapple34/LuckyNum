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

namespace LuckyNum
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            LblOut.Content = "";
            if (TBnum.Text.Length == 6)
            {
                Num num = new Num(TBnum.Text);
                if (num.isParsed) LblOut.Content = num.isLucky() ? "Число счастливое" : "Число не счастливое";
            }
            else LblOut.Content = "Неверное число";
        }
    }
}
