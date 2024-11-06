using System.Windows;
using ShortestRouteFinder.ViewModel;

namespace ShortestRouteFinder.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Sätt ViewModel som DataContext för fönstret
            DataContext = new MainViewModel();
        }
    }
}
