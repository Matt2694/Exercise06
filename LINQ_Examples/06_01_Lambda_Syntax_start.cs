using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Examples
{
    class Program
    {
        #region Class Definitions
        public class Customer
        {
            public string First { get; set; }
            public string Last { get; set; }
            public string State { get; set; }
            public double Price { get; set; }
            public string[] Purchases { get; set; }
            //public int CompareTo(Customer compareCustomer)
            //{
            //    if (x.ToString().Length == y.ToString().Length)
            //        return string.Compare(x.ToString(), y.ToString());
            //    else if (x.ToString().Length > y.ToString().Length)
            //        return 1;
            //    else
            //        return -1;
            //}
        }

        public class Distributor
        {
            public string Name { get; set; }
            public string State { get; set; }
        }

        public class CustDist
        {
            public string custName { get; set; }
            public string distName { get; set; }
        }

        public class CustDistGroup
        {
            public string custName { get; set; }
            public IEnumerable<string> distName { get; set; }
        }
        #endregion

        #region Create data sources

        static List<Customer> customers = new List<Customer>
        {
            new Customer {First = "Cailin", Last = "Alford", State = "GA", Price = 930.00, Purchases = new string[] {"Panel 625", "Panel 200"}},
            new Customer {First = "Theodore", Last = "Brock", State = "AR", Price = 2100.00, Purchases = new string[] {"12V Li"}},
            new Customer {First = "Jerry", Last = "Gill", State = "MI", Price = 585.80, Purchases = new string[] {"Bulb 23W", "Panel 625"}},
            new Customer {First = "Owens", Last = "Howell", State = "GA", Price = 512.00, Purchases = new string[] {"Panel 200", "Panel 180"}},
            new Customer {First = "Adena", Last = "Jenkins", State = "OR", Price = 2267.80, Purchases = new string[] {"Bulb 23W", "12V Li", "Panel 180"}},
            new Customer {First = "Medge", Last = "Ratliff", State = "GA", Price = 1034.00, Purchases = new string[] {"Panel 625"}},
            new Customer {First = "Sydney", Last = "Bartlett", State = "OR", Price = 2105.00, Purchases = new string[] {"12V Li", "AA NiMH"}},
            new Customer {First = "Malik", Last = "Faulkner", State = "MI", Price = 167.80, Purchases = new string[] {"Bulb 23W", "Panel 180"}},
            new Customer {First = "Serena", Last = "Malone", State = "GA", Price = 512.00, Purchases = new string[] {"Panel 180", "Panel 200"}},
            new Customer {First = "Hadley", Last = "Sosa", State = "OR", Price = 590.20, Purchases = new string[] {"Panel 625", "Bulb 23W", "Bulb 9W"}},
            new Customer {First = "Nash", Last = "Vasquez", State = "OR", Price = 10.20, Purchases = new string[] {"Bulb 23W", "Bulb 9W"}},
            new Customer {First = "Joshua", Last = "Delaney", State = "WA", Price = 350.00, Purchases = new string[] {"Panel 200"}}
        };

        static List<Distributor> distributors = new List<Distributor>
        {
            new Distributor {Name = "Edgepulse", State = "UT"},
            new Distributor {Name = "Jabbersphere", State = "GA"},
            new Distributor {Name = "Quaxo", State = "FL"},
            new Distributor {Name = "Yakijo", State = "OR"},
            new Distributor {Name = "Scaboo", State = "GA"},
            new Distributor {Name = "Innojam", State = "WA"},
            new Distributor {Name = "Edgetag", State = "WA"},
            new Distributor {Name = "Leexo", State = "HI"},
            new Distributor {Name = "Abata", State = "OR"},
            new Distributor {Name = "Vidoo", State = "TX"}
        };

        static double[] exchange = { 0.89, 0.65, 120.29 };

        static double[] ExchangedPrices = {827.70, 604.50, 111869.70,
                                        1869.00, 1,365.00, 252609.00,
                                        521.36, 380.77, 70465.88,
                                        455.68, 332.80, 61588.48,
                                        2018.34, 1474.07, 272793.66,
                                        920.26, 672.10, 124379.86,
                                        1873.45, 1368.25, 253210.45,
                                        149.34, 109.07, 20184.66,
                                        455.68, 332.80, 61588.48,
                                        525.28, 383.63, 70995.16,
                                        9.08, 6.63, 1226.96,
                                        311.50, 227.50, 42101.50};

        static string[] Purchases = {  "Panel 625", "Panel 200",
                                    "12V Li",
                                    "Bulb 23W", "Panel 625",
                                    "Panel 200", "Panel 180",
                                    "Bulb 23W", "12V Li", "Panel 180",
                                    "Panel 625",
                                    "12V Li", "AA NiMH",
                                    "Bulb 23W", "Panel 180",
                                    "Panel 180", "Panel 200",
                                    "Panel 625", "Bulb 23W", "Bulb 9W",
                                    "Bulb 23W", "Bulb 9W",
                                    "Panel 200"
                                 };
        #endregion

        #region Exercises
        static void Main(string[] args)
        {

            #region Exercise 1 - Tuesday

            //IEnumerable<double> exchangeQuery =
            //    from e in ExchangedPrices
            //    where e < 1000
            //    select e;

            //IEnumerable<Customer> stateQuery =
            //    from c in customers
            //    where c.State == "GA"
            //    select c;

            #endregion

            #region Exercise 2 - Tuesday

            //IEnumerable<Customer> firstNameQuery =
            //    from c in customers
            //    select c;

            //var fullNameQuery =
            //    from c in customers
            //    select new { Name = c.First + " " + c.Last };

            //var stateQuery =
            //    from c in customers
            //    from d in distributors
            //    where d.State.Equals(c.State)
            //    select c.State;

            #endregion

            #region Exercise 3 - Tuesday

            //var takeQuery = customers
            //    .Take(3);

            //var takeORQuery = customers
            //    .Where (c => c.State.Equals("OR")).Take(3);

            #endregion

            #region Exercise 4 - Tuesday

            //var orderByFNameQuery = customers
            //    .OrderBy(c => c.First);

            //var orderByLNameLengthQuery = customers
            //    .OrderBy(c => c.Last.Length);

            //var orderByPriceHToLQuery = customers
            //    .OrderByDescending(c => c.Price);

            //var orderByLOfFirstLastQuery = customers
            //    .OrderBy(c => c.First.Length).ThenBy(c => c.Last);

            #endregion

            #region Exercise 5 - Tuesday

            //IEnumerable<IGrouping<char, Customer>> groupByFirstLetterQuery = customers
            //    .GroupBy(c => c.First.First());

            //IEnumerable<IGrouping<string, Customer>> groupByFirstLetterQuery = customers
            //      .GroupBy(c => c.State);

            #endregion

            #region Exercise 6 - Tuesday

            //var exceptFindQuery = customers
            //    .Where(c => c.First.First() == c.Last.First());

            //var exceptQuery = customers.Except(exceptFindQuery);

            #endregion

            #region Exercise 7 - Tuesday

            //bool anyQuery = customers.Any(c => c.First.Contains("ed"));

            //foreach (var c in exceptQuery)
            //{
            //    Console.WriteLine("{0}, {1}", c.Last, c.First);
            //}

            //Console.Write("There {0} customers with \"ed\" in their first name.",
            //              anyQuery ? "are" : "are not any");

            //foreach (IGrouping<string, Customer> stateGroup in groupByFirstLetterQuery)
            //{
            //    Console.WriteLine("{0}", stateGroup.Key);
            //    foreach (Customer c in stateGroup)
            //    {
            //        Console.WriteLine("  {0} {1}: {2:C}", c.First, c.Last, c.Price);
            //    }
            //}

            #endregion

            #region Exercise 1 - Thursday

            //List<double> custLT100 = new List<double>();
            //foreach(double exPrice in ExchangedPrices)
            //{
            //    if(exPrice < 1000)
            //    {
            //        custLT100.Add(exPrice);
            //    }
            //}

            //List<Customer> custGA = new List<Customer>();
            //foreach(Customer cus in customers)
            //{
            //    if(cus.State == "GA")
            //    {
            //        custGA.Add(cus);
            //    }
            //}

            #endregion

            #region Exercise 2 - Thursday

            //List<Customer> custFN = new List<Customer>();
            //foreach(Customer cus in customers)
            //{
            //    custFN.Add(cus);
            //}

            //List<string> FullName = new List<string>();
            //foreach(Customer cus in customers)
            //{
            //    FullName.Add(cus.First + " " + cus.Last);
            //}

            //List<string> cusDisState = new List<string>();
            //foreach(Customer cus in customers)
            //{
            //    foreach(Distributor dis in distributors)
            //    {
            //        if (cus.State.Equals(dis.State))
            //        {
            //            cusDisState.Add(cus.State);
            //        }
            //    }
            //}

            #endregion

            #region Exercise 3 - Thursday

            //List<Customer> first3Cust = new List<Customer>();
            //for(int i = 0; i < 3; i++)
            //{
            //    first3Cust.Add(customers[i]);
            //}

            //List<Customer> first3Cust = new List<Customer>();
            //foreach (Customer cus in customers)
            //{
            //    if (first3Cust.Count < 3)
            //    {
            //        if (cus.State.Equals("OR"))
            //        {
            //            first3Cust.Add(cus);
            //        }
            //    }
            //}

            #endregion

            #region Exercise 4 - Thursday

            //List<string> fNAlpha = new List<string>();
            //foreach(Customer cus in customers)
            //{
            //    fNAlpha.Add(cus.First);
            //}
            //fNAlpha.Sort();

            //List<string> lNLength = new List<string>();
            //foreach(Customer cus in customers)
            //{
            //    lNLength.Add(cus.Last);
            //}
            //lNLength.Sort(CompareFirstNamesByLengthEx4);

            //List<Customer> sortedByPrice = new List<Customer>();
            //foreach(Customer cus in customers)
            //{
            //    sortedByPrice.Add(cus);
            //}
            //sortedByPrice.Sort(CompareCustomersByPriceEx4);

            //List<Customer> sortedByFirstLengthLastAlpha = new List<Customer>();
            //foreach (Customer cus in customers)
            //{
            //    sortedByFirstLengthLastAlpha.Add(cus);
            //}
            //sortedByFirstLengthLastAlpha.Sort(CompareCustomersByFirstAndLastEx4);

            #endregion

            #region Exercise 5 - Thursday

            //List<Customer> cusGroupByFirstLetter = new List<Customer>();
            //List<char> firstLetter = new List<char>();
            //foreach(Customer cus in customers)
            //{
            //    cusGroupByFirstLetter.Add(cus);
            //}
            //cusGroupByFirstLetter.Sort(CompareCustomersByFirstAlphaEx5);
            //foreach(Customer cus in cusGroupByFirstLetter)
            //{
            //    if (!firstLetter.Contains(cus.First[0]))
            //    {
            //        firstLetter.Add(cus.First[0]);
            //    }
            //}
            //foreach(char n in firstLetter)
            //{
            //    Console.WriteLine(n);
            //    foreach(Customer cus in cusGroupByFirstLetter)
            //    {
            //        if (n.Equals(cus.First[0]))
            //        {
            //            Console.WriteLine(cus.First + " " + cus.Last);
            //        }
            //    }
            //}

            //List<Customer> cusGroupByState = new List<Customer>();
            //List<string> states = new List<string>();
            //foreach(Customer cus in customers)
            //{
            //    cusGroupByState.Add(cus);
            //}
            //cusGroupByState.Sort(CompareCustomersByState);
            //foreach(Customer cus in cusGroupByState)
            //{
            //    if (!states.Contains(cus.State))
            //    {
            //        states.Add(cus.State);
            //    }
            //}
            //foreach (string n in states)
            //{
            //    Console.WriteLine(n);
            //    foreach (Customer cus in cusGroupByState)
            //    {
            //        if (n.Equals(cus.State))
            //        {
            //            Console.WriteLine(cus.First + " " + cus.Last);
            //        }
            //    }
            //}

            #endregion

            #region Exercise 6 - Thursday

            //List<Customer> cusUsingExcept = new List<Customer>();
            //List<Customer> passingCustomers = new List<Customer>();
            //foreach(Customer cus in customers)
            //{
            //    cusUsingExcept.Add(cus);
            //}
            //foreach(Customer cus1 in cusUsingExcept)
            //{
            //    int i = 0;
            //    foreach (Customer cus2 in cusUsingExcept)
            //    {
            //        if (cus1.First[0].Equals(cus2.Last[0]))
            //        {
            //            i++;
            //        }
            //    }
            //    if (i == 0)
            //    {
            //        passingCustomers.Add(cus1);
            //    }
            //}

            #endregion

            #region Exercise 7 - Thursday

            //List<Customer> cusUsingAny = new List<Customer>();
            //bool anyQuery = false;
            //foreach(Customer cus in customers)
            //{
            //    cusUsingAny.Add(cus);
            //}
            //foreach(Customer cus in cusUsingAny)
            //{
            //    if (cus.First.Contains("ed"))
            //    {
            //        anyQuery = true;
            //    }
            //}
            //Console.Write("There {0} customers with \"ed\" in their first name.",
            //              anyQuery ? "are" : "are not any");

            #endregion

            //foreach (Customer n in passingCustomers)
            //{
            //    Console.WriteLine(n.First + " " + n.Last);
            //}

            Console.ReadKey();
        }

        #endregion

        #region Comparers for exercises
        private static int CompareFirstNamesByLengthEx4(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    int retval = x.Length.CompareTo(y.Length);

                    if (retval != 0)
                    {
                        return retval;
                    }
                    else
                    {
                        return x.CompareTo(y);
                    }
                }
            }
        }

        private static int CompareCustomersByPriceEx4(Customer x, Customer y)
        {
            return y.Price.CompareTo(x.Price);
        }

        private static int CompareCustomersByFirstAndLastEx4(Customer x, Customer y)
        {
            int returnValue;
            returnValue = x.First.Length.CompareTo(y.First.Length);
            if (returnValue == 0)
            {
                returnValue = x.Last.CompareTo(y.Last);
            }
            return returnValue;
        }

        private static int CompareCustomersByFirstAlphaEx5(Customer x, Customer y)
        {
            return x.First.CompareTo(y.First);
        }

        private static int CompareCustomersByState(Customer x, Customer y)
        {
            return x.State.CompareTo(y.State);
        }
        #endregion
    }
}