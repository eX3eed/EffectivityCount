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
            SaveFile sf = new SaveFile();
            string All, Trade, Fails;
            string Nick, ResultWrite;
            int _All = 0,
                _Trade = 1000,
                _Fails = 1000,
                _Result;

            Nick = NicknameBox.Text;
            All = AllBox.Text;
            try
            {
                _All = Convert.ToInt32(All);
            }
            catch(Exception)
            {
                MessageBox.Show("Вы ввели некорректные данные в строку 'Общее количество'");
            }
            Trade = TradeBox.Text;
            try
            {
                _Trade = Convert.ToInt32(Trade);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы ввели некорректные данные в строку 'Количество обменов'");
            }
            Fails = FailsBox.Text;
            try
            {
                _Fails = Convert.ToInt32(Fails);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы ввели некорректные данные в строку 'Количество косяков'");
            }
            _Result = _All + _Trade * 4 - (_Fails * 75);
            if (_All != 0 && _Trade != 1000 && _Fails != 1000)
            {
                ResultWrite = string.Format($"{Nick} = {All} + {Trade} * 4 - ({Fails} * 75) = {_Result}\n");
                WriteBox.Text += ResultWrite;
                sf.FileSave(ResultWrite);
            }
            
            
        }
    }
}
    