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

		private List<Equipement> _LesEquipements;
		public List<Equipement> LesEquipements{
				get { return this._LesEquipements;}
				set { this._LesEquipements=value;}
		}
		public Gladiateur(Equipe equipe, string nom)
		{
			this._Equipe = equipe;
			this._Nom = nom;
			this._LesEquipements = new List<Equipement>();
			this._NbVictoires = 0;
			this._NbDefaites = 0;
		}

		public void AjouterUnEquipement(Equipement equipementAjoute){
			
			int totalCout = 0;
			if (this.LesEquipements.Count<3 && this.LesEquipements!=null)
			{
				foreach (var equipement in this.LesEquipements)
				{
					totalCout = totalCout + equipement.Cout;
				}
				if (totalCout < 10)
				{
					this.LesEquipements.Add(equipementAjoute);
					Console.WriteLine("L'équipement " + equipementAjoute.Nom + " a été ajouté");
				}
				else {
					Console.WriteLine("Vous n'avez pas assez de points pour ajouter l'équipement " + equipementAjoute.Nom);
				}
			}
			else if (this.LesEquipements.Count == 3)
			{
				Console.WriteLine("Vous avez déjà trois equipements");

			}			
			else{
				this.LesEquipements.Add(equipementAjoute);
				Console.WriteLine("L'équipement " + equipementAjoute.Nom + " a été ajouté");
			}
			
			
		}

		}

				

	
}
