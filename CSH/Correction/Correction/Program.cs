// See https://aka.ms/new-console-template for more information

// Correction
//
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