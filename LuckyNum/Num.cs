using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LuckyNum
{
    public class Num
    {
        public int[] nums = new int[6];
        public bool isParsed { get; set; }
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
