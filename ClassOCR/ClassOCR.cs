using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    public class ClassOCR
    {
        //    _  _     _  _  _  _  _ 
        //  | _| _||_||_ |_   ||_||_|
        //  ||_  _|  | _||_|  ||_| _|

        string[] tabBaseOCR;
        public char[][,] tabAccountNumber = new char[9][,];

        public ClassOCR()
        {
            tabBaseOCR = new string[] { "010101111", "000001001", "010011110", "010011011", "000111001", "010110011", "010110111", "010001001", "010111111", "010111011" };

            for (int iNbreDigits = 0; iNbreDigits < tabAccountNumber.GetUpperBound(0); iNbreDigits++)
            {
                tabAccountNumber[iNbreDigits] = new char[3, 3];
            }
        }

        public char TranslateCharacter(string[] character)
        {
            char toto = ' ';

            return toto;
        }

        public string getValeurBaseOCR(int valeurRecherchee)
        {
            return tabBaseOCR[valeurRecherchee];
        }

        public string AnalyseCharacter(char[,] tabCharacter)
        {
            string sConversion = "";

            for (int iLigne = 0; iLigne <= tabCharacter.GetUpperBound(0); iLigne++)
            {
                for (int iColonne = 0; iColonne <= tabCharacter.GetUpperBound(1); iColonne++)
                {
                    sConversion += (tabCharacter[iLigne, iColonne].ToString() == "*")?"1":"0";
                }
            }

            return sConversion;
        }
    }

}
