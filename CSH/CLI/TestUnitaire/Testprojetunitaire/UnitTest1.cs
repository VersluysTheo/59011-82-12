using System.Diagnostics;
using System.Numerics;
using System.Reflection.Metadata;
using TestUnitaire;

namespace Testprojetunitaire
{
    public class Tests
    {
        public const string DebitMontantSuperieurSoldeMessage = "Le montant � d�biter est sup�rieur au solde";
        public const string DebitMontantNegatifSoldeMessage = "Le montant � d�biter est n�gatif";
        Compte compte;
        double SoldeDepart;

        [SetUp]
        public void Setup()
        {
            double SoldeDepart = 11.99;
            compte = new Compte("Mr Toto",SoldeDepart) ;
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }


        [Test]
        public void Debit_MontantValide()
        {
            // Arrange
            double montantDebite = 4.55;
            double attendu = 7.44;
            // Act
            compte.Debit(montantDebite);
            // Assert
            double soldeActuel = compte.Solde;
            Assert.AreEqual(attendu, soldeActuel, 0.001, "Compte mal d�bit�");
        }

        [Test]
        public void Debit_MontantNegatif()
        {
            // Arrange
            double montantDebite = -4;
            // Act et Assert

            if (montantDebite < 0)
            {
                throw new ArgumentOutOfRangeException("montant", montantDebite,
               DebitMontantNegatifSoldeMessage);
            }
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            compte.Debit(montantDebite));
        }

            [Test]
        public void Debit_MontantSuperieurSolde()
        {
            // Arrange
            double montantDebite = -44.55;
            // Act et Assert
            if (montantDebite > SoldeDepart)
            {
                throw new ArgumentOutOfRangeException("montant", montantDebite,
               DebitMontantSuperieurSoldeMessage);
            }

            Assert.Throws<ArgumentOutOfRangeException>(() =>
           compte.Debit(montantDebite));
        }

        
    }
}