using System;
using System.Collections.Generic;

namespace TPCombatGladiateursPOO
{
	public class Gladiateur
	{
		private Equipe _Equipe;
		public Equipe Equipe{
			get { return this._Equipe;}
		}

		private string _Nom;
		public string Nom{
			get { return this._Nom;}
		}

		private int _Etat;
		public int Etat{
			get { return this._Etat;}
			set { this._Etat = value; }
		}

		private int _NbVictoires;
		public int NbVictoires{
				get {return this._NbVictoires;}
				set { this._NbVictoires = value; }
		}

		private int _NbDefaites;
		public int NbDefaites{
			get { return this.NbDefaites;}
			set { this._NbVictoires = value; }
		}

		private List<Equipement> _LesEquipements = new List<Equipement>();
		public List<Equipement> LesEquipements{
				get { return this._LesEquipements;}
		}
		public Gladiateur(Equipe equipe, string nom, List<Equipement> equipements)
		{
			this._Equipe = equipe;
			this._Nom = nom;
			this._LesEquipements = equipements;
			this._NbVictoires = 0;
			this._NbDefaites = 0;
		}
	}
}
