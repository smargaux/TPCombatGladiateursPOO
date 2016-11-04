using System;
using TPCombatGladiateursPOO.Equipements.Comportements;

namespace TPCombatGladiateursPOO
{
	public class Casque :Equipement
	{
		public Casque()
		{
			this.ComportementAttaque = new NePasAttaquer();
			this.ComportementDefense = new SeDefendre();
			this.ChanceAttaque = 0;
			this.ChanceDefense = 10;
			this.Cout = 2;
			this.Nom = "Casque";
		}
	}
}
