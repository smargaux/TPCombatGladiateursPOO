using System;
using TPCombatGladiateursPOO.Equipements.Comportements.Interfaces;
namespace TPCombatGladiateursPOO.Equipements.Comportements
{
	public class SeDefendre :ComportementDefense
	{
		public SeDefendre()
		{
		}
		
		public bool Riposter(){
			return true;
		}
	}
}
