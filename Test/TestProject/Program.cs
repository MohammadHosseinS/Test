using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Persist Security Info=False;User ID=moghari2;password=123456;Initial Catalog=Test;Data Source=(local)";

            var newClass=new NewClass(connectionString);

            var userValue=Console.ReadLine();

            var x=newClass.GetValue(userValue).Result;
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
