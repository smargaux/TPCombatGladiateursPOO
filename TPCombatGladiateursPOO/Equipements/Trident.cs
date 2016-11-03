using System;
using TPCombatGladiateursPOO.Equipements.Comportements;
namespace TPCombatGladiateursPOO.Equipements
{
	public class Trident :Equipement
	{
		public Trident()
		{
			this.ComportementAttaque = new Attaque();
			this.ComportementDefense = new SeDefendre();
			this.ChanceAttaque = 40;
			this.ChanceDefense = 10;
			this.Cout = 7;
		}
	}
}
