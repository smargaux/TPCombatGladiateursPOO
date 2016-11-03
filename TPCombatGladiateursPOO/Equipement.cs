using System;
using TPCombatGladiateursPOO.Equipements.Comportements.Interfaces;
namespace TPCombatGladiateursPOO
{
	public class Equipement
	{

		private string _Nom;
		public string Nom
		{
			get { return this._Nom; }
		}

		private int _Cout;
		public int Cout
		{
			get { return this._Cout; }
			set { this._Cout = value; }
		}

		private ComportementAttaque _ComportementAttaque;
		public ComportementAttaque ComportementAttaque{get;set;}
		
		private ComportementDefense _ComportementDefense;
		public ComportementDefense ComportementDefense{get;set;}


		private int _ChanceAttaque;
		public int ChanceAttaque{
			get { return this._ChanceAttaque; }
			set { this._ChanceAttaque = value; }
			
		}
		
		private int _ChanceDefense;
		public int ChanceDefense{
			get { return this._ChanceDefense; }
			set { this._ChanceDefense = value; }
			
		}
		
	
		public Equipement()
		{
		}

		public bool Attaquer()
		{
			return this.ComportementAttaque.Attaquer();
		}
		public bool Riposter()
		{
			return this.ComportementDefense.Riposter();
		}
	}
}
