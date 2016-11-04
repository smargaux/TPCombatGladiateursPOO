using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace TPCombatGladiateursPOO
{
	public class Joueur
	{

		private string _Nom;
		public string Nom{
			get { return this._Nom;}
		}
		private string _Prenom;
		public string Prenom{
			get { return this._Prenom;}

		}
		private string _Alias;
		public string Alias{
			get { return this._Alias;}
		}
		private DateTime _DateInscription;
		public DateTime DateInscription{
			get { return this._DateInscription;}

		}

		private List<Equipe> _LesEquipes;
		
		public List<Equipe> LesEquipes{
					get { return this._LesEquipes;}
					set { this._LesEquipes = value; }
		}

		
		public Joueur(string nom, string prenom, string alias)
		{
			this._Nom = nom;
			this._Prenom = prenom;
			this._Alias = alias;
			this._DateInscription = DateTime.Now;
			LesEquipes = new List<Equipe>();
			
		}
		
		
		public string sePresenter(){

			return this.Nom+this.Prenom+this.Alias+this.DateInscription.ToString();
		}
		
		public Equipe CreerUneEquipe(string nomEquipe, string descriptionEquipe){

			// On vérifie si le joueur peut créer une équipe
			if (PeutCreerUneEquipe())
			{
				Equipe nouvelleEquipe = new Equipe(this, nomEquipe, descriptionEquipe);
				this.LesEquipes.Add(nouvelleEquipe);
				return nouvelleEquipe;
			}
			else{
				return null;
			}
			
		}
		
		public bool PeutCreerUneEquipe(){

			if (this.LesEquipes.Count < 5)
				return true;
			else 
				return false;
		}
		
		public Equipe RecupererEquipe(string nom){
			return this.LesEquipes.Find(equipe => equipe.Nom == nom);
		}
	
		
	}
}
