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

namespace KOK_Security_Manager.UserControls
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindowLeftMenuButton.xaml
    /// </summary>
    public partial class MainWindowLeftMenuButton : UserControl
    {
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(MainWindowLeftMenuButton));
        public static readonly DependencyProperty PhotoPathProperty =
            DependencyProperty.Register("PhotoPath", typeof(ImageSourceConverter), typeof(MainWindowLeftMenuButton), new UIPropertyMetadata(null));


        public string Text
        {
            get { return this.GetValue(TextProperty) as string; }
            set { this.SetValue(TextProperty, value); }
        }

        public ImageSource PhotoPath
        {
            get { return this.GetValue(PhotoPathProperty) as ImageSource; }
            set { this.SetValue(PhotoPathProperty, value); }
        }

        public MainWindowLeftMenuButton()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
