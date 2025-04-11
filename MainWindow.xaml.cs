using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;  
using System.Threading;

namespace Wpf_application;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Button_Click(Object sender, RoutedEventArgs e)
    {
        string text = null;
        // try
        // {
        //     text.Trim();
        // }
        // catch(Exception ex){
        //     MessageBox.Show("A handled exception just occurred "+ ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Warning);
        // }
        // text.Trim();
    }
    private void CultureInfoSwitchButton_Click(object sender, RoutedEventArgs e){
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo((sender as Button).Tag.ToString());
        lblNumber.Content = (123456789.42d).ToString("N2");
        lblDate.Content = DateTime.Now.ToString();

    }
}