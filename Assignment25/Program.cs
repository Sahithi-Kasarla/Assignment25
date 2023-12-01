using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace Assignment25
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate User Management Module
            UserManagementModule userModule = new UserManagementModule();
            userModule.AddUser("Sahithi");

            // Demonstrate File Processing Module
            FileProcessingModule fileModule = new FileProcessingModule();
            fileModule.ProcessFile("example.txt");

            // Add more demonstrations for other modules as needed

            Console.ReadLine(); 
        }
    }
}
