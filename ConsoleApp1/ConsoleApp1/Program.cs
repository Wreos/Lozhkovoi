using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        private static int counter = 0;
        public User ()
        {
            counter++;
        }
        public static void DisplayCounter()
        {
            Console.WriteLine(counter);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();
            User user5 = new User();

            User.DisplayCounter(); // 5

            Console.Read();
        }
    } }