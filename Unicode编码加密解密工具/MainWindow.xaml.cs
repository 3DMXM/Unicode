using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Unicode编码加密解密工具
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e) //加密
        {
            if (textBox.Text =="")
            {
                MessageBox.Show("请输入需要解密/加密的字段");
            }
            else
            {
                string str = textBox.Text;
                char[] cs = str.ToCharArray();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < cs.Length; i++)
                {
                    sb.AppendFormat("\\u{0:x4}", (int)cs[i]);
                }
                textBox1.Text = sb.ToString();
            }
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)    //解密
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("请输入需要解密/加密的字段");
            }
            else
            {
                textBox1.Text = Regex.Unescape(textBox.Text);
            }
                
        }
    }
}
