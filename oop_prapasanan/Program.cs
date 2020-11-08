using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_prapasanan
{
    class Program
    {
        public static void Main(string[] args)
        {
            teacher myteacher = new teacher();
            myteacher.uniform();
            myteacher.salary();
            nurse mynurse = new nurse();
            mynurse.uniform();
            mynurse.salary();
            Pharmacist myPharmacist = new Pharmacist();
            myPharmacist.uniform();
            myPharmacist.Salary();

        }
    }
}
