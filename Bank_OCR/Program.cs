using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OCR
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Selection du fichier
            OpenFileDialog fileDialog = new OpenFileDialog();
            ClassOCR oCR = new ClassOCR();

            fileDialog.Filter = "Fichier Texte (*.TXT)|*.TXT";
            fileDialog.Multiselect = false;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader fileAccountNumber = new StreamReader(fileDialog.FileName))
                {
                    string LigneAccountNumber;
                    int iCPTLigne = 0;

                    while ((LigneAccountNumber = fileAccountNumber.ReadLine()) != null)
                    {
                        if (iCPTLigne < 3)
                        {
                            oCR.tabAccountNumber[iCPTLigne] = LigneAccountNumber.ToCharArray();
                            iCPTLigne++;
                        }
                        else
                        {
                            iCPTLigne = 0;
                        }
                    }
                }

            }








            //for (int iNumber = 0; iNumber < oCR.tabAccountNumber.Length; iNumber++)
            //{
            //    for (int iColumnAccountNumber = 0; iColumnAccountNumber < oCR.tabAccountNumber[0].Length; iColumnAccountNumber++)
            //    {
            //        oCR.tabAccountNumber[0][ligne, iColumnAccountNumber] = 

            //        oCR.tabAccountNumber[0][i,]
            //        Console.WriteLine(oCR.tabAccountNumber[0]);
            //    }
            //}




            //for (int iNbreDigits = 0; iNbreDigits < TabNumCompte.GetUpperBound(0); iNbreDigits++)
            //{
            //    Console.WriteLine(TabNumCompte.GetUpperBound(0).ToString());
            //    for (int i = 0; i < length; i++)
            //    {
            //        for (int i = 0; i < length; i++)
            //        {

            //        }
            //    }
            //}

            //Console.WriteLine(oCR.tabBaseOCR[0]);

            Console.ReadLine();

        }
    }
}
