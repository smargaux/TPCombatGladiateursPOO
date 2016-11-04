using System;
using System.Collections.Generic;
using TPCombatGladiateursPOO;
using TPCombatGladiateursPOO.Equipements;
namespace TPCombatGladiateursPOO
{
	public class MainClass
	{
		public static void Main(string[] args)
		{

			Joueur joueur1 = new Joueur("Smits", "Margaux", "smargaux");
			Equipe equipe1 = joueur1.CreerUneEquipe("Equipe1","Premiere équipe");
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
			Gladiateur gladiateur1=equipe1.CreerUnGladiateur("Glad1");
			gladiateur1.AjouterUnEquipement(dague);
				

			
}


		
	}
}
