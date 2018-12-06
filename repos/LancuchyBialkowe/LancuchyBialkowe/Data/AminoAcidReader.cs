using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LancuchyBialkowe.Data
{
    class AminoAcidReader
    {
        public string[] ReadFile(string filename)
        {
            string[] aminoAcidArray;

            try
            {
                aminoAcidArray = File.ReadAllLines(filename);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return aminoAcidArray;
        }
    }
}
