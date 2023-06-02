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
using ProgramLib;
using WpfAppCone.ViewModel;

namespace WpfAppCone
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double height = Convert.ToDouble(TextBox_Height.Text);
            double bigRadius = Convert.ToDouble(TextBox_BigRadius.Text);
            double smallRadius = Convert.ToDouble(TextBox_SmallRadius.Text);
            Label_Result.Content = LibraryViewModel.CalcLibrary(height, bigRadius, smallRadius);
        }
    }
}
