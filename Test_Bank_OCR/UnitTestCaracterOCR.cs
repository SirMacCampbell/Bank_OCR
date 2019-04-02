using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OCR
{
    [TestClass]
    public class UnitTestCaracterOCR
    {
        [TestMethod]
        public void TestCaractere_0()
        {
            //Arrange
            ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {'*', ' ', '*'},
                                                 {'*', '*', '*'}};

            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual("010101111", Verif, true);
        }

        [TestMethod]
        public void TestCaractere_1()
        {
            //Arrange
            ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', ' ', ' '},
                                                 {' ', ' ', '*'},
                                                 {' ', ' ', '*'}};

            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual("000001001", Verif, true);
        }

        [TestMethod]
        public void TestCaractere_2()
        {
            //Arrange
            ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {' ', '*', '*'},
                                                 {'*', '*', ' '}};
            
            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual("010011110", Verif, true);
        }

        [TestMethod]
        public void TestCaractere_3()
        {
            //Arrange
            ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {' ', '*', '*'},
                                                 {' ', '*', '*'}};
            
            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual("010011011", Verif, true);
        }

        [TestMethod]
        public void TestCaractere_4()
        {
            //Arrange
            ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', ' ', ' '},
                                                 {'*', '*', '*'},
                                                 {' ', ' ', '*'}};
            
            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual("000111001", Verif, true);
        }

        [TestMethod]
        public void TestCaractere_5()
        {
            //Arrange
            ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {'*', '*', ' '},
                                                 {' ', '*', '*'}};
            
            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual("010110011", Verif, true);
        }

        [TestMethod]
        public void TestCaractere_6()
        {
            //Arrange
            ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {'*', '*', ' '},
                                                 {'*', '*', '*'}};

            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual("010110111", Verif, true);
        }

        [TestMethod]
        public void TestCaractere_7()
        {
            //Arrange
            ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {' ', ' ', '*'},
                                                 {' ', ' ', '*'}};

            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual("010001001", Verif, true);
        }

        [TestMethod]
        public void TestCaractere_8()
        {
            //Arrange
            ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {'*', '*', '*'},
                                                 {'*', '*', '*'}};

            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual("010111111", Verif, true);
        }

        [TestMethod]
        public void TestCaractere_9()
        {
            //Arrange
            ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {'*', '*', '*'},
                                                 {' ', '*', '*'}};
            
            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual("010111011", Verif, true);
        }

    }

    class UnitTestSuiteOCR
    {
        [TestMethod]
        public void TestSuite_0()
        {
            //Préparation
            char[][,] TabNumCompte = new char[9][,];



            //Action

            //Vérification

        }
    }














}
