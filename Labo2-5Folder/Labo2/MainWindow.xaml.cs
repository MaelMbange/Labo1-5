namespace Labo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        public MainWindow()
        {
            InitializeComponent();
            Historique.Visibility = System.Windows.Visibility.Hidden; 
        }

        private void B0_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void Grid_SizeChanged(object sender, System.Windows.SizeChangedEventArgs e)
        {
           if (e.NewSize.Width < 400)
            {
                Historique.Visibility = System.Windows.Visibility.Hidden;                
                GrilleSecondaire.Width = e.NewSize.Width;
            }
            else
            {
                Historique.Visibility = System.Windows.Visibility.Visible;
                GrilleSecondaire.Width = 300;
            }
        }
                
    }
}