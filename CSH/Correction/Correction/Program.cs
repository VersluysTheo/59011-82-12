// See https://aka.ms/new-console-template for more information

// Correction 
// ECHEC


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



// HEURES

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


// Compte a Rebours

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

//FACTORIELLE

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


// Table de Multiplication ( en For car on connait le nombre d'itérations 

//int nbChoisi;

//do
//{
//    Console.WriteLine("Choisir un nb et vous aurez sa table de multiplication : ");
//} while (!int.TryParse(Console.ReadLine(), out nbChoisi));

//for (int i = 0; i < 11; i++)
//{
//    Console.WriteLine(nbChoisi + " * " + i + " = " + (nbChoisi * i));
//}


// Tableaux a double entreé

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