﻿// See https://aka.ms/new-console-template for more information
//1.1
// Exo1
//Console.WriteLine("Votre Nom ?");
//String s = Console.ReadLine();
//Console.WriteLine("Bonjour " + s);

//Exo 2
//Console.Write("Votre Age ?");
//String valeur = Console.ReadLine();
//Int convert = Convert.ToInt32(valeur);
//Console.WriteLine("Vous avez " + convert + " ans");

//1.2
// Exo 3

//int a, b;
//Console.WriteLine("a = ?");
//Console.WriteLine("b = ?");
//a = Convert.ToInt32(Console.ReadLine());
//b = Convert.ToInt32(Console.ReadLine());
//if (a != 0 && b != 0)
//{
//    Console.WriteLine("Somme : " + (a + b) + " Quotient : " + (a / b));
//}
//else
//{
//    Console.WriteLine("Imposssible");
//}

//1.3
//Exo4 
//Console.Write("Ecrit une valeur flottante : ");
//Decimal convert = Convert.ToDecimal(Console.ReadLine());
//Console.WriteLine(convert);

//Exo5
//decimal convert, convert2, convert3;
//Console.Write("Valeur 1 ? ");
//convert = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Valeur 2 ? ");
//convert2 = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Valeur 3 ? ");
//convert3 = Convert.ToDecimal(Console.ReadLine());
//Console.WriteLine("Moyenne : " +(convert + convert2 + convert3) / 3);


//Exo6
//double longueur, largeur;
//Console.Write("Longueur du Rectangle ? ");
//longueur = Convert.ToDouble(Console.ReadLine());
//Console.Write("Largeur du Rectangle ? ");
//largeur = Convert.ToDouble(Console.ReadLine());
//if (largeur == longueur)
//{
//    Console.WriteLine("Aire du Carré : " + (longueur * largeur));
//} else
//{
//    Console.WriteLine("Aire du Rectangle : " + (longueur * largeur));
//}

//1.4
//Exo 7
//Char var = 'a';
//int Al = Convert.ToUInt16(var);
//Console.WriteLine(Al);


//Exo 8 
//Console.WriteLine("Ecrivez un texte : ");
//Console.WriteLine(Console.ReadLine().ToUpper());


//2

//Exo 1
//Char successeur, convert;
//int unicode, unisucc;
//Console.WriteLine("lettre ?");
//convert = Convert.ToChar(Console.ReadLine()[0]);
//unicode = Convert.ToUInt16(convert);
//unisucc = (unicode + 1);
//successeur = (Char)((int)convert + 1);
//Console.WriteLine(convert + " " + unicode + " " + successeur + " " + unisucc);


//Exo 2
//List<int> nombre = new List<int>()
// {'1','2','3','4','5','6','7','8','9'};
//foreach (var item in nombre)
//{
//    int uni = Convert.ToUInt16(item);
//    Console.WriteLine(uni);

//Exo 3
//Double carton, camion, marchandise;
//Console.WriteLine("Masse de la Marchandise ?");
//marchandise = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Masse du Camion ?");
//camion = Convert.ToDouble(Console.ReadLine());
//carton = Math.Round(camion / marchandise);
//Console.WriteLine("Marchandise : " + marchandise + " kilos " + "Camion : "  + camion + " Kilos");
//Console.WriteLine("Il est possible de placer " + carton + " Carton(s)");

//Exo 4 ( Pas fini / pas bon )
//monnaie = new double[] { 0.5, 0.2, 0.1, 0.05, 0.02, 0.01};
//Double client;
//Console.WriteLine("Saississez une Valeur entre 0 et 0.99");
//client = Convert.ToDouble(Console.ReadLine());
//if (client < 1)
//{
//    cinquante = 0;
//    vingt = 0;
//    while (client > 0.5)
//    {
//        cinquante++;
//    }
//    while (client > 0.2)
//    {
//        vingt++;
//    }
//    Console.WriteLine(client + " Euros");
//}
//else
//{
//    Console.WriteLine("Tu ne sais pas lire");
//}


//3.1 ( Manque une verif si c'est pas un Int )

//int age;
//Console.WriteLine("Quelle est ton âge ? ");
//age = Convert.ToInt32(Console.ReadLine());

//if (age >= 18)
//{
//    Console.WriteLine("Vous êtes Majeur ");
//}
//else
//{
//    Console.WriteLine("Vous êtes Mineur");
//}


//3.2 
//Double convert, absolute;
//Console.Write("Valeur ?");
//convert = Convert.ToDouble(Console.ReadLine());
//absolute = Math.Abs(convert);
//Console.WriteLine(absolute);


//3.3

//Double note;
//String resultat;
//Console.Write("Note ?");
//note = Convert.ToDouble(Console.ReadLine());
//if (note < 10)
//{
//    resultat = "ajourné";
//} else if (note > 10)
//{
//    resultat = "Admis";
//} else
//{
//    resultat = "Rattrapage";
//}

//Console.WriteLine(resultat);


//3.4

//using System.ComponentModel.DataAnnotations;

//Double franchise, rembourse, dommages, franchisemax = 4000;
//Console.WriteLine("Montant des Dommages ?");
//dommages = Convert.ToDouble(Console.ReadLine());
//franchise = (dommages * 0.1);
//if (franchise > franchisemax)
//{
//    franchise = franchisemax;
//}
//rembourse = (dommages - franchise);
//Console.WriteLine("Le Montant a remboursé est de : " + rembourse + " euros et la Franchise est de : " + franchise);


//3.5
//Double valeur1, valeur2;
//Console.WriteLine("Valeur 1 ?");
//valeur1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Valeur 2 ?");
//valeur2 = Convert.ToDouble(Console.ReadLine());
//if (valeur1 == valeur2)
//{
//    Console.WriteLine("Il y a une valeur Distincte");
//} else
//{
//    Console.WriteLine("l y a deux valeurs Distinctes");
//}


//3.6
// Trouvez le plus petit

//Double valeur1, valeur2, valeur3, valeurmin;
//String val1, val2, val3;

//for (int i = 1; i < 4; i++)
//{
//    Console.WriteLine("Valeur " + i + " ?");
//}

//valeur1 = Convert.ToDouble(Console.ReadLine());
//valeur2 = Convert.ToDouble(Console.ReadLine());
//valeur3 = Convert.ToDouble(Console.ReadLine());
//valeurmin = Math.Min(valeur1, Math.Min(valeur2, valeur3));
//Console.WriteLine("Le Plus petit nombre est : " + valeurmin);


//3.7
//Calculatrice

//using System.ComponentModel.DataAnnotations;
//using System.Runtime.Intrinsics.Arm;

//Double a, b, resultat;
//char op;
//resultat = 0;

//    Console.WriteLine("Valeur de a ?");
//    a = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("Valeur de b ?");
//    b = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("Signe ?");
//    op = Console.ReadLine()[0];
//    switch (op)
//    {
//        case '+':
//            resultat = (a + b);
//            break;
//        case '-':
//            resultat = (a - b);
//            break;
//        case '*':
//            resultat = (a * b);
//            break;
//        case '/':
//            resultat = (a / b);
//            break;
//        default:
//            Console.WriteLine("Non");
//            break;
//    }
//Console.WriteLine(resultat);



//3.8

//Demande de couleur de la Case 
int i, j;
Console.WriteLine("Coordonnées de i ?");
i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Coordonnées de j ?");
j = Convert.ToInt32(Console.ReadLine());
if ((i + j) % 2 == 0)
{
    Console.WriteLine("La case " + "(" + i + "," + j + ") " + "une case Noire");
} else
{
    Console.WriteLine("La case " + "(" + i + "," + j + ") " + "une case Blanche");
}



// CORRECTION

//1.2 TryParse est meilleur

//1.3 Rajouter une condition : Si c'est pas un int 



// Moyenne Arithmétique

//int max = 3;
//Console.WriteLine("Entrez " + max + " nombres");
//float[] tableau = new float[max];
//for (int i = 0; i < max; i++)
//{
//    tableau[i] = Convert.ToDouble(Console.ReadLine());
//}
//double moyenne = Queryable.Average(tableau.AsQueryable());

//Console.WriteLine("Moyenne : " + moyenne);


//1.8

//Char caractere;
//Console.WriteLine("Entrez un caratère : ");
//caractere = Console.ReadLine()[0];
//Console.WriteLine("Caractère en majuscule : " + caractere.ToString().ToUpper());


//2.3
//Double poidsCarton = 0;
//Double poidsMaxCam = 0;
//int nbrCarton = 0;

//Console.WriteLine("Entrer le poids des cartons : ");
//poidsCarton = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Entrer le poids max du camion : ");
//poidsMaxCam = Convert.ToDouble(Console.ReadLine());
//nbrCarton = (int)(poidsMaxCam / poidsCarton);
//Console.WriteLine("le camion peut transporte " + nbrCarton + " carton");

//2.4

//Double somme;
//List<Double> tabMonnaies = new List<Double> { 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };
//do
//{
//    Console.Write("Saisir une valeur entre 0 et 0.99 ? ");
//    String S = Console.ReadLine();
//    somme = Convert.ToDouble(S);
//} while (somme < 0 || somme > 0.99);

//int i = 0;
//while (somme > 0)
//{
//    if (Math.Round(somme, 2) >= tabMonnaies[i])
//    {
//        Console.WriteLine("1 pièce de" + tabMonnaies[i]);
//        somme -= Math.Round(tabMonnaies[i], 2);
//        i = -1;
//    }
//    i++;
//    Console.WriteLine(somme);
//    Console.WriteLine(i);
//}
