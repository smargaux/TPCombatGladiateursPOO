using System;
using TPCombatGladiateursPOO.Equipements.Comportements;
namespace TPCombatGladiateursPOO.Equipements
{
	public class PetitBouclierRond:Equipement
	
	{
		public PetitBouclierRond()
		{
			this.ComportementAttaque = new NePasAttaquer();
			this.ComportementDefense = new SeDefendre();
			this.ChanceAttaque = 0;
			this.ChanceDefense = 20;
			this.Cout = 5;
		}
	}
}
