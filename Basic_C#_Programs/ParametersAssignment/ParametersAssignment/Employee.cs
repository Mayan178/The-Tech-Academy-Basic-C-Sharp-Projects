using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    //setting up the Employee class with a generic parameter
    public class Employee<T>
    {
        //property things added with data type being a generic list matching the generic data type
        public List<T> things { get; set; }
    }
}
