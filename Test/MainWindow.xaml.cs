using mdilib;
using System.ComponentModel;
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

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int id = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, RoutedEventArgs e)
        {
            string title = string.Format("Window {0} with a really long string for a title", id++.ToString());
            MdiContainer?.NewChildWindow(title);
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            MdiContainer?.CloseActiveChildWindow();
        }

        private void btn_CloseAll_Click(object sender, RoutedEventArgs e)
        {
            MdiContainer?.CloseAllChildWindows();
        }
    }
}