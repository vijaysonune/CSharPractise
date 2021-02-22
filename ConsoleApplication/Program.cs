using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

/* Don't change anything here.
 * Do not add any other imports. You need to write
 * this program using only these libraries 
 */

namespace ProgramNamespace
{
    /* You may add helper classes here if necessary */

    public class User
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Quantity { get; set; }
        public string Product { get; set; }
        public int Price { get; set; }
        public string ModeOfTransaction { get; set; }
    }

    public class Program
    {
        public static List<String> processData(
                                        IEnumerable<string> lines)
        {

            // below code to retreive highest price user name from the location 
            List<User> lUsers = new List<User>();
            List<String> retVal = new List<String>();
            foreach (string str in lines)
            {

                string[] split = str.Split(',');
                User user = new User();
                user.Name = split[0];
                user.Location = split[1];
                user.Quantity = Convert.ToInt32(Regex.Replace(split[2], "[^0-9]+", string.Empty));
                user.Product = split[3];
                user.Price = Convert.ToInt32(Regex.Replace(split[4], "[^0-9]+", string.Empty));
                user.ModeOfTransaction = split[5];
                lUsers.Add(user);
            }
            var listOfName = from s in lUsers
                             group s by s.Location into Usergrp
                             let topp = Usergrp.Max(x => x.Price)
                             select new
                             {
                                 Location = Usergrp.Key,
                                 HighestPrice = Usergrp.First(y => y.Price == topp).Name,
                                 MaximumPrice = topp
                             };

            foreach (var user in listOfName)
            {
                retVal.Add(user.HighestPrice);
            }

            //var query = lUsers.GroupBy(x => x.Location)
            //    .Select(group =>
            //    {
            //        int maxPrice = group.Max(x => x.Price);
            //        return group.Where(x => x.Price == maxPrice).ToList();
            //    });


            //Console.WriteLine(query.Count());
            return retVal;
        }

        public static void Main(string[] args)
        {
            try
            {
                String line;
                var inputLines = new List<String>();
                while (!string.IsNullOrEmpty(line = Console.ReadLine()))
                {
                    line = line.Trim();
                    if (line != "")
                        inputLines.Add(line);
                }
                var retVal = processData(inputLines);
                foreach (var res in retVal)
                    Console.WriteLine(res);

            }

            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
