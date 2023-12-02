using System;
using System.Collections.Generic;
using System.Text;

namespace ParametersAssignment
{   
    // Creating class Employee that takes generic parameter
    public class Employee <T>
    { 
        // property that has data tpye generic list
        public List<T> Things { get; set; }
    }
}
