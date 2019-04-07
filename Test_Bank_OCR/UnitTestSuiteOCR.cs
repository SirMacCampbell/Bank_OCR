using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace OCR
{
    [TestClass]
    public class UnitTestSuiteOCR
    {
        ClassOCR classOCR = new ClassOCR();
        char[][,]TabNumCompte = new char[9][,];

        [TestMethod]
        //Préparation
        public void TestSuite_0()
        {
            for (int iNbreDigits = 0; iNbreDigits < TabNumCompte.GetUpperBound(0); iNbreDigits++)
            {
                Debug.Print(TabNumCompte.GetUpperBound(0).ToString());


                //for (int i = 0; i < length; i++)
                //{
                //    for (int i = 0; i < length; i++)
                //    {

                //    }
                //}
            }
        }

        
        


        //Action

        //Vérification

    }
}
