using System.Windows;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Threading;
using WPFCustomMessageBox;
using System.Diagnostics;

namespace BloatFish
{
    public partial class MainWindow : Window
    {
        //Powershell script to check existence of apps from list

        private static string checkAppsScript = @"$appList = @('*BingNews*','*BingWeather*','*OneNote*','*WindowsAlarms*', 
                                                               '*Recorder*', '*Maps*','*Camera*', '*Microsoft.People*',
                                                               '*xboxapp*', 'ZuneMusic*','*Messaging*', '*Builder*', 
                                                               '*BubbleWitch*', '*Minecraft*', '*Spotify*',
                                                               '*Empires*', '*StickyNotes*', '*Skype*', '*SolitaireCollection*')


                                                ForEach($app in $appList)
                                                {
                                                  Get-AppxPackage | Select Name | Where-Object {$_.Name -like $app}
                                                }";

        //Powershell script to remove all apps from list

        private static string removeAllScript = @"$appList = @('*BingNews*','*BingWeather*','*OneNote*','*WindowsAlarms*', 
                                                               '*Recorder*', '*Maps*','*Camera*', '*People*','*Microsoft.People*', 
                                                               '*xboxapp*', '*ZuneMusic*','*Messaging*', '*Builder*', 
                                                               '*BubbleWitch*', '*Minecraft*', '*Spotify*',
                                                               '*Empires*', '*StickyNotes*', '*Skype*', '*SolitaireCollection*')

                                                ForEach($app in $appList)
                                                {
                                                  Get-AppxPackage | Select Name | Where-Object{$_.Name -like $app} | Remove-AppxPackage -ErrorAction SilentlyContinue
                                                }";

        public MainWindow()
        {
            InitializeComponent();           
        }

        private void ImageBtn_Click(object sender, RoutedEventArgs e)
        {
            Button imgBtn = sender as Button;
            string appToCheck = GetSubString(imgBtn.Name);            

            switch(appToCheck)
            {
                case "bingweather":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "bingnews":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "onenote":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "windowsalarms":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "voicerecorder":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "windowsmaps":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "windowscamera":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "people":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "xboxapp":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "zunemusic":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "messaging":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "builder":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "bubblewitch":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "minecraft":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "spotify":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "empires":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "solitairecollection":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "stickynotes":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
                case "skypeapp":
                    if (AppNotExists(appToCheck))
                    {
                        CustomMessageBox.Show(char.ToUpper(appToCheck[0]) + appToCheck.Substring(1) + " is not installed so cannot be removed");
                    }
                    else
                    {
                        RemoveSelectedApp(appToCheck);
                    }
                    break;
            }
        }

        //used for formatting strings in MessageBoxes
        private string GetSubString(string buttonName)
        {
            int index = buttonName.IndexOf('B');
            return buttonName.Substring(0, index);
        }

        private void RemoveAllBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if (PSObjectCount() == 0)
            {
                CustomMessageBox.Show("You have already removed all the apps listed.", "No Apps Found", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                PowerShell removePS = PowerShell.Create();
                if (CustomMessageBox.ShowYesNo("You are about to remove ALL apps from your system.\n\n\t\tContinue?",
                                              "WARNING",
                                              "Yes, I'm sure.",
                                              "NO!", MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    //DO NOTHING
                }
                else
                {
                    removePS.AddScript(removeAllScript);

                    _busyIndicator.BusyContent = "Removing all apps...";
                    _busyIndicator.IsBusy = true;

                    removePS.BeginInvoke<PSObject>(null, new PSInvocationSettings(), ar =>
                    {
                        try
                        {
                            //Just to show work being done
                            //It goes too fast to give the message to the user
                            Thread.Sleep(2000);
                            var removeAllVar = removePS.EndInvoke(ar);
                            this.Dispatcher.Invoke(() => _busyIndicator.IsBusy = false);
                            MessageBox.Show("All apps removed successfully.\n\nYou can visit the App Store to reinstall the apps.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        finally
                        {
                            removePS.Dispose();
                        }
                    }, null);
                }
            }

        }

        private int PSObjectCount()
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(checkAppsScript);
            Collection<PSObject> psOutput = ps.Invoke();
            ps.Dispose();

            return psOutput.Count;
        }
        private bool AppNotExists(string str)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript("Get-AppxPackage | Select Name | Where-Object { $_.Name -like '*" + str + "*'}");
            Collection<PSObject> psOutput = ps.Invoke();

            //Get rid of PS instance
            ps.Dispose();

            return psOutput.Count == 0;           
        }

        private void RemoveSelectedApp(string str)
        {
            string capitalizedStr = (char.ToUpper(str[0]) + str.Substring(1));

            PowerShell ps = PowerShell.Create();
            if(CustomMessageBox.ShowYesNo("You are about to remove " + capitalizedStr + " from your system.\n\n\t\tContinue?",
                                             "WARNING",
                                             "Yes. I got this.",
                                             "NO!", MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                //DO NOTHING
            }
            else
            {
                //Create PS Script
                ps.AddScript("Get-AppxPackage | Where-Object {$_.Name -like '*" + str.ToLower() + "*'} | Remove-AppxPackage");
                
                //Show BusyIndicator
                _busyIndicator.BusyContent = "Removing " + capitalizedStr;
                _busyIndicator.IsBusy = true;

                //Invoke Async PS
                ps.BeginInvoke<PSObject>(null, new PSInvocationSettings(), ar =>
                {
                    try
                    {
                        //Just a little extra time to show work for user
                        Thread.Sleep(2000);
                        var removeVar = ps.EndInvoke(ar);
                        this.Dispatcher.Invoke(() => _busyIndicator.IsBusy = false);
                        MessageBox.Show(capitalizedStr + " removed successfully\n\nYou can visit the App Store to reinstall the app.", "Success");
                    }
                    finally
                    {
                        //Throw away PS instance
                        ps.Dispose();
                    }
                }, null);
            }
        }
       /*
        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
        */
        private void storeLaunchBtn_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("ms-windows-store:home");
        }
    }
}









