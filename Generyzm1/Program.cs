using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Generyzm1;

namespace ganeryzm1
{



    class program
    {
        public static void Main(string[] args)
        {

            //  List<int> intList = new List<int>();
            // intList.Add(1);
            var restaurants = new List<Restaurant>();

            var result = new PaginateResults<Restaurant>();

            result.Results = restaurants;

            var users = new List<User>();

            var stringRepository = new Repository<string>();

            stringRepository.AddElement("Wartość Domyślna");

            string firstElement = stringRepository.GetElement(0);

            var userRepository = new Repository<string, User>();

            userRepository.AddElement("Bill", new User() { Name = "Bill" });

            User bill = userRepository.GetElement("Bill");



            Console.WriteLine(new User() );
            Console.WriteLine( userRepository);

        }

    }
}