using System.Diagnostics;
using System.Numerics;
using System.Reflection.Metadata;
using TestUnitaire;

namespace Testprojetunitaire
{
    public class Tests
    {
        public const string DebitMontantSuperieurSoldeMessage = "Le montant à débiter est supérieur au solde";
        public const string DebitMontantNegatifSoldeMessage = "Le montant à débiter est négatif";

        [SetUp]
        public void Setup()
        {
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
            double soldeDepart = 11.99;
            double montantDebite = 4.55;
            double attendu = 7.44;
            Compte compte = new Compte("Mr Toto", soldeDepart);
            // Act
            compte.Debit(montantDebite);
            // Assert
            double soldeActuel = compte.Solde;
            Assert.AreEqual(attendu, soldeActuel, 0.001, "Compte mal débité");
        }

        [Test]
        public void Debit_MontantNegatif()
        {
            // Arrange
            double soldeDepart = 11.99;
            double montantDebite = -4;
            Compte compte = new Compte("Mr Toto", soldeDepart);
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
            double soldeDepart = 11.99;
            double montantDebite = -44.55;
            Compte compte = new Compte("Mr Toto", soldeDepart);
            // Act et Assert
            if (montantDebite > soldeDepart)
            {
                throw new ArgumentOutOfRangeException("montant", montantDebite,
               DebitMontantSuperieurSoldeMessage);
            }

            Assert.Throws<ArgumentOutOfRangeException>(() =>
           compte.Debit(montantDebite));
        }

        
    }
}