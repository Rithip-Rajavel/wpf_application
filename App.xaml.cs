using System.Configuration;
using System.Data;
using System.Windows;

namespace Wpf_application;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e){
        MessageBox.Show("An unahndled Exception occurred "+e.Exception.Message,"Exception",MessageBoxButton.OK,MessageBoxImage.Error);
        e.Handled = true;
    }
}

