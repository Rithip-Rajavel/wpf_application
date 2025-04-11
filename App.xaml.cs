
using System;
using System.Configuration;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Windows;
using System.Threading;

namespace Wpf_application;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private void ApplicationStartup(object sender, StartupEventArgs e){

        MainWindow main = new MainWindow();
        main.Show();
        Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

        
    }
    private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e){
        MessageBox.Show("An unahndled Exception occurred "+e.Exception.Message,"Exception",MessageBoxButton.OK,MessageBoxImage.Error);
        e.Handled = true;
    }
}

