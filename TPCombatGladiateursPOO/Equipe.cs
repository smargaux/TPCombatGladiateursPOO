using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using TPCombatGladiateursPOO.Equipements;

namespace TPCombatGladiateursPOO
{
	public class Equipe 
	{
		private Joueur _JoueurProprietaire;
		private string _Nom;
		private string _Description;
		private int _NBMatchsJoues;
		private int _NBMatchsGagnes;
		private int _NBMatchsPerdus;
		private int _PourcentageVictoire;

		private List<Gladiateur> _LesGladiateurs ;
		public List<Gladiateur> LesGladiateurs{
				get { return this._LesGladiateurs;}
				set { this._LesGladiateurs = value; }
		}
		public Joueur JoueurProprietaire{
			get { return this._JoueurProprietaire;}

		}
		
		public string Nom{
			get { return this._Nom;}
		}
		public string Description{
			get { return this._Description;}
		}
		public int NBMatchsJoues{
			get { return this._NBMatchsJoues;}
		}
		public int NBMatchsGagnes{
			get { return this._NBMatchsGagnes;}
		}
		public int NBMatchsPerdus{
			get { return this._NBMatchsPerdus;}
		}
		public int PourcentageVictoire{
			get { return this._PourcentageVictoire;}
		}
		
		//Constructeur
		public Equipe(){
		}
		public Equipe(Joueur joueur, string nom, string description )
		{
			this._JoueurProprietaire = joueur;
			this._Nom = nom;
			this._Description = Description;
			this._NBMatchsJoues = 0;
			this._NBMatchsGagnes = 0;
			this._NBMatchsPerdus = 0;
			this._PourcentageVictoire = 0;
			LesGladiateurs = new List<Gladiateur>();
		}

	
		
		public bool PeutAjouterUnGladiateur(){
			int nbGladiateurs=this.LesGladiateurs.Count;
			if (nbGladiateurs < 3)
			{
				return true;
			}
			else {
				return false;
			}
		}
		
		public bool EquipementsEstValide(List<Equipement> equipements){

			int totalCout = 0;
			foreach (var equipement in equipements)
			{
				totalCout = totalCout + equipement.Cout;
			}
			Console.WriteLine("Cout equipement: " + totalCout);
			if(totalCout<10){
				return true;
			}
			else{
				return false;
			}
		}
		
		public Gladiateur CreerUnGladiateur(string nomGladiateur){

			// On vérifie si le joueur peut créer un Gladiateur
			if (PeutAjouterUnGladiateur())
			{
				//On vérifie qu'il n'a pas plus de dix points d'équipements
					Gladiateur nouveauGladiateur = new Gladiateur(this, nomGladiateur);
					LesGladiateurs.Add(nouveauGladiateur);
					return nouveauGladiateur;
				
			}
			else{
				return null;
			}
			
		}
		
		
		
	}
}
