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

namespace KOK_Security_Manager.Views
{
    /// <summary>
    /// Logika interakcji dla klasy EmployeesTabControlFrame.xaml
    /// </summary>
    public partial class EmployeesTabControlFrame : Page
    {
        public EmployeesTabControlFrame()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame frame = new Frame();
            TabItem item = new TabItem();
            item.Header = "Emp Name";
            item.Content = frame;
            frame.Navigate(new Views.AddEmployeeFrame());

            EmployeesTabControl.Items.Add(item);
            
        }
    }
}
