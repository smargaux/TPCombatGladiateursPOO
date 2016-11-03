using System;
using System.Collections.Generic;
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

		private List<Gladiateur> LesGladiateurs = new List<Gladiateur>();
		
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
		public Equipe(Joueur joueur, string nom, string description )
		{
			this._JoueurProprietaire = joueur;
			this._Nom = nom;
			this._Description = Description;
			this._NBMatchsJoues = 0;
			this._NBMatchsGagnes = 0;
			this._NBMatchsPerdus = 0;
			this._PourcentageVictoire = 0;
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
		
		public string CreerUnGladiateur(string nomGladiateur, List<Equipement> equipement){

			// On vérifie si le joueur peut créer une équipe
			if (PeutAjouterUnGladiateur())
			{
				//On vérifie qu'il n'a pas plus de dix points d'équipements
				
				
				Gladiateur nouveauGladiateur = new Gladiateur(this, nomGladiateur, equipement);
				LesGladiateurs.Add(nouveauGladiateur);
				return "Bravo " + this.JoueurProprietaire.Alias + " votre nouvelle équipe " + this.Nom + " contient un nouveau Gladiateur "+nomGladiateur+" !";
			}
			else{
				return "Désolé " + this.JoueurProprietaire.Alias + " vous ne pouvez plus créer de gladiateurs !";
			}
			
		}
		
		public bool EquipementsEstValide(List<Equipement> Equipements){

			int totalCout = 0;
			foreach (var equipement in Equipements)
			{
				totalCout = totalCout + equipement.Cout;
			}
			
			if(totalCout<10){
				return false;
			}
			else{
				return true;
			}
		}
		
	}
}
