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

namespace DatabasesandDataMining
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RStudio_Click(object sender, RoutedEventArgs e)
        {
            RStudioProject RStudioProjectObject = new RStudioProject();
            RStudioProjectObject.Show();
        }

         private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DecisionTree DecisionTreeObject = new DecisionTree();
            DecisionTreeObject.Show();
        }

        private void GoldPrice_Click(object sender, RoutedEventArgs e)
        {
            TransformingData TransformingDataObject = new TransformingData();
            TransformingDataObject.Show();
        }

        private void Linear_Regression_Click(object sender, RoutedEventArgs e)
        {
            LinearRegression LinearRegressionObject = new LinearRegression();
            LinearRegressionObject.Show();
        }

        private void MultipleRegression_Click(object sender, RoutedEventArgs e)
        {
            MultipleRegression MultipleRegressionObject = new MultipleRegression();
            MultipleRegressionObject.Show();
        }
    }
}
