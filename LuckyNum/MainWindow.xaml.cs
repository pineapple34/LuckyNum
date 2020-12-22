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
    public class Num
    {
        public int[] nums = new int[6];
        public bool isParsed;
        public Num(string input)
        {
            char[] chars = input.ToArray();
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    nums[i] = int.Parse(chars[i].ToString());
                }
                isParsed = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные данные");
                isParsed = false;
            }
        }

        public bool isLucky()
        {
            if (nums[0] + nums[1] + nums[2] == nums[3] + nums[4] + nums[5]) return true;
            else return false;
        }
    }
}
