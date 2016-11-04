using System;
using TPCombatGladiateursPOO.Equipements.Comportements;
namespace TPCombatGladiateursPOO.Equipements
{
	public class Lance :Equipement
	{
		public Lance()
		{
			this.ComportementAttaque = new Attaque();
			this.ComportementDefense = new NePasSeDefendre();
			this.ChanceAttaque = 50;
			this.ChanceDefense = 0;
			this.Cout = 7;
			this.Nom = "Nom";

		}
	}
}
