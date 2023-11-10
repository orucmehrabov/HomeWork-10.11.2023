using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_List.Exeptions
{
    internal class LessThanZeroExeption : Exception
    {
        public LessThanZeroExeption() : this ("Cannot be less than zero!")
        {

        }
        public LessThanZeroExeption(string message) : base(message)
        {

        }
    }
}
