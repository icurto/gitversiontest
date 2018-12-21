using System.Reflection;
using System.Windows;

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Version.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
        }
    }
}
