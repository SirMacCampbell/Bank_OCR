using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OCR
{
    [TestClass]
    public class UnitTestCaracterOCR
    {
        ClassOCR classOCR = new ClassOCR();

        [TestMethod]
        public void TestCaractere_0()
        {
            //Arrange
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {'*', ' ', '*'},
                                                 {'*', '*', '*'}};

            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual(classOCR.getValeurBaseOCR(0), Verif, true);
        }

        [TestMethod]
        public void TestCaractere_1()
        {
            //Arrange
            //ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', ' ', ' '},
                                                 {' ', ' ', '*'},
                                                 {' ', ' ', '*'}};

            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual(classOCR.getValeurBaseOCR(1), Verif, true);
        }

        [TestMethod]
        public void TestCaractere_2()
        {
            //Arrange
            //ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {' ', '*', '*'},
                                                 {'*', '*', ' '}};
            
            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual(classOCR.getValeurBaseOCR(2), Verif, true);
        }

        [TestMethod]
        public void TestCaractere_3()
        {
            //Arrange
            //ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {' ', '*', '*'},
                                                 {' ', '*', '*'}};
            
            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual(classOCR.getValeurBaseOCR(3), Verif, true);
        }

        [TestMethod]
        public void TestCaractere_4()
        {
            //Arrange
            //ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', ' ', ' '},
                                                 {'*', '*', '*'},
                                                 {' ', ' ', '*'}};
            
            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual(classOCR.getValeurBaseOCR(4), Verif, true);
        }

        [TestMethod]
        public void TestCaractere_5()
        {
            //Arrange
            //ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {'*', '*', ' '},
                                                 {' ', '*', '*'}};
            
            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual(classOCR.getValeurBaseOCR(5), Verif, true);
        }

        [TestMethod]
        public void TestCaractere_6()
        {
            //Arrange
            //ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {'*', '*', ' '},
                                                 {'*', '*', '*'}};

            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual(classOCR.getValeurBaseOCR(6), Verif, true);
        }

        [TestMethod]
        public void TestCaractere_7()
        {
            //Arrange
            //ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {' ', ' ', '*'},
                                                 {' ', ' ', '*'}};

            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual(classOCR.getValeurBaseOCR(7), Verif, true);
        }

        [TestMethod]
        public void TestCaractere_8()
        {
            //Arrange
            //ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {'*', '*', '*'},
                                                 {'*', '*', '*'}};

            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual(classOCR.getValeurBaseOCR(8), Verif, true);
        }

        [TestMethod]
        public void TestCaractere_9()
        {
            //Arrange
            //ClassOCR classOCR = new ClassOCR();
            char[,] character = new char[3, 3] { {' ', '*', ' '},
                                                 {'*', '*', '*'},
                                                 {' ', '*', '*'}};
            
            //Act
            string Verif = classOCR.AnalyseCharacter(character);
            //Assert
            Assert.AreEqual(classOCR.getValeurBaseOCR(9), Verif, true);
        }

    }














}
