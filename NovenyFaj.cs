using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UveghazProjekt
{
	internal class NovenyFaj
	{
		string nev;
		int nedvessegtartalom;
		int egeszsegszint;
		int optimalissuruseg;

		public NovenyFaj(string nev, int optimalissuruseg) 
		{ 
			this.nev = nev;
			this.optimalissuruseg = optimalissuruseg;
			this.nedvessegtartalom = 100;
			this.egeszsegszint = 100;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Nedvessegtartalom { get => nedvessegtartalom; set => nedvessegtartalom = value; }
		public int Egeszsegszint { get => egeszsegszint; set => egeszsegszint = value; }
		public int Optimalissuruseg { get => optimalissuruseg; set => optimalissuruseg = value; }

		public string Azonosito 
		{ 
			get
			{
				return this.nev.Substring(0, 3);
			}
		}

		public override string ToString()
		{
			return $"{this.nev} nedvesseg: {this.nedvessegtartalom} egészség: {this.egeszsegszint} ideális egyedszam: {this.optimalissuruseg}";
		}
	}
}
