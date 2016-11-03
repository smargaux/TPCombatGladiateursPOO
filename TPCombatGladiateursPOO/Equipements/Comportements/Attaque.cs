using System;
using TPCombatGladiateursPOO.Equipements.Comportements.Interfaces;
namespace TPCombatGladiateursPOO.Equipements.Comportements
{
	public class Attaque :ComportementAttaque
	{
		public Attaque()
		{
		}
		
		public bool Attaquer(){
			return  true;
		}
	}
}
