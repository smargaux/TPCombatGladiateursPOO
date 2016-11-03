using System;
using TPCombatGladiateursPOO.Equipements.Comportements;
namespace TPCombatGladiateursPOO
{
	public class BouclierRectangulaire :Equipement
	{
		public BouclierRectangulaire()
		{
			
			this.ComportementAttaque = new NePasAttaquer();
			this.ComportementDefense = new SeDefendre();
			this.ChanceAttaque = 0;
			this.ChanceDefense = 30;
			this.Cout = 8;
		}
	}
}
