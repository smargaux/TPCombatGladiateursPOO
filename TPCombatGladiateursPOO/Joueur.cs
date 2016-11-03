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
		private List<Equipe> _LesEquipes = new List<Equipe>();
		
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
		}
		
		
		public string sePresenter(){

			return this.Nom+this.Prenom+this.Alias+this.DateInscription.ToString();
		}
		
		public string CreerUneEquipe(string nomEquipe, string descriptionEquipe){

			// On vérifie si le joueur peut créer une équipe
			if (PeutCreerUneEquipe())
			{
				Equipe nouvelleEquipe = new Equipe(this, nomEquipe, descriptionEquipe);
				LesEquipes.Add(nouvelleEquipe);
				return "Bravo " + this.Alias + " votre nouvelle équipe " + nomEquipe + " a été créée !";
			}
			else{
				return "Désolé " + this.Alias + " vous ne pouvez plus créer d'équipe !";
			}
			
		}
		
		public Boolean PeutCreerUneEquipe(){
		
			int nbEquipes=this.LesEquipes.Count;
			if (nbEquipes < 5)
			{
				return true;
			}
			else {
				return false;
			}
		}
		
		
		public Equipe getEquipe(string nomEquipe){
			Contract.Ensures(Contract.Result<Equipe>() != null);
			Equipe equipeDemande;
			foreach (var equipe in this.LesEquipes)
			{
				if (equipe.Nom.Equals(nomEquipe))
					 equipeDemande = equipe;
			}
			return equipeDemande;
		}
		
	}
}
