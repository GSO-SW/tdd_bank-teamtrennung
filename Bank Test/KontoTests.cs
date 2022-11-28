using Bank;

namespace Bank_Tests
{
    [TestClass]
    public class KontoTests
    {
        [TestMethod]
        public void Einzahlen_Guthabensteigern()
        {

            //Arrange 

            int startguthaben = 100;
            Konto k1 = new Konto(startguthaben);
            int einzahlungsbetrag = 20;

            int guthaben_soll = startguthaben + einzahlungsbetrag;


            //Act
            k1.Einzahlen(einzahlungsbetrag);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Einzahlen_NegativerBetrag()
        {
            //Arrange
            int startguthaben = 100;
            Konto k1 = new Konto(startguthaben);
            int einzahlungsbetrag = -1;

            int guthaben_soll = startguthaben + einzahlungsbetrag;


            //Act
            k1.Einzahlen(einzahlungsbetrag);

        }


    }
}