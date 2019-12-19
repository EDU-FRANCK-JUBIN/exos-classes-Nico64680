using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCsharp.Exercise1;
using TpCsharp.Exercise2;
using TpCsharp.Exercise3;

namespace TpCsharp
{
    class Program
    {
        public static object Article { get; private set; }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //ex1();
            //ex2();
            ex3();
            Console.ReadLine();
        }

        private static void ex1()
        {
            CompteBancaire compteCourant = new CompteBancaire("Nicolas", 0, "euros");
            compteCourant.Crediter(2000);
            compteCourant.Debiter(1000);

            Console.WriteLine(compteCourant.ToString());
        }

        private static void ex2()
        {

            Client nicolas = new Client(12345, "Ferreira", "Nicolas");
            Compte livretA = new Compte(nicolas);
            Compte livretJeune = new Compte(nicolas);

            livretA.Crediter(1000);
            livretJeune.Crediter(1000);

            livretJeune.Crediter(500, ref livretA);

            Console.WriteLine(livretA.Resumer());
            Console.WriteLine(livretJeune.Resumer());
        }

        private static void ex3()
        {
            Article affiche = new Article();
            affiche.Reference = "12345";
            affiche.Designation = "AfficheA";
            affiche.PrixHt = 10;
            affiche.TauxTVA = 20;

            Console.WriteLine(affiche.AfficherArticle());
            Console.WriteLine("Prix TTC : {0} €", affiche.CalculerPrixTTC().ToString());


            Article chaussure = new Article("ad123", "ChaussureAdidas", 85, 20);
            Console.WriteLine(chaussure.AfficherArticle());
            Console.WriteLine("Prix TTC : {0} €", chaussure.CalculerPrixTTC());


            Article frigo = new Article("smg123", "frigo samsumg");
            frigo.PrixHt = 400;
            frigo.TauxTVA = 20;
            Console.WriteLine(frigo.AfficherArticle());
            Console.WriteLine("Prix TTC : {0} €", frigo.CalculerPrixTTC());


            Article JangoFett = new Article("jf", "OriginalJangoFett", 1000, 20);
            Article cloneA = new Article(JangoFett);

            cloneA.PrixHt = 500;
            Console.WriteLine(cloneA.AfficherArticle());
            Console.WriteLine("Prix TTC : {0} €", cloneA.CalculerPrixTTC());

            //Avec prix TVA global
            Exercise3.Article.gTauxTva = 50;
            Article biere = new Article();
            biere.Designation = "BiereHeineken";
            biere.Reference = "he0149";
            biere.PrixHt = 2;

            Console.WriteLine(biere.AfficherArticle());
            Console.WriteLine("Prix TTC : {0} €", biere.CalculerGlobalPrixTTC());

        }
    }
}
