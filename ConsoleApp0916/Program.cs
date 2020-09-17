using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp0916
{
    public class Person
    {
        string name;
        int age;
        double height;
        double weight;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] arr = new Person[3];

            for (int i = 0; i < arr.Length; i++)
            {
                Person person1 = new Person();

                Console.WriteLine("이름입력 :");
                person1.Name = Console.ReadLine();

                Console.WriteLine("나이입력 :");
                person1.Age =  Utility.ConvertInt(Console.ReadLine());

                Console.WriteLine("키입력 :");
                person1.Height = Utility.ConvertDouble(Console.ReadLine());

                Console.WriteLine("몸무게입력 :");
                person1.Weight = Utility.ConvertDouble(Console.ReadLine());

                arr[i] = person1;
            }

            // 입력된 3명의 정보를 출력
            foreach(Person per in arr)
            {
                Console.WriteLine($"{per.Name} - {per.Age} - {per.Height} - {per.Weight}");
            }

            for(int i=0;i<arr.Length; i++)
            {
                Console.WriteLine($"{arr[i].Name}");
            }
        }
    }
}
