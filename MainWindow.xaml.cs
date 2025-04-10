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
}