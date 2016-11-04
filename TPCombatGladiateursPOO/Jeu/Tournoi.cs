	using System;
	using System.Linq;
	using TPCombatGladiateursPOO;
	using TPCombatGladiateursPOO.Jeu;

	using System.Collections.Generic;
	
	namespace TPCombatGladiateursPOO.Jeu
	{
		public class Tournoi
		{
	
			List<Joueur> Joueurs;
			public Tournoi(List<Joueur> joueurs)
			{
				this.Joueurs = joueurs;
			}
			
			
			public List<Equipe> ToutesLesEquipesDesJoueurs()
			{
				// On récupère les equipes de chacun des joueurs inscrits au tournoi
				List<Equipe> Equipes = new List<Equipe>();
				
				
				
				foreach (var joueur in this.Joueurs)
				{
					foreach (var equipe in joueur.LesEquipes)
					{
						Equipes.Add(equipe);
	
					}
				}
				
				//On trie les équipes par leur Pourcentage de victoires
				Equipes = (from equipe in Equipes
			      						orderby equipe.PourcentageVictoire
			      						select equipe).ToList();
	
				return Equipes;
				
			}
			
			public List<Combat> GenererCombats(){
	
				//On récupère la liste des Equipes triées par leurs pourcentage de victoires
				List<Equipe> LesEquipes = ToutesLesEquipesDesJoueurs();
				List<Combat> LesCombats = new List<Combat>();
				
				//Pour chaque équipe de la liste on cherche la prochaine equipe qui appartient à un autre joueur pour générer les combats
				for (int i = 0; i <LesEquipes.Count-1 ; i++)
				{
					int j = i + 1;
					while(LesEquipes[i].JoueurProprietaire.Equals(LesEquipes[j].JoueurProprietaire)){
						j++;
					}
					Combat nouveauCombat = new Combat(LesEquipes[i], LesEquipes[j]);
					Console.WriteLine("Générer un combat entre l'équipe " + LesEquipes[i].Nom + " de " + LesEquipes[i].JoueurProprietaire.Nom + " et " + LesEquipes[j].Nom + " de " + LesEquipes[j].JoueurProprietaire.Nom);
					i = j;
						
				}
			Console.WriteLine("Le tournoi commence, les combats suivants vont avoir lieu:\n");
			foreach (var combat in LesCombats)
			{
				Console.WriteLine(Combat.Equipe1.Nom + " contre " + Combat.Equipe2.Nom);
			}
			}
	
		}
	}
