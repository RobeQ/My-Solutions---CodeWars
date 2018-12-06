using LancuchyBialkowe.Data;
using LancuchyBialkowe.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancuchyBialkowe
{
    class Program
    {
        private static readonly AminoAcidReader _aminoAcidReader = new AminoAcidReader();
        private static readonly Comparision _comparision = new Comparision();

        static void Main(string[] args)
        {
            bool continueProgram = true;
            do
            {
                Console.Write("Write a full filename of amino acid: ");
                AminoAcidFileEntry();

                var continueDecision = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to continue program? Y/N");
                    continueDecision = Console.ReadLine() ?? string.Empty;
                }
                while (!continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
                !continueDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueProgram = continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);
            }
            while (continueProgram);
        }

        private static void AminoAcidFileEntry()
        {
            try
            {
                var filename = Console.ReadLine() ?? string.Empty;
                string[] aminoArray = _aminoAcidReader.ReadFile(filename);

                int j = 1;
                string pair = "First pair: ";
                for (int i = 0; i < aminoArray.Length; i += 2)
                {                  
                    Console.WriteLine("{0}{1}",pair ,_comparision.changePossible(aminoArray[i], aminoArray[j]));
                    j += 2;
                    pair = "Next pair: ";
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("File was not loaded because there was an error: " + ex.Message);
            }
        }
    }
}
