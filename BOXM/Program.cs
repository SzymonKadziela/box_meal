using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOXM
{
    class Program
    {
        static void Main(string[] args)
        {

            Meal meal = new Meal();

            Component component1 = new Component();
            component1.Name = "JAJKO";
            component1.Kcal = 20;
            component1.Price = 5;
            component1.IsWegan = true;
            component1.Type = "Przystawka";

            Component component2 = new Component();
            component2.Name = "KAPUSTA";
            component2.Kcal = 150;
            component2.Price = 13;
            component2.IsWegan = true;
            component2.Type = "Przystawka";

            Component component3 = new Component();
            component3.Name = "KIEŁKI";
            component3.Kcal = 200;
            component3.Price = 17;
            component3.IsWegan = true;
            component3.Type = "Przystawka";

            Component component4 = new Component();
            component4.Name = "BOCZEK";
            component4.Kcal = 60;
            component4.Price = 8;
            component4.IsWegan = false;
            component4.Type = "Główne";

            Component component5 = new Component();
            component5.Name = "BEYOND";
            component5.Kcal = 140;
            component5.Price = 30;
            component5.IsWegan = true;
            component5.Type = "Główne";

            Component component6 = new Component();
            component6.Name = "KURCZAK";
            component6.Kcal = 100;
            component6.Price = 10;
            component6.IsWegan = false;
            component6.Type = "Główne";

            Component component7 = new Component();
            component7.Name = "JOGURT";
            component7.Kcal = 120;
            component7.Price = 4;
            component7.IsWegan = true;
            component7.Type = "Deser";

            Component component8 = new Component();
            component8.Name = "BATONIK";
            component8.Kcal = 420;
            component8.Price = 12;
            component8.IsWegan = true;
            component8.Type = "Deser";

            Component component9 = new Component();
            component9.Name = "CIASTKO";
            component9.Kcal = 320;
            component9.Price = 3;
            component9.IsWegan = true;
            component9.Type = "Deser";

            Component component10 = new Component();
            component10.Name = "Wegaśka kiełbaska";
            component10.Kcal = 100;
            component10.Price = 9;
            component10.IsWegan = true;
            component10.Type = "Główne";

            Component component11 = new Component();
            component11.Name = "SOS ZERO";
            component11.Kcal = 10;
            component11.Price = 19;
            component11.IsWegan = true;
            component11.Type = "Deser";

            Component component12 = new Component();
            component12.Name = "WOŁOWINA";
            component12.Kcal = 250;
            component12.Price = 50;
            component12.IsWegan = false;
            component12.Type = "Główne";

            Component component13 = new Component();
            component13.Name = "TOFU";
            component13.Kcal = 360;
            component13.Price = 35;
            component13.IsWegan = true;
            component13.Type = "Przystawka";

            Component component14 = new Component();
            component14.Name = "ORZECHY";
            component14.Kcal = 520;
            component14.Price = 66;
            component14.IsWegan = true;
            component14.Type = "Przystawka";





            WP("DIETA PUDEŁKOWA");
            WP("Co chcesz zrobić (wpisz a lub b):");

            string OdpU1 = Console.ReadLine();

            if (OdpU1 == "a" || OdpU1 == "A")
            {
              
                 WP("Proszę podać wartość kaloryczną diety: ");
                Console.WriteLine();
                Console.WriteLine("a. 1000 kcal");
                Console.WriteLine("b. 1500 kcal");
                Console.WriteLine("c. 2000 kcal");
                Console.WriteLine("d. 2500 kcal");
                Console.WriteLine("e. 3000 kcal");

                string OdpU2 = Console.ReadLine();

                Console.WriteLine("Proszę podać czy dieta ma być wegetariańska: tak(T), nie(N)");
                string OdpU3 = Console.ReadLine();

                if(OdpU2 == "a" || OdpU2== "A")
                {
                    if(OdpU3=="T" || OdpU3 == "t")
                    {
                        Console.WriteLine("Dieta 1000 kcal (Wegetariańska)");
                        Console.WriteLine();
                        Console.WriteLine();
                        int sumas = component1.Kcal + component5.Kcal + component7.Kcal;
                        int sumao = component2.Kcal + component5.Kcal + component7.Kcal;
                        int sumak = component3.Kcal + component10.Kcal + component11.Kcal;
                        Console.WriteLine($"Śniadanie ({component1.Name}/{component5.Name}/{component7.Name}) {sumas} kcal");
                        Console.WriteLine($"Obiad ({component2.Name}/{component10.Name}/{component7.Name}) {sumao} kcal");
                        Console.WriteLine($"Kolacja ({component3.Name}/{component10.Name}/{component11.Name}) {sumak} kcal");
                        Console.WriteLine();
                        int sumaa = sumas + sumao + sumak;
                        Console.WriteLine($"WARTOŚĆ KALORYCZNA OGÓŁEM: {sumaa} kcal");
                        int cena = component1.Price + 2 * (component5.Price) + 2 * (component7.Price) + component3.Price + component10.Price + component11.Price;
                        Console.WriteLine($"ŁĄCZNA CENA: {cena} PLN");
                    }
                    else if(OdpU3 == "N" || OdpU3 == "n")
                    {
                        Console.WriteLine("Dieta 1000 kcal (Wegetariańska)");
                        Console.WriteLine();
                        Console.WriteLine();
                        int sumas = component1.Kcal + component4.Kcal + component9.Kcal;
                        int sumao = component2.Kcal + component5.Kcal + component7.Kcal;
                        int sumak = component1.Kcal + component4.Kcal + component7.Kcal;
                        Console.WriteLine($"Śniadanie ({component1.Name}/{component4.Name}/{component9.Name}) {sumas} kcal");
                        Console.WriteLine($"Obiad ({component2.Name}/{component5.Name}/{component7.Name}) {sumao} kcal");
                        Console.WriteLine($"Kolacja ({component1.Name}/{component4.Name}/{component7.Name}) {sumak} kcal");
                        Console.WriteLine();
                        int sumaa = sumas + sumao + sumak;
                        Console.WriteLine($"WARTOŚĆ KALORYCZNA OGÓŁEM: {sumaa} kcal");
                        int cena = 2*component1.Price + component5.Price + 2 * (component7.Price) + 2*component4.Price + component9.Price + component2.Price;
                        Console.WriteLine($"ŁĄCZNA CENA: {cena} PLN");
                    }
                    else { Console.WriteLine("Wypierz poprawną odpowiedź"); }
                }

                if (OdpU2 == "b" || OdpU2 == "B")
                {
                    if (OdpU3 == "T" || OdpU3 == "t")
                    {
                        Console.WriteLine("Dieta 1500 kcal (Wegetariańska)");
                        Console.WriteLine();
                        Console.WriteLine();
                        int sumas = component1.Kcal + component5.Kcal + component9.Kcal;
                        int sumao = component2.Kcal + component5.Kcal + component8.Kcal;
                        int sumak = component3.Kcal + component10.Kcal + component11.Kcal;
                        Console.WriteLine($"Śniadanie ({component1.Name}/{component5.Name}/{component9.Name}) {sumas} kcal");
                        Console.WriteLine($"Obiad ({component2.Name}/{component10.Name}/{component8.Name}) {sumao} kcal");
                        Console.WriteLine($"Kolacja ({component3.Name}/{component10.Name}/{component11.Name}) {sumak} kcal");
                        Console.WriteLine();
                        int sumaa = sumas + sumao + sumak;
                        Console.WriteLine($"WARTOŚĆ KALORYCZNA OGÓŁEM: {sumaa} kcal");
                        int cena = component1.Price + 2 * (component5.Price) + component2.Price + component3.Price + component10.Price + component11.Price + component9.Price + component8.Price;
                        Console.WriteLine($"ŁĄCZNA CENA: {cena} PLN");
                    }
                    else if (OdpU3 == "N" || OdpU3 == "n")
                    {
                        Console.WriteLine("Dieta 1500 kcal (Wegetariańska)");
                        Console.WriteLine();
                        Console.WriteLine();
                        int sumas = component3.Kcal + component4.Kcal + component9.Kcal;
                        int sumao = component3.Kcal + component6.Kcal + component7.Kcal;
                        int sumak = component1.Kcal + component5.Kcal + component9.Kcal;
                        Console.WriteLine($"Śniadanie ({component3.Name}/{component4.Name}/{component9.Name}) {sumas} kcal");
                        Console.WriteLine($"Obiad ({component3.Name}/{component6.Name}/{component7.Name}) {sumao} kcal");
                        Console.WriteLine($"Kolacja ({component1.Name}/{component5.Name}/{component9.Name}) {sumak} kcal");
                        Console.WriteLine();
                        int sumaa = sumas + sumao + sumak;
                        Console.WriteLine($"WARTOŚĆ KALORYCZNA OGÓŁEM: {sumaa} kcal");
                        int cena = component1.Price + 2 * (component3.Price) + component4.Price + component5.Price + component6.Price + component7.Price + 2 * component9.Price;
                        Console.WriteLine($"ŁĄCZNA CENA: {cena} PLN");
                    }
                    else { Console.WriteLine("Wypierz poprawną odpowiedź"); }
                }

                if (OdpU2 == "c" || OdpU2 == "C")
                {
                    if (OdpU3 == "T" || OdpU3 == "t")
                    {
                        Console.WriteLine("Dieta 2000 kcal (Wegetariańska)");
                        Console.WriteLine();
                        Console.WriteLine();
                        int sumas = component2.Kcal + component5.Kcal + component8.Kcal;
                        int sumao = component3.Kcal + component10.Kcal + component9.Kcal;
                        int sumak = component2.Kcal + component10.Kcal + component8.Kcal;
                        Console.WriteLine($"Śniadanie ({component2.Name}/{component5.Name}/{component8.Name}) {sumas} kcal");
                        Console.WriteLine($"Obiad ({component3.Name}/{component10.Name}/{component9.Name}) {sumao} kcal");
                        Console.WriteLine($"Kolacja ({component2.Name}/{component10.Name}/{component8.Name}) {sumak} kcal");
                        Console.WriteLine();
                        int sumaa = sumas + sumao + sumak;
                        Console.WriteLine($"WARTOŚĆ KALORYCZNA OGÓŁEM: {sumaa} kcal");
                        int cena = component1.Price + 2 * (component10.Price) + 2*component2.Price + component3.Price + component9.Price + 2*component8.Price + component5.Price; 
                        Console.WriteLine($"ŁĄCZNA CENA: {cena} PLN");
                    }
                    else if (OdpU3 == "N" || OdpU3 == "n")
                    {
                        Console.WriteLine("Dieta 2000 kcal (Wegetariańska)");
                        Console.WriteLine();
                        Console.WriteLine();
                        int sumas = component2.Kcal + component12.Kcal + component9.Kcal;
                        int sumao = component3.Kcal + component6.Kcal + component8.Kcal;
                        int sumak = component1.Kcal + component12.Kcal + component9.Kcal;
                        Console.WriteLine($"Śniadanie ({component2.Name}/{component12.Name}/{component9.Name}) {sumas} kcal");
                        Console.WriteLine($"Obiad ({component3.Name}/{component6.Name}/{component8.Name}) {sumao} kcal");
                        Console.WriteLine($"Kolacja ({component1.Name}/{component12.Name}/{component9.Name}) {sumak} kcal");
                        Console.WriteLine();
                        int sumaa = sumas + sumao + sumak;
                        Console.WriteLine($"WARTOŚĆ KALORYCZNA OGÓŁEM: {sumaa} kcal");
                        int cena = component1.Price + 2 * (component3.Price) + component4.Price + component5.Price + component6.Price + component7.Price + 2 * component9.Price;
                        Console.WriteLine($"ŁĄCZNA CENA: {cena} PLN");
                    }
                    else { Console.WriteLine("Wypierz poprawną odpowiedź"); }
                }

                if (OdpU2 == "d" || OdpU2 == "D")
                {
                    if (OdpU3 == "T" || OdpU3 == "t")
                    {
                        Console.WriteLine("Dieta 2500 kcal (Wegetariańska)");
                        Console.WriteLine();
                        Console.WriteLine();
                        int sumas = component3.Kcal + component5.Kcal + component8.Kcal;
                        int sumao = component13.Kcal + component10.Kcal + component8.Kcal;
                        int sumak = component3.Kcal + component5.Kcal + component8.Kcal;
                        Console.WriteLine($"Śniadanie ({component3.Name}/{component5.Name}/{component8.Name}) {sumas} kcal");
                        Console.WriteLine($"Obiad ({component13.Name}/{component10.Name}/{component8.Name}) {sumao} kcal");
                        Console.WriteLine($"Kolacja ({component3.Name}/{component5.Name}/{component8.Name}) {sumak} kcal");
                        Console.WriteLine();
                        int sumaa = sumas + sumao + sumak;
                        Console.WriteLine($"WARTOŚĆ KALORYCZNA OGÓŁEM: {sumaa} kcal");
                        int cena = component10.Price + 2 * (component3.Price) + 2 * component5.Price + 2*component3.Price + 3 * component8.Price;
                        Console.WriteLine($"ŁĄCZNA CENA: {cena} PLN");
                    }
                    else if (OdpU3 == "N" || OdpU3 == "n")
                    {
                        Console.WriteLine("Dieta 2500 kcal (Wegetariańska)");
                        Console.WriteLine();
                        Console.WriteLine();
                        int sumas = component2.Kcal + component12.Kcal + component8.Kcal;
                        int sumao = component3.Kcal + component6.Kcal + component8.Kcal;
                        int sumak = component3.Kcal + component12.Kcal + component8.Kcal;
                        Console.WriteLine($"Śniadanie ({component2.Name}/{component12.Name}/{component8.Name}) {sumas} kcal");
                        Console.WriteLine($"Obiad ({component3.Name}/{component6.Name}/{component8.Name}) {sumao} kcal");
                        Console.WriteLine($"Kolacja ({component3.Name}/{component12.Name}/{component8.Name}) {sumak} kcal");
                        Console.WriteLine();
                        int sumaa = sumas + sumao + sumak;
                        Console.WriteLine($"WARTOŚĆ KALORYCZNA OGÓŁEM: {sumaa} kcal");
                        int cena = 2 * (component3.Price) + component2.Price + 3*component8.Price + component6.Price + 2 * component12.Price;
                        Console.WriteLine($"ŁĄCZNA CENA: {cena} PLN");
                    }
                    else { Console.WriteLine("Wypierz poprawną odpowiedź"); }
                }

                if (OdpU2 == "e" || OdpU2 == "E")
                {
                    if (OdpU3 == "T" || OdpU3 == "t")
                    {
                        Console.WriteLine("Dieta 3000 kcal (Wegetariańska)");
                        Console.WriteLine();
                        Console.WriteLine();
                        int sumas = component14.Kcal + component5.Kcal + component8.Kcal;
                        int sumao = component13.Kcal + component10.Kcal + component8.Kcal;
                        int sumak = component14.Kcal + component5.Kcal + component8.Kcal;
                        Console.WriteLine($"Śniadanie ({component14.Name}/{component5.Name}/{component8.Name}) {sumas} kcal");
                        Console.WriteLine($"Obiad ({component13.Name}/{component10.Name}/{component8.Name}) {sumao} kcal");
                        Console.WriteLine($"Kolacja ({component3.Name}/{component5.Name}/{component8.Name}) {sumak} kcal");
                        Console.WriteLine();
                        int sumaa = sumas + sumao + sumak;
                        Console.WriteLine($"WARTOŚĆ KALORYCZNA OGÓŁEM: {sumaa} kcal");
                        int cena = component13.Price + 2 * (component14.Price) + 2 * component5.Price + component10.Price + 3 * component8.Price;
                        Console.WriteLine($"ŁĄCZNA CENA: {cena} PLN");
                    }
                    else if (OdpU3 == "N" || OdpU3 == "n")
                    {
                        Console.WriteLine("Dieta 3000 kcal (Wegetariańska)");
                        Console.WriteLine();
                        Console.WriteLine();
                        int sumas = component14.Kcal + component12.Kcal + component9.Kcal;
                        int sumao = component3.Kcal + component6.Kcal + component8.Kcal;
                        int sumak = component14.Kcal + component12.Kcal + component8.Kcal;
                        Console.WriteLine($"Śniadanie ({component14.Name}/{component5.Name}/{component9.Name}) {sumas} kcal");
                        Console.WriteLine($"Obiad ({component3.Name}/{component12.Name}/{component8.Name}) {sumao} kcal");
                        Console.WriteLine($"Kolacja ({component14.Name}/{component12.Name}/{component8.Name}) {sumak} kcal");
                        Console.WriteLine();
                        int sumaa = sumas + sumao + sumak;
                        Console.WriteLine($"WARTOŚĆ KALORYCZNA OGÓŁEM: {sumaa} kcal");
                        int cena = component3.Price + 2 * (component14.Price) + 2*component12.Price + component6.Price + component9.Price + 2 * component8.Price;
                        Console.WriteLine($"ŁĄCZNA CENA: {cena} PLN");
                    }
                    else { Console.WriteLine("Wypierz poprawną odpowiedź"); }
                }

            }
            else if(OdpU1=="b" || OdpU1 == "B") 
            {
                WP("Lista dostępnych składników:");
                WS(component1);
                WS(component2);
                WS(component3);
                WS(component4);
                WS(component5);
                WS(component6);
                WS(component7);
                WS(component8);
                WS(component9);
                WS(component10);
                WS(component11);
                WS(component12);
                WS(component13);
                WS(component14);
            }

            static void WP(string tekst)
            {
                Console.WriteLine();
                Console.WriteLine(tekst);
            }

            static void WS(Component component)
            {
                Console.WriteLine();
                if (component.IsWegan)
                {
                    Console.WriteLine($"{component.Name} ({component.Type}), {component.Kcal} cal, { component.Price} PLN, WEGETARIAŃSKIE: TAK");
                }
                else
                {
                    Console.WriteLine($"{component.Name} ({component.Type}), {component.Kcal} cal, { component.Price} PLN, WEGETARIAŃSKIE: NIE");
                }
            }
           

            System.Console.ReadKey();



        }

    }
}
