using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{
    class Man
    {
        private string fName;

        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }

        private string IName;

        public string LastName
        {
            get { return IName; }
            set { IName = value; }
        }

        public virtual void PritnInFo()  // virtual상속시 받아서 수정해도 됨.
        {
            Console.WriteLine("======= Man =======");
            Console.WriteLine("First Name : {0} ", fName);
            Console.WriteLine("Last Name : {0} ", IName);
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}


        //public override string ToString()
        //{
        //    return $"{fName} {IName}";
        //}
    }

    class Employee : Man
    {
        int employeeID;

        public Employee(int employeeID)
        {
            this.employeeID = employeeID;
        }
        public void PrintInFo()  // new(원래꺼는 숨김), override - virtual(상속받아서 수정해서 사용)
        {
            Console.WriteLine("======= Man =======");
            Console.WriteLine("EmployeeID : {0} ", employeeID);
            Console.WriteLine("First Name : {0} ", this.FirstName);
            Console.WriteLine("Last Name : {0} ", this.LastName);
        }


    }


    class InheritTest
    {
        static void Main()
        {
            Man man = new Man();
            man.FirstName = "류";
            man.LastName = "현진";
            man.PritnInFo();

            Employee emp1 = new Employee(2020005);
            emp1.FirstName = "아";
            emp1.LastName = "이유";
            emp1.PrintInFo();

            Console.WriteLine(man.ToString());
        }
    }
}
