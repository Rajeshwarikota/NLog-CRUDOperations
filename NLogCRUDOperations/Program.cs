using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogCRUDOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....NLOG-CRUD OPERATIONS....");
            Console.WriteLine("Enter the Option the below");
            Console.WriteLine("\n1:ArrayListCrudOperations\n2:DictionaryCrudOperations\n3:NLOG swapping Operations\n22:Default");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ArrayListOperations.ArrayListCRUD();
                    break;
                case 2:
                    DictionaryOperations.DictionaryCRUD();
                    break;
                case 3:
                    SwppingNumber.Swap();
                    break;
                default:
                    Console.WriteLine("Enter the Above Options");
                    break;
            }
            Console.ReadLine();
        }
    }
}
