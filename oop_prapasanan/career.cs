using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_prapasanan
{
    class career
    {
        public string uniform;
        public string salary;
        private string WorkClothes;
    }
    class teacher : career
    {
        private void WorkClothes()
        {

        }
        public void uniform()
        {
            Console.WriteLine("Official uniform");

        }
        public void salary()
        {
            Console.WriteLine("15000");
        }

    }
    class nurse : career
    {
        private void WorkClothes()
        {

        }
        public void uniform()
        {
            Console.WriteLine("Nurse uniform");
        }
        public void salary()
        {
            Console.WriteLine("22,200");
        }
    }
    class Pharmacist : career
    {
        private void WorkClothes()
        {

        }
        public void uniform()
        {
            Console.WriteLine("Pharmacist uniform");
        }
        public void Salary()
        {
            Console.WriteLine("25,000");
        }

        
    }
}
