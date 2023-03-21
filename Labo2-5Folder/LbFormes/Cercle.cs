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
    public class Cercle : Forme,IEstDans, INotifyPropertyChanged
    {
        private float _rayon;

        public event PropertyChangedEventHandler? PropertyChanged;

        public float Rayon { get => _rayon; set{ _rayon = value; NotifyPropertyChanged(); } }

        public Cercle() : this(0,0,0){}
        public Cercle(float rayon, int x, int y) => (_rayon, _coordonnees.X, _coordonnees.Y) = (rayon, x, y);

    
        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString() => nameof(Cercle) + " " + _coordonnees.X + " : " + _coordonnees.Y + " | ray = " + _rayon;
        public bool CoordonneeEstDans(Coordonnees p)
        {
            double distanceAuCentre = Math.Sqrt(Math.Pow(p.X - _coordonnees.X, 2) + Math.Pow(p.Y - _coordonnees.Y, 2));
            return distanceAuCentre <= _rayon;
        }

        public void NotifyPropertyChanged([CallerMemberName] string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
