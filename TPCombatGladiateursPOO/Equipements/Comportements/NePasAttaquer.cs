using System;
using TPCombatGladiateursPOO.Equipements.Comportements.Interfaces;
namespace TPCombatGladiateursPOO.Equipements.Comportements
{
	public class NePasAttaquer :ComportementAttaque
	{
		public NePasAttaquer()
		{
		}
		
		public bool Attaquer(){
			return false;
		}
	}
}
