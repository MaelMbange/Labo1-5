﻿namespace LbFormes
{
    public abstract class Forme
    {
        protected Coordonnees _coordonnees;
    
        public Coordonnees Coordonnees { get => _coordonnees;
            set => _coordonnees = value;
        }
        public Forme()
        {
            _coordonnees = new Coordonnees();
        }
        protected Forme(Coordonnees coordonnees)
        {
            _coordonnees = coordonnees;
        }
        protected Forme(int x, int y)
        {
            _coordonnees = new Coordonnees(x, y);
        }
        public abstract void Affiche();
    }
}