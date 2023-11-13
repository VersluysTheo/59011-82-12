namespace SpaceInvader
{
    internal class Program
    {
        static void Main()
        {
            Space grille1 = new(10, 20);
            grille1.Afficher();
            Invader invader1 = new();
            invader1.AfficherInvader();
        }
    }
}