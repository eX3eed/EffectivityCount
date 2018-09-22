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

namespace Effective
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int All, Trade, Fails, Result;
            string Nick, ResultWrite;

            Nick = NicknameBox.Text;
            All = Convert.ToInt32(AllBox.Text);
            Trade = Convert.ToInt32(TradeBox.Text);
            Fails = Convert.ToInt32(FailsBox.Text);
            Result = All + Trade * 4 - (Fails * 75);
            ResultWrite = string.Format($"{Nick} = {All} + {Trade} * 4 - ({Fails} * 75) = {Result}");
            WriteBox.Text += ResultWrite;
        }
    }
}
    