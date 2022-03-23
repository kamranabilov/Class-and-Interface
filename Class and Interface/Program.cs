using System;

namespace Class_and_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            MainPrintFile mainPrintFile = new MainPrintFile("Word", "Excel", "PDf");
            mainPrintFile.Word = "Word cap edildi!\n";
            mainPrintFile.Excel = "Excel cap edildi!\n";
            mainPrintFile.PDF = "PDF cap edildi!\n";

            Console.WriteLine(mainPrintFile.Word);
            Console.WriteLine(mainPrintFile.Excel);
            Console.WriteLine(mainPrintFile.PDF);
           
        }       
    }
}
