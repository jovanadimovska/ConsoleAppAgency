using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        //Рим, Лондон, Токио, Софија, Истанбул, Торонто, Мајами, Загреб, Белград и Москва
        
        static List<string> destinacii = new List<string> { "Rim", "London", "Tokio", "Sofija", "Istanbul", "Toronto", "Majami", "Zagreb", "Belgrad", "Moskva" };
        static List<Shalter> shalteri = new List<Shalter>();
        static Shalter s1 = new Shalter(), s2 = new Shalter(), s3 = new Shalter();
        public Program()
        {
            
        }
        static void Main(string[] args)
        {
            
           
            shalteri.Add(s1);
            shalteri.Add(s2);
            shalteri.Add(s3);
            meni();
            
        }
        public static void meni ()
        {
            Console.Clear();
            Console.WriteLine("Meni:");
            Console.WriteLine("1) Usluzi go klientot");
            Console.WriteLine("2) Prodadeni karti na shalter");
            Console.WriteLine("3) Vkupen promet na shalter");
            Console.WriteLine("4) Site prodadeni karti po shalter");
            Console.WriteLine("5) Vkupen promet");
            Console.WriteLine("6) Uspeshnost na agencijata");
            Console.WriteLine("7) Izlez");

            int choice;
            do
            {
                Console.WriteLine("Izberete opcija od menito!");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 7);

            switch (choice)
            {
                case 1:
                    usluzi();
                    break;
                case 2:
                    prodadeniShalter();
                    break;
                case 3:
                    prometShalter();
                    break;
                case 4:
                    siteProdadeni();
                    break;
                case 5:
                    vkupenPromet();
                    break;
                case 6:
                    uspeshnost();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
            }
        }

        private static void uspeshnost()
        {
            Console.WriteLine("Vnesete vkupen broj na klienti koi doshle");
            float i = Int32.Parse(Console.ReadLine());
            int usluzeni = 0;
            foreach (Shalter s in shalteri) usluzeni += s.usluzeniKlienti;
            float odnos = usluzeni / i * 100;
            Console.WriteLine(odnos + "%");
            Console.ReadKey();
            meni();
        }

        private static void vkupenPromet()
        {
            long promet = 0;
            foreach (Shalter s in shalteri)
                promet += s.promet;
            Console.WriteLine(promet);
            Console.ReadKey();
            meni();
        }

        private static void siteProdadeni()
        {
            int i = 1;
            foreach (Shalter s in shalteri) {
                Console.WriteLine("Shalter {0}",  i++);
                if (s.usluzeniKlienti==0)
                {
                    Console.WriteLine("Ne se usluzeni klienti!\n");

                }
                else
                {
                    foreach (Klient k in s.klienti)
                    {
                        Console.Write(k.ToString()+ "\n");

                    }
                }
                
                

            }
            Console.ReadKey();
            meni();
        }

        private static void prometShalter()
        {
            int brojShalter;
            do
            {
                Console.WriteLine("Izberi broj na shalter (1, 2 ili 3)");
            } while (!int.TryParse(Console.ReadLine(), out brojShalter) || brojShalter < 1 || brojShalter > 3);
            if (brojShalter == 1)
            {
                Console.WriteLine("Vkupen promet na shalter 1:" + s1.promet);
            }
            else if (brojShalter == 2)
            {
                Console.WriteLine("Vkupen promet na shalter 2:" + s2.promet);
            }
            else
            {
                Console.WriteLine("Vkupen promet na shalter 3:" + s3.promet);
            }
            Console.ReadKey();
            Console.Clear();
            meni();
        }

        private static void prodadeniShalter()
        {
            Console.Clear();
            int brojShalter;
            do
            {
                Console.WriteLine("Izberi broj na shalter (1, 2 ili 3)");
            } while (!int.TryParse(Console.ReadLine(), out brojShalter) || brojShalter < 1 || brojShalter > 3);
            if (brojShalter==1)
            {
                Console.WriteLine("Prodadeni karti na shalter 1:" + s1.usluzeniKlienti);
            }
            else if (brojShalter == 2)
            {
                Console.WriteLine("Prodadeni karti na shalter 2:" + s2.usluzeniKlienti);
            }
            else 
            {
                Console.WriteLine("Prodadeni karti na shalter 3:" + s3.usluzeniKlienti);
            }
            Console.ReadKey();
            Console.Clear();
            meni();


        }

        private static void usluzi()
        {
            Console.Clear();
            Console.WriteLine("Vnesi ime:");
            string ime = Console.ReadLine();
            Console.WriteLine("Vnesi prezime:");
            string prezime = Console.ReadLine();
            
            int godini;
            do
            {
                Console.WriteLine("Vnesi godini:");
            } while (!Int32.TryParse(Console.ReadLine(), out godini));
              
       
            bool flag=false;
            string destinacija;

            Console.WriteLine("Vnesi destinacija:");
            destinacija = Console.ReadLine();
            destinacija.Trim().ToLower();
            foreach (string s in destinacii)
            {
                if (destinacija == s.ToLower()) flag = true;
            }

            while (!flag)
            {
                Console.WriteLine("Nevalidna destinacija; izberi edna od ovie:");
                Console.WriteLine("Rim, London, Tokio, Sofija, Istanbul, Toronto, Majami, Zagreb, Belgrad, Moskva");
                destinacija = Console.ReadLine();
                destinacija.Trim().ToLower();
                foreach (string s in destinacii)
                {
                    if (destinacija == s.ToLower()) flag = true;
                }
            }

            int brojShalter;
            do
            {
                Console.WriteLine("Izberi broj na shalter (1, 2 ili 3)");
            } while (!int.TryParse(Console.ReadLine(), out brojShalter) || brojShalter < 1 || brojShalter > 3);


            Klient klient = new Klient();
            klient.ime = ime;
            klient.prezime = prezime;
            klient.godini = godini;
            klient.destinacija = destinacija;

            switch (brojShalter)
            {
                case 1:
                    shalteri[0].dodadiKlient(klient);
                    break;
                case 2:
                    shalteri[1].dodadiKlient(klient);
                    break;
                case 3:
                    shalteri[2].dodadiKlient(klient);
                    break;
            }
           
            Console.Clear();
            meni();
            
        }
    }

  
}
