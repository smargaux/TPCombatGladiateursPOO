using System;
using System.Collections.Generic;
using TPCombatGladiateursPOO;
using TPCombatGladiateursPOO.Equipements;
using TPCombatGladiateursPOO.Jeu;

namespace TPCombatGladiateursPOO
{
	public class MainClass
	{
		public static void Main(string[] args)
		{

			Joueur joueur1 = new Joueur("Smits", "Margaux", "smargaux");
			Joueur joueur2= new Joueur("Dupont", "Georges", "dgeorges");
			Joueur joueur3= new Joueur("Dubois", "Lola", "dlola");
			Joueur joueur4= new Joueur("Fernand", "Marion", "marionf");

			Equipe equipe1 = joueur1.CreerUneEquipe("Equipe1","Premiere équipe");
			Equipe equipe2 = joueur2.CreerUneEquipe("Equipe2","Premiere équipe");
			Equipe equipe3 = joueur3.CreerUneEquipe("Equipe3","Premiere équipe");
			Equipe equipe4 = joueur4.CreerUneEquipe("Equipe4","Premiere équipe");

			List<Joueur> joueurs = new List<Joueur>();
			joueurs.Add(joueur1);
			joueurs.Add(joueur2);
			joueurs.Add(joueur3);
			joueurs.Add(joueur4);


			Tournoi monTournoi = new Tournoi(joueurs);
			monTournoi.GenererCombats();
			
			//Equipe equipe1 = new Equipe(joueur1, "Premiere equipe", "fezfezfezfezf");
			List<Equipement> equipement1 = new List<Equipement>();
			List<Equipement> equipement2 = new List<Equipement>();
			List<Equipement> equipement3 = new List<Equipement>();
			
			Equipement dague = new Dague();
			Equipement epee = new Epee();
			Equipement filet = new Filet();
			Equipement trident = new Trident();

			Equipement lance = new Lance();
			Equipement petitBouclier = new PetitBouclierRond();
			Equipement bouclierRect = new BouclierRectangulaire();

			equipement2.Add(bouclierRect);
			equipement2.Add(filet);
			equipement2.Add(lance);
			equipement1.Add(dague);
			equipement1.Add(epee);
			equipement1.Add(trident);
			Gladiateur gladiateur1=equipe1.CreerUnGladiateur("Glad1",1);
			gladiateur1.AjouterUnEquipement(dague);
				

			
}


		
	}
}
