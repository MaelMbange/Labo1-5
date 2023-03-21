using LbFormes.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LbFormes
{
    
    public class Rectangle : Forme,ISommet,IEstDans,INotifyPropertyChanged
    {
        private float _largeur;
        private float _longueur;

        public event PropertyChangedEventHandler? PropertyChanged;

        public float Longueur { get => _longueur; set { _longueur = value; NotifyPropertyChanged();} }
        public float Largeur { get => _largeur; set { _largeur = value; NotifyPropertyChanged();} }


        public Rectangle() : this(0, 0, 0, 0){}
        public Rectangle(float largeur, float longueur, int x, int y) : base(x,y) => (Largeur,Longueur) = (largeur,longueur);
    
        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString() => nameof(Rectangle) + " " + _coordonnees.X + " : " + _coordonnees.Y + " | lenght = " + _longueur + " | width = "+ _largeur;


        public int NbSommet => 4;
        public bool CoordonneeEstDans(Coordonnees p)
        {
            if (_coordonnees.X <= p.X && p.X <= _coordonnees.X + _largeur)
                return _coordonnees.Y <= p.Y && p.Y <= _coordonnees.Y + _longueur;
            return false;
        }

        public void NotifyPropertyChanged([CallerMemberName]string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

    }
}
