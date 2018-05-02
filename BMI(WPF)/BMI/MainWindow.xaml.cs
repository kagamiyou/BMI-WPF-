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

namespace BMI
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void heightBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void weightClear_Click(object sender, RoutedEventArgs e)
        {
            // 清除體重資料，方框變紅
                weightBox.Text = " ";
                weightBox.Background = Brushes.White;
            
        }

        private void heightClear_Click(object sender, RoutedEventArgs e)
        {
            // 清除身高資料，方框變紅
            heightBox.Text = " ";
            heightBox.Background = Brushes.White;
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            // 設變數
            double calculate = 0;
            
            // 排除輸入數字以外的結果
            try
            {
                double w = double.Parse(weightBox.Text);
                double h = double.Parse(heightBox.Text);
                calculate = w / (h * h);

            }

            // 要求數字
            catch
            {
                MessageBox.Show( " Please type  numbers " );
            }

            // 顯示結果
            Ans.Text = calculate.ToString("");

        }

        private void NM_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show( " 就說別點我 " );
        }

        private void Sliderheight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double calculate = 0;
            heightBox.Text = sliderheight.Value.ToString();
            double w = double.Parse(this.weightBox.Text);
            double h = double.Parse(this.heightBox.Text)/100;
            calculate = w / (h * h);
            Ans.Text = calculate.ToString();
        }

        private void Sliderweight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double calculate = 0;
            weightBox.Text = sliderweight.Value.ToString();
            double w = double.Parse(this.weightBox.Text);
            double h = double.Parse(this.heightBox.Text)/100;
            calculate = w / (h * h);
            Ans.Text = calculate.ToString();
        }
    }
}
