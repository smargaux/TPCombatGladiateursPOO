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
			set { this._Nom = value; }

		}

		private int _Cout;
		public int Cout
		{
			get { return this._Cout; }
			set { this._Cout = value; }
		}

		private ComportementAttaque _ComportementAttaque;
		public ComportementAttaque ComportementAttaque { get { return this._ComportementAttaque; } set { this._ComportementAttaque = value; } }
		
		private ComportementDefense _ComportementDefense;
		public ComportementDefense ComportementDefense { get { return this._ComportementDefense; } set { this._ComportementDefense = value; } }


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
