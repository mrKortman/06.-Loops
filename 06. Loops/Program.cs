using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Loops
{
    /* Dit programma vraagt om een getal onder de 100 en 
       laat daar van de tafel op het scherm zien via een loop */

    class Program
    {
        static void Main(string[] args)
        {
            bool blnContinue = true;
            
            //DO WHILE LOOP
            do
            {
                double dblSum = 0;
                double dblMultiplicationTable = 0;

                Console.Clear();
                Console.WriteLine("Geef een getal op onder de 100");
                
                dblMultiplicationTable = Convert.ToDouble(Console.ReadLine());

                if (dblMultiplicationTable < 100)
                {
                    //Console.WriteLine("{0} {1} {2}", var1, var2, var3);
                    //Console.WriteLine(var1 + " " + var2 + " " + var3);

                    Console.WriteLine("Hier onder ziet u de tafel van {0}", dblMultiplicationTable.ToString());

                    // FOR LOOP
                    for (int i = 1; i < 10; i++)
                    {
                        dblSum = i * dblMultiplicationTable;
                        Console.WriteLine("{0} x {1} = {2}", i, dblMultiplicationTable, dblSum);
                    }
                }
                else
                {
                    Console.WriteLine("U heeft een getal boven de 100 opgegeven, probeer het nog eens.");
                }

                Console.WriteLine("Wilt u nog een tafel weergeven ? (j/n)");
                string strContinue = Console.ReadLine();

                // IF STATEMENT
                if (strContinue == "n")
                {
                    blnContinue = false;
                }
            }
            while (blnContinue);
        }
    }
}
