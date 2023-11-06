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
//} while (i >= 9 |||| j >= 9);

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

// Eco-conception a Revoir avec un booléen qui renvoie vrai ou faux
//static void Echec() 
//{
//    int i, j, i2, j2, piece;
//    do
//    {
//        Console.WriteLine("0 = cavalier\r\n1 = Tour\r\n2 = Fou\r\n3 = Dame\r\n4 = Roi \r\n" +
//            "Quelle pièce souhaitez-vous deplacer ?");


//    } while (!int.TryParse(Console.ReadLine(), out piece) && (piece > 4));


//    //Demande des valeurs 
//    do
//    {
//        Console.WriteLine("Coordonnée de i ?");
//        i = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Coordonnée de j ?");
//        j = Convert.ToInt32(Console.ReadLine());
//    } while (i >= 9 || j >= 9);

//    do
//    {
//        Console.WriteLine("Quelle Coordonnée voulez-vous atteindre en i ?");
//        i2 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Quelle Coordonnée voulez-vous atteindre en j ?");
//        j2 = Convert.ToInt32(Console.ReadLine());
//    } while (i2 >= 9 || j2 >= 9);

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
//    if (Math.Abs(i2 - i) == 2 & Math.Abs(j2 - j) == 1 || Math.Abs(i2 - i) == 1 & Math.Abs(j2 - j) == 2)
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
//    if ((i2 == i) || (j2 == j))
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
//    if ((i + j) == (i2 + j2) || ((Math.Abs(i + j) - Math.Abs(i2 + j2)) % 2 == 0) & Math.Abs(i2 - i) == Math.Abs(j2 - j))
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
//    if (((i2 == i) || (j2 == j)) || (i + j) == (i2 + j2) || ((Math.Abs(i + j) - Math.Abs(i2 + j2)) % 2 == 0) & Math.Abs(i2 - i) == Math.Abs(j2 - j))
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

//static void Heuremin()
//{
//    Double heure, heure2, minute, minute2, calcdebut, calcfin, temps, heurecalc, mincalc;

//    do
//    {
//        Console.WriteLine("Heure de Début ?");

//    } while (!double.TryParse(Console.ReadLine(), out heure));

//    do
//    {
//        Console.WriteLine("Combien de Minutes ?");

//    } while (!double.TryParse(Console.ReadLine(), out minute));

//    do
//    {
//        Console.WriteLine("Heure de Fin ?");

//    } while (!double.TryParse(Console.ReadLine(), out heure2));

//    do
//    {
//        Console.WriteLine("Combien de Minutes à la fin ?");

//    } while (!double.TryParse(Console.ReadLine(), out minute2));

//    if ( heure < heure2)
//    {
//        calcdebut = (heure * 60) + minute;
//        calcfin = (heure2 * 60) + minute2;
//        temps = (calcfin - calcdebut);
//        heurecalc = Math.Round(temps / 60 , 0);
//        mincalc = (temps % 60);
//        Console.WriteLine("Le temps écoulé est de " + heurecalc + " heure(s)" + " et " + mincalc + " minute(s)");
//    } else
//    {
//        Console.WriteLine("L'heure de depart est plus élevé que l'heure de fin");
//    }
//}

//Heuremin();


//3.12

//using Microsoft.VisualBasic;
//using System.Runtime.Serialization;

//static void datesuivant()
//{
//    Double jour, mois, annee, jourmax, moismax, joursui, moissui, anneesui;
//    //Double[] moisbis;
//    //moisbis = new double[]{4, 6, 9, 11}; // Tentative de Liste
//    jourmax = 31;
//    moismax = 12;

//    do
//    {
//        Console.WriteLine("Jour ?");

//    } while (!double.TryParse(Console.ReadLine(), out jour) || (jour > jourmax) || (jour < 0));

//    do
//    {
//        Console.WriteLine("Mois ? (en Chiffres)");
//    } while (!double.TryParse(Console.ReadLine(),out mois) || (mois > moismax) || (mois < 0));

//    do
//    {
//        Console.WriteLine("Annee ?");
//    } while (!double.TryParse(Console.ReadLine(), out annee));

//    joursui = jour++;
//    moissui = mois;
//    anneesui = annee;

//// Sommes-nous en Fevrier ( Années bissextiles )
//if ((mois == 2) & (annee % 4 == 0) || (annee % 400 == 0) && (annee % 100 != 0))
//{
//    jourmax = 29;
//}
//else // Annees non bissextiles
//{
//    jourmax = 28;
//}

//    // Mois a 30 jours ?
//    if (mois == 4 || mois == 6 || mois == 9 |||| mois == 11){
//        jourmax = 30;
//    }


//    //Si on est le 31 Decembre
//    if ((joursui >= jourmax) & (moissui >= moismax))
//    {
//        joursui = 01;
//        moissui = 01;
//        anneesui = (annee + 1);
//    } 
//    else if ((joursui >= jourmax) & (moissui <= moismax)) // Si on est le 31 de n'importe quelle mois
//    {
//        joursui = 01;
//        moissui = mois++;
//        anneesui = annee;
//    }
//    else // Cas restants
//    {
//        moissui = mois; 
//    }

//    Console.WriteLine(joursui + "/" + moissui + "/" + anneesui);
//}

//datesuivant();


//3.13 et 3.14

//static void Intervalles()
//{
//    Double a, b, x;
//    //Controle de Saisie des valeurs a, b et x

//    do
//    {
//        Console.WriteLine("valeur de a ?");
//    } while (!Double.TryParse(Console.ReadLine(), out a));

//    do
//    {
//        Console.WriteLine("valeur de b ?");
//    } while (!Double.TryParse(Console.ReadLine(), out b) || (b < a));

//    do
//    {
//        Console.WriteLine("valeur de x ?");
//    } while (!Double.TryParse(Console.ReadLine(), out x));

//    if (x >= a && x <= b)
//    {
//        Console.WriteLine("La valeur " + x + " Appartient à l'intervalle " + "[" + a + "," + b + "]");
//    }
//    else
//    {
//        Console.WriteLine("La valeur " + x + " n'appartient pas à l'intervalle " + "[" + a + "," + b + "]");
//    }

//}

//Intervalles();

//3.15 et 3.16

//static void Rectangles()
//{

//    Double xHautGauche, yHautGauche, xBasDroite, yBasDroite, x, y;

//    do
//    {
//        Console.WriteLine("Valeur de xHautGauche ?");
//    } while (!Double.TryParse(Console.ReadLine(), out xHautGauche));

//    do
//    {
//        Console.WriteLine("Valeur de yHautGauche ?");
//    } while (!Double.TryParse(Console.ReadLine(), out yHautGauche));

//    do
//    {
//        Console.WriteLine("Valeur de xBasDroite ?");
//    } while (!Double.TryParse(Console.ReadLine(), out xBasDroite) || (xBasDroite < xHautGauche));

//    do
//    {
//        Console.WriteLine("Valeur de yBasDroite ?");
//    } while (!Double.TryParse(Console.ReadLine(), out yBasDroite) || (yBasDroite > yHautGauche));

//    do
//    {
//        Console.WriteLine("Valeur x ?");
//    } while (!Double.TryParse(Console.ReadLine(), out x));

//    do
//    {
//        Console.WriteLine("Valeur de y ?");
//    } while (!Double.TryParse(Console.ReadLine(), out y));

//    if ((x >= xHautGauche && x <= xBasDroite) && (y >= yBasDroite && y <= yHautGauche))
//    {
//        Console.WriteLine("Le Point (" + x + "," + y + ")" + " se Trouve dans le Rectangle de Coordonnées " + "(" + xHautGauche + "," + yHautGauche + ")" + "(" + xHautGauche + "," + yBasDroite + ")" + "(" + xBasDroite + "," + yBasDroite + ")" + "(" + xBasDroite + "," + yHautGauche + ")");
//    }
//    else
//    {
//        Console.WriteLine("Le Point ne se trouve pas dans le rectangle et tu n'auras pas les coordonnées");
//    }

//}
//Rectangles();


//4.4
//static void Comptefor()
//{
//    Double x, a;
//    do
//    {
//        Console.WriteLine("Saisissez une valeur : ");
//    } while (!Double.TryParse(Console.ReadLine(), out x) | (x < 0));

//    //Boucle for
//       for (a = 0; a <= 1; a--)
//        {
//            Console.Write(a + ",");
//        }
//    for (a = 0; a <= x; a--)
//    {
//        Console.Write(a + ".");
//    }
//}
//Comptefor();


//static void Comptewhile()
//{
//    Double x, a;
//    a = 0;
//    do
//    {
//        Console.WriteLine("Saisissez une valeur : ");
//    } while (!Double.TryParse(Console.ReadLine(), out x) | (x < 0));

//    //Boucle While
//    while (a < x)
//    {
//        Console.Write(a + ",");
//        a++;
//    }
//    while (a == x)
//    {
//        Console.Write(a + ".");
//        a++;
//    }
//}
//Comptewhile();

// PAS BON
//static void Compteforeach()
//{
//    int x;
//    List<int> valeurs = new List<int>();
//    do
//    {
//        Console.WriteLine("Saisissez une valeur : ");
//    } while (!int.TryParse(Console.ReadLine(), out x) | (x < 0));

//    foreach (int y in valeurs)
//    {
//        valeurs.Add(y);
//        Console.Write(valeurs[y]);
//    }
//}
//Compteforeach();



//4.5 

//BOUCLE FOR

//static void Factoriellefor()
//{
//    Double x, a, y ;
//    y = 1;
//    // Ajout des Valeurs et verification 
//    do
//    {
//        Console.WriteLine("Saisissez une valeur : ");
//    } while (!Double.TryParse(Console.ReadLine(), out x) | (x < 0));

//        for (a = 0; a < 2; a++)
//        {
//        Console.WriteLine(a + "! = 1");
//        }
//        for ( a = 2; a <= x; a++)
//    {
//        y *= a ;
//        Console.WriteLine(a + "! = " + y);
//    }
//}

//Factoriellefor();

//BOUCLE WHILE
//static void Factoriellewhile()
//{
//    Double x,a,y ;
//    a = 0;
//    y = 1;
//    do
//    {
//        Console.WriteLine("Saisissez une valeur : ");
//    } while (!Double.TryParse(Console.ReadLine(), out x) | (x < 0));

//    while (a < 2)
//    {
//        Console.WriteLine(a + "! = 1");
//        a++;
//    }
//    while (a <= x)
//    {
//        y *= a;
//        Console.WriteLine(a + "! = " + y);
//        a++;
//    }
//}
//Factoriellewhile();


//Boucle Foreach



// PAS FAIT
//static void FactoriseForeach()
//{
//    Double x;
//    do
//    {
//        Console.WriteLine("Valeur de x :");
//    } while (!Double.TryParse(Console.ReadLine(), out x));

//    foreach ()
//}

//FactoriseForeach();


//4.6

//static void TabMul()
//{
//    Double x,a, result;
//    a = 0;
//    do
//    {
//        Console.WriteLine("Saisissez une valeur");
//    } while (!Double.TryParse(Console.ReadLine(), out x));  

//    while (a <= 10)
//    {
//        result = a * x;
//        Console.WriteLine(a + " x " + x + " = " + result);
//        a++;
//    }
//}
//TabMul();

//4.7

//static void TabMul2()
//{

//    int[,] tables = new int[10, 10];
//    for (int i = 1; i < 11; i++)
//    {
//        for (int j = 1; j < 11; j++)
//        {
//            tables[i - 1, j - 1] = i * j;
//            Console.Write("|" + i * j + "|");
//        }
//        Console.WriteLine();
//    }
//}

//TabMul2();


//4.8

//static void Puissance()
//{
//    Double b, n, resultat;
//    do
//    {
//        Console.WriteLine("Valeur de b ?");
//    } while (!Double.TryParse(Console.ReadLine(), out b));

//    do
//    {
//        Console.WriteLine("Valeur de n ?");
//    } while (!Double.TryParse(Console.ReadLine(), out n) || (n < 0));

//    resultat = Math.Pow(b, n);
//    Console.WriteLine(b + "^" + n + " = " + resultat);
//}

//Puissance();


// Joli Carré

//static void Jolicarre()
//{
//    int n,x,y;
//    x = 0;


//    do
//    {
//        Console.WriteLine("Valeur de n");
//    } while (!int.TryParse(Console.ReadLine(), out n) || (n < 0) );
//    while (x < n)
//    {
//        y = 0;
//        Console.Write("\n");
//        while (y < n)
//        {
//            Console.Write(" x ");
//            y++;
//        }
//        x++;
//    }
//}
//Jolicarre();


//Calculatrice le Retour

//static void Calculette()
//{
//    String operation;
//    Double resultat, operande, a, init;
//    Char operateur;
//    operande = 0;
//    operateur = ' ';
//    // Valeur Initiale
//    do
//    {
//        Console.WriteLine("Valeur initial ?");
//    } while (!Double.TryParse(Console.ReadLine(), out resultat));

//    // Switch pour les operations

//    //Boucles pour continuer le calcul tant que '=' n'est pas saisi
//    while (operateur != '=')
//    {
//        init = resultat;
//        Console.WriteLine("Que faisons-nous ?\n  $ pour faire une puissance \n V0 pour faire la racine carré \n !0 pour faire la factorielle \n (= +Chiffres pour arreter )");
//        operation = Console.ReadLine();
//        operateur = operation[0];
//        operande = Convert.ToInt32(operation.Substring(1));
//        switch (operateur)
//        {
//            case '+':
//                resultat += operande;
//                break;
//            case '-':
//                resultat -= operande;
//                break;
//            case '*':
//                resultat *= operande;
//                break;
//            case '/':
//                if (operateur != 0)
//                {
//                    resultat /= operande;
//                }
//                else
//                {
//                    Console.WriteLine("Impossible de diviser par 0");
//                }
//                break;
//            case '$':
//                resultat = Math.Pow(resultat, operande);
//                break;
//            default:
//                Console.WriteLine("");
//                break;
//        }

//        if (operation == "V0")
//        {
//            resultat = Math.Sqrt(resultat);
//        }
//        else if (operation == "!0")
//        {
//            a = 1;
//            while (a < init)
//            {
//                resultat *= a;
//                a++;
//            }
//        }

//        Console.WriteLine(resultat);

//    }


//}

//Calculette();


//5.1
//static void Stringg()
//{

//    String chaine;
//    chaine = "Les Framboises sont perchées sur le tabouret de mon grand-père";
//    foreach (char c in chaine)
//    {
//        Console.WriteLine(c);
//    }
//}
//Stringg();


//5.2

//static void leString()
//{
//    String t;
//    int i, j;

//    t = "Je suis une phrase très longue pour faire des tests qui sont vraiment très cool (non)";
//    do
//    {
//        Console.WriteLine("Position de caractère de départ ?");
//    } while (!int.TryParse(Console.ReadLine(), out i));

//    do
//    {
//        Console.WriteLine("Position du caractère de fin ?");
//    } while (!int.TryParse(Console.ReadLine(), out j) || (j < i));


//    foreach (char c in t)
//    {
//        while (i <= j)
//        {
//            Console.Write(t[i-1]);
//            i++;
//        }
//    }

//}
//leString();


//5.3 ( pas réussi )

//using System.Text;

//static void Elstring()
//{
//    String t;
//    int i, j;
//    StringBuilder sb = new(" ");

//    Console.WriteLine("Texte ?");
//    t = Console.ReadLine();
//    sb.Insert(0, t);

//    do
//    {
//        Console.WriteLine("Position de caractère de départ ?");
//    } while (!int.TryParse(Console.ReadLine(), out i));

//    do
//    {
//        Console.WriteLine("Position du caractère de fin ?");
//    } while (!int.TryParse(Console.ReadLine(), out j) || (j < i));


//}

//Elstring();


// 5.4

//using System.Text;

//static void Replace()
//{
//    String t;
//    Char a, b;
//    StringBuilder sb = new(" ");

//    Console.WriteLine("Texte ?");
//    t = Console.ReadLine();
//    sb.Insert(0, t);

//    do
//    {
//        Console.WriteLine("Lettre a remplacé ?");
//    } while (!Char.TryParse(Console.ReadLine(), out a));

//    do
//    {
//        Console.WriteLine("Remplacé par quelle lettre ?");
//    } while (!Char.TryParse(Console.ReadLine(), out b));

//    sb.Replace(a, b);
//    Console.WriteLine(sb);
//}

//Replace();

//6.4 

//static void Tab()
//{
//    int[] T = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//    foreach (int i in T)
//        Console.Write(i);
//}
//Tab();


//6.5 //6.6
//static void Tab2()
//{
//    int[] T;
//    int somme;
//    somme = 0;
//    T = new int[10];
//    for (int i = 0; i < T.Length; i++)
//    {
//        T[i] = i + 1;
//    }
//    foreach (int k in T)
//    {
//        Console.WriteLine(k);
//    }

//    for (int j = 0; j < T.Length; j++)
//    {
//        somme += T[j];
//    }
//    Console.Write("Somme du Tableau : " + somme);

//}
//Tab2();


//6.7

//static void Tabask()
//{
//    int[] T = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//    int p;

//    do
//    {
//        Console.WriteLine("Valeur ?");
//    } while (!int.TryParse(Console.ReadLine(), out p));

//    foreach (int i in T)
//    {
//        if (p == i)
//        {
//            Console.WriteLine("La Valeur se trouve dans le Tableau");
//        }
//    }
//}
//Tabask();

//6.8

static void permutab()
{
    int[] T = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] T2;
    T2 = new int[10];
    T2[0] = T[T.Length - 1];
    for (int i = 1; i < T2.Length; i++)
    {
        T2[i] = T[i - 1];
    }
    foreach (int j in T2)
    {
        Console.WriteLine(j);
    }

}
permutab();


//6.9 

//static void permutab2()
//{
//    int[] T = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//}

//permutab2();