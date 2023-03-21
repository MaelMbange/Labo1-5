using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using LbFormes;

namespace Labo3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Forme> formes;
        public MainWindow()
        {
            InitializeComponent();

            formes =  new ObservableCollection<Forme>();
            this.DataContext = formes;

            ListView.ItemsSource = formes;
            Cercle.IsChecked = true;
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            if(CoX.Content.ToString() == string.Empty || CoY.Content.ToString() == string.Empty)
                MessageBox.Show("Il manque une Coordonnée");
            else if(Cercle.IsChecked == true)
            {
                if(Entree1.Text != string.Empty)
                    formes.Add(new Cercle(int.Parse(Entree1.Text),int.Parse(EntreeX.Text),int.Parse(EntreeY.Text)));
                else MessageBox.Show("Veuillez encoder le Rayon du cercle");
            }
            else if(Carre.IsChecked == true)
            {
                if(Entree1.Text != string.Empty)
                    formes.Add(new Carre(int.Parse(Entree1.Text),int.Parse(EntreeX.Text),int.Parse(EntreeY.Text)));
                else MessageBox.Show("Veuillez encoder la longueur du cote du carre");
            }
            else if(Rectangle.IsChecked == true)
            {
                if(Entree1.Text != string.Empty && Entree2.Text != string.Empty)
                    formes.Add(new LbFormes.Rectangle(int.Parse(Entree1.Text),int.Parse(Entree2.Text),int.Parse(EntreeX.Text),int.Parse(EntreeY.Text)));
                else MessageBox.Show("Veuillez encoder toute les valeurs du rectangle (longueur et largeur)");
            }

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((RadioButton)sender == Cercle)
            {
                Rayon.Visibility = Visibility.Visible;
            }
            else if ((RadioButton)sender == Carre)
            {
                Longueur.Visibility= Visibility.Visible;
            }
            else if((RadioButton)sender == Rectangle)
            {
                Largeur.Visibility= Visibility.Visible;
                Longueur.Visibility = Visibility.Visible;
                BorderLargeur.Visibility= Visibility.Visible;
                Entree2.Visibility= Visibility.Visible;
            }
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            if ((RadioButton)sender == Cercle)
            {
                Rayon.Visibility = Visibility.Collapsed;
            }
            else if ((RadioButton)sender == Carre)
            {
                Longueur.Visibility= Visibility.Collapsed;
            }
            else if((RadioButton)sender == Rectangle)
            {
                Largeur.Visibility= Visibility.Collapsed;
                Entree2.Visibility= Visibility.Collapsed;
                Longueur.Visibility = Visibility.Collapsed;
                BorderLargeur.Visibility= Visibility.Collapsed;
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListView.HasItems == true)
                MessageBox.Show(ListView.SelectedItem.ToString(), "PopBox");
            else
                MessageBox.Show("Liste Vide", "PopBox");
        }
    }
}
