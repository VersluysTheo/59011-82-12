// See https://aka.ms/new-console-template for more information

// Correction 
//////////////////////////////////////////////////////////////  ECHEC


//private static void Chess()
//{
//    int piece;
//    do
//    {
//        Console.WriteLine("\nQuelle pièce souhaitez-vous déplacer: ");
//    } while (!int.TryParse(Console.ReadLine(), out piece) || (piece > 5 && piece < -1));

//    Console.WriteLine("\nPosition de départ");
//    int ipos1;
//    int jpos1;
//    PosEchiquier(out ipos1, out jpos1);
//    ChessColor(ipos1 + jpos1);

//    Console.WriteLine("\nPosition d'arrivée");
//    int ipos2;
//    int jpos2;
//    PosEchiquier(out ipos2, out jpos2);
//    ChessColor(ipos2 + jpos2);

//    bool res = false;
//    string name = "";

//    switch (piece)
//    {
//        case 0:
//            res = CheckCavalier(ipos1, jpos1, ipos2, jpos2);
//            name = "du cavalier";
//            break;
//        case 1:
//            res = CheckTour(ipos1, jpos1, ipos2, jpos2);
//            name = "de la tour";
//            break;
//        case 2:
//            res = CheckFou(ipos1, jpos1, ipos2, jpos2);
//            name = "du fou";
//            break;
//        case 3:
//            res = CheckFou(ipos1, jpos1, ipos2, jpos2) || CheckTour(ipos1, jpos1, ipos2, jpos2);
//            name = "de la Dame";
//            break;
//        case 4:
//            res = CheckRoi(ipos1, jpos1, ipos2, jpos2);
//            name = "du roi";
//            break;
//    }
//    string translate = res ? "correct" : "incorrect";

//    Console.WriteLine("\nDéplacement " + name + " de (" + ipos1 + "," + jpos1 + ") vers (" + ipos2 + "," + jpos2 + ") " + translate);
//}

//private static void PosEchiquier(out int iposdep, out int jposdep)
//{
//    do
//    {
//        Console.WriteLine("\nPos i: ");
//    } while (!int.TryParse(Console.ReadLine(), out iposdep) || iposdep > 9 && iposdep < -1);

//    do
//    {
//        Console.WriteLine("\nPos j: ");
//    } while (!int.TryParse(Console.ReadLine(), out jposdep) || jposdep > 9 && jposdep < -1);

//}

//private static void ChessColor(int posSum)
//{
//    Console.WriteLine(posSum % 2 == 0 ?
//                    "\nC'est une case noire" :
//                    "\nC'est une case blanche");
//}

//private static bool CheckCavalier(int ipos1, int jpos1, int ipos2, int jpos2)
//{
//    int x = Math.Abs(ipos1 - ipos2);
//    int y = Math.Abs(jpos1 - jpos2);

//    return (x == 1 && y == 2) || (x == 2 && y == 1);
//}

//private static bool CheckTour(int ipos1, int jpos1, int ipos2, int jpos2)
//{
//    return (ipos1 == ipos2) || (jpos1 == jpos2);
//}

//private static bool CheckFou(int ipos1, int jpos1, int ipos2, int jpos2)
//{
//    int x = Math.Abs(ipos1 - ipos2);
//    int y = Math.Abs(jpos1 - jpos2);

//    return x == y;
//}

//private static bool CheckRoi(int ipos1, int jpos1, int ipos2, int jpos2)
//{
//    int x = Math.Abs(ipos1 - ipos2);
//    int y = Math.Abs(jpos1 - jpos2);

//    return (x < 2 && y < 2);
//}



////////////////////////////////////////////////////////////// HEURES

//int heureDep;
//int minDep;
//int heureFin;
//int minFin;
//int heureDiff;
//int minDiff;

//Console.Write("Entrez l'heure de depart : ");
//while (!int.TryParse(Console.ReadLine(), out heureDep) || heureDep < 0 || heureDep > 23)
//{
//    Console.WriteLine("Saisie invalide");
//}
//Console.Write("Entrez les minute : ");
//while (!int.TryParse(Console.ReadLine(), out minDep) || minDep < 0 || minDep > 59)
//{
//    Console.WriteLine("Saisie invalide");
//}

//Console.Write("Entrez l'heure de fin : ");
//while (!int.TryParse(Console.ReadLine(), out heureFin) || heureFin < 0 || heureFin > 23)
//{
//    Console.WriteLine("Saisie invalide");
//}
//Console.Write("Entrez les minute : ");
//while (!int.TryParse(Console.ReadLine(), out minFin) || minFin < 0 || minFin > 59)
//{
//    Console.WriteLine("Saisie invalide");
//}
//if (heureDep > heureFin || (heureDep == heureFin && minDep > minFin))
//{
//    Console.WriteLine("la date de depart doit etre anterieur a la date de fin");
//}
//else
//{
//    heureDiff = heureFin - heureDep;
//    minDiff = minFin - minDep;
//    if (minDiff < 0)
//    {
//        heureDiff--;
//        minDiff += 60;
//    }
//    Console.WriteLine(String.Format("{0,2:D2}", heureDiff) + "h" + String.Format("{0,2:D2}", minDiff));
//}


///////////////////////////////////////////////////////////////// Compte a Rebours

//int n;

//do
//{
//    Console.WriteLine("\nSaisir une valeur numérique positive:");
//} while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

//int n1 = n, n2 = n, n3 = n;

//while (n1 != 0)
//{
//    Console.WriteLine("\n" + --n1);
//}

//do
//{
//    Console.WriteLine("\n" + --n2);
//} while (n2 != 0);

//for (int i = n; i >= 0; i--)
//{
//    Console.WriteLine("\n" + i);
//}

////////////////////////////////////////////////////////////// FACTORIELLE

//int nbr;

//Console.Write("Entrez un nombre : ");
//while (!int.TryParse(Console.ReadLine(), out nbr))
//{
//    Console.WriteLine("Saisie invalide");
//}

//Console.WriteLine(Factoriel(nbr));

//        }
//        private static int Factoriel(int nbr)
//{
//    return nbr == 0 ? 1 : nbr * Factoriel(nbr - 1);
//}


//////////////////////////////////////////////////////////////  Table de Multiplication ( en For car on connait le nombre d'itérations  )

//int nbChoisi;

//do
//{
//    Console.WriteLine("Choisir un nb et vous aurez sa table de multiplication : ");
//} while (!int.TryParse(Console.ReadLine(), out nbChoisi));

//for (int i = 0; i < 11; i++)
//{
//    Console.WriteLine(nbChoisi + " * " + i + " = " + (nbChoisi * i));
//}


//////////////////////////////////////////////////////////////  Tableaux a double entreé

//static void Multiplication2d()
//{

//    int[,] tables = new int[10, 10];
//    for (int i = 1; i < 11; i++)
//    {
//        for (int j = 1; j < 11; j++)
//        {
//            tables[i - 1, j - 1] = i * j;
//            Console.Write(i * j);
//        }
//        Console.WriteLine();
//    }
//}


///////////////////////////////////////////////// Joli Carré

//static void Carre()
//{
//    int n = SaisirVal(); // une methode ou tu saisi une valeur

//    Console.WriteLine("n = " + n);
//    string ligne = "";

//    for (int j = 0; j < n; j++) // fonction de ligne pour éviter de boucler deux fois 
//    {
//        ligne += "X\t";
//    }

//    for (int i = 0; i < n; i++)
//    {
//        Console.WriteLine(ligne + "\n");
//    }
//}


/////////////////////////////////////////////////////// Calculette le retour

//using System.Collections.Generic;
//using System;

//double Calculer(double nombre1, char operateur, double nombre2 = 1)
//{
//    double resultat = 0;

//    switch (operateur)
//    {
//        case '+':
//            resultat = nombre1 + nombre2;
//            break;

//        case '-':
//            resultat = nombre1 - nombre2;
//            break;

//        case '*':
//            resultat = nombre1 * nombre2;
//            break;

//        case '/':
//            {
//                Console.WriteLine(nombre2);
//                if (nombre2 != 0)
//                    resultat = nombre1 / nombre2;
//                else
//                {
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine("Erreur : Tentative de division par zéro");
//                    Console.ResetColor();
//                }
//            }
//            break;

//        case '^':
//            resultat = Math.Pow(nombre1, nombre2);
//            break;

//        case 's':
//            resultat = Math.Sqrt(nombre1);
//            break;


//        case '!':
//            resultat = Factorielle((int)nombre1);
//            break;

//        default:
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Erreur : Operateur '" + operateur + "' incorrecte");
//            Console.ResetColor();
//            break;
//    }

//    return resultat;
//}

//int Factorielle(int nombre)
//{
//    if (nombre >= 2) return nombre * Factorielle(nombre - 1);
//    return 1;
//}

//void AfficherResultat(double nombre1, char operateur, double resultat, double nombre2 = 1)
//{
//    if (operateur == 's')
//        Console.WriteLine($"La racine carrée de {nombre1} = {resultat}");

//    else if (operateur == '!')
//        Console.WriteLine($"La factorielle de {nombre1} = {resultat}");

//    else
//        Console.WriteLine($"{nombre1} {operateur} {nombre2} = {resultat}");
//}

//List<int> listOp = new List<int> { '+', '-', '*', '/', '=', '^', 's', '!' };
//bool stopCalcul = false;
//double a, b = 0, resultat;
//char op;

//do
//{
//    Console.WriteLine("Saisir la 1ere valeur");

//} while (!double.TryParse(Console.ReadLine(), out a));
//do
//{
//    Console.WriteLine("Saisir l'opérateur");

//} while (!char.TryParse(Console.ReadLine(), out op) || op == '=' || !listOp.Contains(op));

//if (op is not ('s' or '!'))
//    do
//    {
//        Console.WriteLine("Saisir la 2nde valeur");

//    } while (!double.TryParse(Console.ReadLine(), out b) || (op == '/' && b == 0));

//if (op == '^')
//{
//    b = Math.Abs(b);
//    b = Math.Floor(b);
//}
//if (op == '!')
//{
//    a = Math.Abs(a);
//    a = Math.Floor(a);
//}

//resultat = Calculer(a, op, b);
//AfficherResultat(a, op, resultat, b);

//while (!stopCalcul)
//{
//    a = resultat;

//    do
//    {
//        Console.WriteLine("Saisir l'opérateur");

//    } while (!char.TryParse(Console.ReadLine(), out op) || !listOp.Contains(op));

//    if (op == '=')
//    {
//        stopCalcul = true;
//    }
//    else
//    {
//        if (op is not ('s' or '!'))
//        {
//            do
//            {
//                Console.WriteLine("Saisir la 2nde valeur");

//            } while (!double.TryParse(Console.ReadLine(), out b) || (op == '/' && b == 0));
//        }
//        if (op == '^')
//        {
//            b = Math.Abs(b);
//            b = Math.Floor(b);
//        }
//        else if (op == '!')
//        {
//            a = Math.Abs(a);
//            a = Math.Floor(a);
//        }

//        resultat = Calculer(a, op, b);
//        AfficherResultat(a, op, resultat, b);
//    }
//}

/////////////////////////////////////////////////////// Extraction de chaine de caracteres

//string t;
//int k, j;

//t = "Les framboises sont perchées sur le tabouret de mon grand-père.";
//int nombreLettre = t.Count();
//do
//{
//    do
//    {
//        Console.Write("Saisir un positif ");
//    } while (!int.TryParse(Console.ReadLine(), out k) || k > nombreLettre);
//    do
//    {
//        Console.Write("Saisir un positif ");
//    } while (!int.TryParse(Console.ReadLine(), out j) || j > nombreLettre);
//} while (k > j);

//for (int i = k; i < j; i++)
//{
//    c += t[i];
//}
//Console.WriteLine(c);

///////////////////////////////////////////////////// Extraction Sans Concatenation de chaines de caractères

//using System.Text;

//static void ExtractionBis()
//{

//    string t;

//    Console.WriteLine("quelle est votre phrase ? ");
//    t = Console.ReadLine();

//    string u;
//    int index_1;
//    int index_2;
//    StringBuilder sb;


//    do
//    {
//        Console.WriteLine("index 1 ?");
//    } while (!int.TryParse(Console.ReadLine(), out index_1));

//    do
//    {
//        Console.WriteLine("index 2 ?");
//    } while (!int.TryParse(Console.ReadLine(), out index_2));


//    sb = new StringBuilder("", index_2);

//    for (int i = index_1; i < index_2; i++)
//    {
//        sb.Insert(i - index_1, t[i]);
//    }


//    Console.WriteLine(sb);

//}



//////////////////////////////////////////////// Substitution sans Replace

//private static void SubSelect(out String chaine, out char i, out char j)
//{
//    Console.WriteLine("\nPhrase: ");
//    chaine = Console.ReadLine();

//    do
//    {
//        Console.WriteLine("\nPremière indice : ");
//    } while (!Char.TryParse(Console.ReadLine(), out i));

//    do
//    {
//        Console.WriteLine("\nSecond indice : ");
//    } while (!Char.TryParse(Console.ReadLine(), out j));
//}

//private static void SubWithoutReplace()
//{
//    String res = "";
//    SubSelect(out String chaine, out char i, out char j);

//    foreach (var x in chaine)
//    {
///res += ( x == i ? j : x );
//        if (x == i)
//        {
//            res += j;
//        }
//        else res += x;
//    }
//    Console.WriteLine(res);
//}


///////////////////////////////////////////// Extension ( avec un Split qui sépare une chaine de caractère en deux ( et supprime ici le point ) et utilise un tableau )

//String phrase, extention = ".";
//do
//{
//    Console.Write("Entrez un nom de fichier : ");
//    phrase = Console.ReadLine();
//} while (!phrase.Contains('.'));

//String[] div = phrase.Split('.');
//extention += div.Last();
//Console.WriteLine(extention);


/////////////////////////////////////////////////////// Si on veut le nom du fichier

//string fichier = "test.tg.tre.exe";
//Console.WriteLine(fichier.Substring(0, fichier.LastIndexOf('.')));
//Console.WriteLine(fichier.Substring(fichier.LastIndexOf('.')));


///////////////////////////////////////////// Expression Arithmétique