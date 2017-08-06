using System.Windows;

namespace DluznikWPF
{
    /// <summary>
    /// Iteration logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new WindowViewModel(this);
        }
    }
}
