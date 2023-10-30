// See https://aka.ms/new-console-template for more information
//1.1
// Exo1
//Affichage texte

//Console.WriteLine("Votre Nom ?");
//String s = Console.ReadLine();
//Console.WriteLine("Bonjour " + s);

//Exo 2
//Affichage valeur numerique

//Console.Write("Votre Age ?");
//String valeur = Console.ReadLine();
//Int convert = Convert.ToInt32(valeur);
//Console.WriteLine("Vous avez " + convert + " ans");

//1.2
// Exo 3
// Calcul Somme et Quotient de deux valeurs

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
//    Console.WriteLine("Impossible");
//}

//1.3
//Exo4
//Converti en decimal

//Console.Write("Ecrit une valeur flottante : ");
//Decimal convert = Convert.ToDecimal(Console.ReadLine());
//Console.WriteLine(convert);

//Exo5
//Moyenne de 3 valeurs

//decimal convert, convert2, convert3;
//Console.Write("Valeur 1 ? ");
//convert = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Valeur 2 ? ");
//convert2 = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Valeur 3 ? ");
//convert3 = Convert.ToDecimal(Console.ReadLine());
//Console.WriteLine("Moyenne : " +(convert + convert2 + convert3) / 3);


//Exo6
// Calcul d'une aire

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
//Converti  a en Unicode

//Char var = 'a';
//int Al = Convert.ToUInt16(var);
//Console.WriteLine(Al);


//Exo 8 
//Texte en Majuscules

//Console.WriteLine("Ecrivez un texte : ");
//Console.WriteLine(Console.ReadLine().ToUpper());


//2

//Exo 1
//Unicode

//Char successeur, convert;
//int unicode, unisucc;
//Console.WriteLine("lettre ?");
//convert = Convert.ToChar(Console.ReadLine()[0]);
//unicode = Convert.ToUInt16(convert);
//unisucc = (unicode + 1);
//successeur = (Char)((int)convert + 1);
//Console.WriteLine(convert + " " + unicode + " " + successeur + " " + unisucc);


//Exo 2
// Convert Unicode dans une liste

//List<int> nombre = new List<int>()
// {'1','2','3','4','5','6','7','8','9'};
//foreach (var item in nombre)
//{
//    int uni = Convert.ToUInt16(item);
//    Console.WriteLine(uni);

//Exo 3
// Marchandise et Carton 

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
// Verification Majeur / Mineur

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
//Valeur Absolue

//Double convert, absolute;
//Console.Write("Valeur ?");
//convert = Convert.ToDouble(Console.ReadLine());
//absolute = Math.Abs(convert);
//Console.WriteLine(absolute);


//3.3
//Note

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
//Franchise

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
//Valeurs Distinctes

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
//Trouvez le plus petit

//String valeur;
//Double valeur1, valeurmin;
//List <double> listevaleur = new List<double>();

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine("Valeur "  + (i+1));
//    do
//    {
//        valeur = Console.ReadLine();
//    } while (!double.TryParse(valeur, out valeur1));
//    listevaleur.Add(valeur1);
//}
//valeurmin = listevaleur.Min();
////valeurmin = Math.Min(valeur1, Math.Min(valeur2, valeur3));
//Console.WriteLine("Le Plus petit nombre est : " + valeurmin);



//3.7
//Calculatrice

//using System.ComponentModel.DataAnnotations;
//using System.Runtime.Intrinsics.Arm;

//Double a, b, resultat;
//char op;
//resultat = 0;

//do
//{
//    Console.WriteLine("Valeur de a ?");
//} while (!double.TryParse(Console.ReadLine(), out a));

//do
//{
//    Console.WriteLine("Valeur de b ?");
//} while (!double.TryParse(Console.ReadLine(), out b));

//Console.WriteLine("Signe ?");
//op = Console.ReadLine()[0];
//switch (op)
//{
//    case '+':
//        resultat = (a + b);
//        break;
//    case '-':
//        resultat = (a - b);
//        break;
//    case '*':
//        resultat = (a * b);
//        break;
//    case '/' :
//        if (b != 0)
//        {
//            resultat = (a / b);
//        } else
//        {
//            Console.WriteLine("Impossible de diviser par 0");
//        }
//        break;
//    default:
//        Console.WriteLine("Pas de Signe valable selectionné");
//        break;
//}
//Console.WriteLine(resultat);



//3.8

//Demande de couleur de la Case 
//int i, j;

//do
//{
//    do
//    {
//        Console.WriteLine("Coordonnées de i ?");
//    } while (!int.TryParse(Console.ReadLine(), out i));
//    do
//    {
//        Console.WriteLine("Coordonnées de j ?");
//    } while ((!int.TryParse(Console.ReadLine(), out j)));
//} while (i >= 9 | j >= 9);

//if ((i + j) % 2 == 0)
//{
//    Console.WriteLine("La case " + "(" + i + "," + j + ") " + "une case Noire");
//}
//else
//{
//    Console.WriteLine("La case " + "(" + i + "," + j + ") " + "une case Blanche");
//}


//3.9 et 3.10

//using System.ComponentModel.Design.Serialization;
//using System.Runtime.InteropServices;

//static void Echec()
//{
//    int i, j, i2, j2, piece;
//    do
//    {
//        Console.WriteLine("0 = cavalier\r\n1 = Tour\r\n2 = Fou\r\n3 = Dame\r\n4 = Roi \r\n" +
//            "Quelle pièce souhaitez-vous deplacer ?");


//    } while (!int.TryParse(Console.ReadLine(), out piece));


//    //Demande des valeurs 
//    do
//    {
//        Console.WriteLine("Coordonnée de i ?");
//        i = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Coordonnée de j ?");
//        j = Convert.ToInt32(Console.ReadLine());
//    } while (i >= 9 | j >= 9);

//    do
//    {
//        Console.WriteLine("Quelle Coordonnée voulez-vous atteindre en i ?");
//        i2 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Quelle Coordonnée voulez-vous atteindre en j ?");
//        j2 = Convert.ToInt32(Console.ReadLine());
//    } while (i2 >= 9 | j2 >= 9);

//    switch (piece)
//    {
//        case 0:
//            Cavalier(i, j, i2, j2);
//            break;
//        case 1:
//            Tour(i, j, i2, j2);
//            break;
//        case 2:
//            Fou(i, j, i2, j2);
//            break;
//        case 3:
//            Dame(i, j, i2, j2);
//            break;
//        case 4:
//            Roi(i, j, i2, j2);
//            break;
//        default:
//            Console.WriteLine("Vous avez Selectionné un chiffre invalide");
//            break;
//    }

//}

//static void Cavalier(int i, int j, int i2, int j2)
//{

//    //Mouvement de cavalier
//    if (Math.Abs(i2 - i) == 2 & Math.Abs(j2 - j) == 1 ^ Math.Abs(i2 - i) == 1 & Math.Abs(j2 - j) == 2)
//    {
//        Console.WriteLine("Le mouvement de " + "(" + i + "," + j + ")" + " a " + "(" + i2 + "," + j2 + ")" + "est possible");
//    }
//    else
//    {
//        Console.WriteLine("Le mouvement de " + "(" + i + "," + j + ")" + " a " + "(" + i2 + "," + j2 + ")" + "n'est pas possible");
//    }
//}


//static void Tour(int i, int j, int i2, int j2)
//{
//    //Mouvement de tour
//    if ((i2 == i) | (j2 == j))
//    {
//        Console.WriteLine("Le mouvement de " + "(" + i + "," + j + ")" + " a " + "(" + i2 + "," + j2 + ")" + "est possible");
//    }
//    else
//    {
//        Console.WriteLine("Le mouvement de " + "(" + i + "," + j + ")" + " a " + "(" + i2 + "," + j2 + ")" + "n'est pas possible");
//    }
//}

//static void Fou(int i, int j, int i2, int j2)
//{
//    //Mouvement de fou
//    if ((i + j) == (i2 + j2) | ((Math.Abs(i + j) - Math.Abs(i2 + j2)) % 2 == 0) & Math.Abs(i2 - i) == Math.Abs(j2 - j))
//    {
//        Console.WriteLine("Le mouvement de " + "(" + i + "," + j + ")" + " a " + "(" + i2 + "," + j2 + ")" + "est possible");
//    }
//    else
//    {
//        Console.WriteLine("Le mouvement de " + "(" + i + "," + j + ")" + " a " + "(" + i2 + "," + j2 + ")" + "n'est pas possible");
//    }
//}

//static void Roi(int i, int j, int i2, int j2)
//{
//    //Movement du roi
//    if (Math.Abs(i2 - i) <= 1 & Math.Abs(j2 - j) <= 1)
//    {
//        Console.WriteLine("Le mouvement de " + "(" + i + "," + j + ")" + " a " + "(" + i2 + "," + j2 + ")" + "est possible");
//    }
//    else
//    {
//        Console.WriteLine("Le mouvement de " + "(" + i + ", " + j + ")" + " a " + "(" + i2 + ", " + j2 + ")" + "n'est pas possible");
//    }
//}

//static void Dame(int i, int j, int i2, int j2)
//{
//    if (((i2 == i) | (j2 == j)) | (i + j) == (i2 + j2) | ((Math.Abs(i + j) - Math.Abs(i2 + j2)) % 2 == 0) & Math.Abs(i2 - i) == Math.Abs(j2 - j))
//    {
//        Console.WriteLine("Le mouvement de " + "(" + i + "," + j + ")" + " a " + "(" + i2 + "," + j2 + ")" + "est possible");
//    }
//    else
//    {
//        Console.WriteLine("Le mouvement de " + "(" + i + ", " + j + ")" + " a " + "(" + i2 + ", " + j2 + ")" + "n'est pas possible");
//    }
//}

//Echec();


//3.11

//Double heure, heure2, minute, minute2;
//List<double> listevaleur = new List<double>();
//listevaleur.Add(1,2);

//do
//{
//    Console.WriteLine("Heure de Début ?");

//} while (!double.TryParse(Console.ReadLine(),out heure));

//do
//{
//    Console.WriteLine("Combien de Minutes ?");

//} while (!double.TryParse(Console.ReadLine(),out minute));

//do
//{
//    Console.WriteLine("Heure de Fin ?");

//} while (!double.TryParse(Console.ReadLine(), out heure2));

//do
//{
//    Console.WriteLine("Combien de Minutes à la fin ?");

//} while (!double.TryParse(Console.ReadLine(), out minute2));