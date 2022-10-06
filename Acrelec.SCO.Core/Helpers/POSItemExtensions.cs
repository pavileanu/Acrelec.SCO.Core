using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acrelec.SCO.DataStructures;

namespace Acrelec.SCO.Core.Helpers
{
    public static class POSItemExtensions
    {
        //todo - write an extension method which returns only the first 3 letters of the POSItem.Name
        public static string Abbreviation(this POSItem posItem, int firstCharsNumbers = 3)
        {
            int nameLength = posItem.Name.Length;
            return posItem.Name.Substring(0, nameLength < firstCharsNumbers ? nameLength : firstCharsNumbers);
        }
    }
}
