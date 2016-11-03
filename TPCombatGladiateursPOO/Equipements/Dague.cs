using System;
using TPCombatGladiateursPOO.Equipements.Comportements;
namespace TPCombatGladiateursPOO.Equipements
{
	public class Dague :Equipement
	{
		public Dague()
		{
			this.ComportementAttaque = new Attaque();
			this.ComportementDefense = new NePasSeDefendre();
			this.ChanceAttaque = 60;
			this.ChanceDefense = 0;
			this.Cout = 2;
		}
	}
}
