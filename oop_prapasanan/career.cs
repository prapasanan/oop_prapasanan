using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_prapasanan
{
    class career                    //คลาสอาชีพ
    {
        public string uniform;
        public string salary;
        private string operation;  //การทำงาน
    }
    class teacher : career         //คลาสครู : อาชีพ เก็บ เคื่องแบบ และ เงินเดือน
    {
        private void operation()
        {

        }
        public void uniform()     //เครื่องแบบ
        {
            Console.WriteLine("Official uniform");

        }
        public void salary()     //เงินเดือน
        {
            Console.WriteLine("15000");
        }

    }
    class nurse : career         //คลาสพยาบาล : อาชีพ เก็บ เคื่องแบบ และ เงินเดือน
    {
        private void operation()
        {

        }
        public void uniform()   //เครื่องแบบ
        {
            Console.WriteLine("Nurse uniform");
        }
        public void salary()   //เงินเดือน
        {
            Console.WriteLine("22,200");
        }
    }
    class Pharmacist : career  //คลาสเภสัชกร : อาชีพ เก็บ เคื่องแบบ และ เงินเดือน
    {
        private void operation()
        {

        }
        public void uniform()  //เครื่องแบบ
        {
            Console.WriteLine("Pharmacist uniform");
        }
        public void Salary() //เงินเดือน
        {
            Console.WriteLine("25,000");
        }

        
    }
}
