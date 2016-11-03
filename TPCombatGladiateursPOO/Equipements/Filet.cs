using System;
using TPCombatGladiateursPOO.Equipements.Comportements;
namespace TPCombatGladiateursPOO.Equipements
{
	public class Filet :Equipement
	{
		public Filet()
		{
			this.ComportementAttaque = new Attaque();
			this.ComportementDefense = new NePasSeDefendre();
			this.ChanceAttaque = 30;
			this.ChanceDefense = 0;
			this.Cout = 3;
		}
	}
}
