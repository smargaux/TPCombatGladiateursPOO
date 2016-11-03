using System;
using TPCombatGladiateursPOO.Equipements.Comportements;
namespace TPCombatGladiateursPOO.Equipements
{
	public class Epee :Equipement
	{
		public Epee()
		{
			this.ComportementAttaque = new Attaque();
			this.ComportementDefense = new NePasSeDefendre();
			this.ChanceAttaque = 70;
			this.ChanceDefense = 0;
			this.Cout = 5;
		}
	}
}
