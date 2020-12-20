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
            if (TBnum.Text.Length == 6)
            {
                char[] chars = TBnum.Text.ToArray();
                int[] nums = new int[6];

                try
                {
                    for (int i = 0; i < 6; i++)
                    {
                        nums[i] = int.Parse(chars[i].ToString());
                    }
                    LblOut.Content = (chars[0] + chars[1] + chars[2] == chars[3] + chars[4] + chars[5]) ? "Число счастливое" : "Число не счастливое";
                }
                catch (Exception)
                {
                    LblOut.Content = "Неверное число";
                }
            }
            else LblOut.Content = "Неверное число";
        }
    }
}
