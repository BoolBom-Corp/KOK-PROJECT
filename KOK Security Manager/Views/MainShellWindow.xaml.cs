using KOK_Security_Manager.Views;
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
using System.Windows.Shapes;

namespace KOK_Security_Manager.View
{
    /// <summary>
    /// Logika interakcji dla klasy MainShellWindow.xaml
    /// </summary>
    public partial class MainShellWindow : Window
    {
        int frameIndex;
        public MainShellWindow()
        {
            InitializeComponent();
        }

        private void MainWindowLeftMenuButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UserControl button = sender as UserControl;
            if (button.Uid == "2" && frameIndex != 2)
            {
                MainFrame.Navigate(new EmployeesTabControlFrame());
                frameIndex = 2;
            }

        }

    }
}
