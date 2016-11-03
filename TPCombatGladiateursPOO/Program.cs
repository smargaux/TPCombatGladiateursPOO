using System;
using TPCombatGladiateursPOO.Equipements;
namespace TPCombatGladiateursPOO
{
	public class MainClass
	{
		public static void Main(string[] args)
		{

			Joueur joueur1 = new Joueur("Smits", "Margaux", "smargaux");
			Console.WriteLine(joueur1.sePresenter());
			
	
			
		}
	}
}
