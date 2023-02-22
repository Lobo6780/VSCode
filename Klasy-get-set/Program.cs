using System;

namespace Klasy
{
    class Student1
    {
        public int numer;
        public string imie;
    }
    class Student2
    {
        int numer;
        string imie;
    
        public int GetNumer()
        {
            return numer;
        }
        public void setNumer(int numer)
        {
            this.numer=numer;
        }
        public string GetImie()
        {
            return imie;
        }
        public void setImie(string imie)
        {
            this.imie = imie;
        }
    }
    class Student3
    {
        int numer;
        string imie;
        int wiek;

        public int Numer {
            get
            {
                return numer;
            } 
            set
            {
                numer = value;
            }
        }
        public string Imie {get => imie; set => imie = value;}
    }
    class Student4
    {
        public int Numer {get; set;}
        public string Imie {get; set;}
    }

    class Animal
    {
        public string Name { get; set; }
        public bool Domestic { get; set; }

        public virtual void Introduce()
        {
            System.Console.WriteLine("Hau hau");
        }
    }
    class Pies:Animal
    {
        public override void Introduce()
        {
            base.Introduce();
            System.Console.WriteLine(Name + " - Hau od Psa");
        }
    }
    class Wilk:Animal
    {
        public override void Introduce()
        {
            System.Console.WriteLine(Name + " - Hau od Wilka");
        }
    }

    class Firma
    {
        private string nip;
        public string NIP
        {
            get
            {
                return nip + " - to nip firmy";
            }
        }
        public Firma(string nip)
        {
            this.nip = nip;
        }
    }
    class Polska:Firma
    {
        public override string NIP
        {
            get
            {
                return "PL" + base.NIP;
            }
        }
        public Polska(string nip) : base(nip)
        {
        }
    }
    class Program
    {
        static void Main()
        {
            Student1 s1 = new Student1();
            s1.numer = 4;
            s1.imie = "BOGDAN";

            Student2 s2 = new Student2();
            s2.setNumer(5);
            s2.setImie("Jerzy");
            System.Console.WriteLine(s2.GetNumer() + " " + s2.GetImie());
            
            Student3 s3 = new Student3();
            s3.Numer = 7;
            s3.Imie = "Marek";
            System.Console.WriteLine(s3.Numer + " " + s3.Imie);

            Student4 s4 = new Student4();
            s4.Numer = 14;
            s4.Imie = "Andrzej";
            System.Console.WriteLine(s4.Numer + " " + s4.Imie);

            Pies p = new Pies();
            p.Name = "Burek";
            p.Introduce();

            Wilk w = new Wilk();
            w.Name = "Buras";
            w.Introduce();
        }
    }
}
