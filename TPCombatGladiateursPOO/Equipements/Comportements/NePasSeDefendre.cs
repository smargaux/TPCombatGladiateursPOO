using System;
using TPCombatGladiateursPOO.Equipements.Comportements.Interfaces;

namespace TPCombatGladiateursPOO.Equipements.Comportements
{
	public class NePasSeDefendre :ComportementDefense
	{
		public NePasSeDefendre()
		{
		}
		public bool Riposter(){
			return false;
		}
	}
}
