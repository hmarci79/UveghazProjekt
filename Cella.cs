using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UveghazProjekt
{
	internal class Cella
	{
		Pozicio pozicio;
		NovenyFaj novenyFaj;
		int egyedszam;
		List<Szenzor> szenzorok;
		List<Riasztas> riasztasok;

		public Cella(int x, int y)
		{
			this.pozicio = new Pozicio(x, y);
			this.novenyFaj = null;
			this.egyedszam = 0;
			this.szenzorok = new List<Szenzor>();
			this.riasztasok = new List<Riasztas>();
		}

		public int Egyedszam { get => egyedszam; set => egyedszam = value; }
		internal Pozicio Pozicio1 { get => pozicio; set => pozicio = value; }
		internal NovenyFaj NovenyFaj { get => novenyFaj; set => novenyFaj = value; }
		internal List<Szenzor> Szenzorok { get => szenzorok; set => szenzorok = value; }
		internal List<Riasztas> Riasztasok { get => riasztasok; set => riasztasok = value; }
		public bool Urese
		{
			get
			{
				return this.novenyFaj == null;	
			}
		}

		public bool Telepit(NovenyFaj noveny, int mennyiseg)
		{
			bool sikeres = false;
			if (mennyiseg > 0 && !Urese)
			{
				this.novenyFaj = noveny;
				this.egyedszam += mennyiseg;
				Console.WriteLine($"{novenyFaj.Nev} telepítése sikeresen megtörtént.");
				sikeres = true;
			}
			else if (mennyiseg > 0 && this.novenyFaj.Equals(noveny))
			{
				Noveles(mennyiseg);
			}
				return sikeres;
		}

		public void Noveles(int mennyiseg)
		{
			this.egyedszam += mennyiseg;
		}

		public void Csokkentes(int mennyiseg)
		{
			this.egyedszam -= mennyiseg;
			if (egyedszam <= 0)
			{
				Urites();
			}
		}

		public void Urites()
		{
			this.novenyFaj = null;
			this.egyedszam = 0;
		}

		public override string ToString()
		{
			if (this.Urese)
			{
				return ($"| {"üres",8} |");
			}
			return $"| {this.novenyFaj.Azonosito,3} {this.egyedszam,2}db |";
		}
	}
}
