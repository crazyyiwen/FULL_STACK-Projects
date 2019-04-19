/* 
 * Yiwen Zhao
 * Assignment_4
 * 4/18/2019
 * Final test main funtion
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDetails
{
    class Test
    {
        static void Main(string[] args)
        {
            // Create the List
            IList<PersonalDetail> personaldetails = new List<PersonalDetail>();
            TestMethod test = new TestMethod();
            test.AddFun(personaldetails, new PersonalDetail("Vettel", "sebstian", true, 32, 2000));
            test.AddFun(personaldetails, new PersonalDetail("Hamilton", "Lewis", true, 34, 2200));
            test.AddFun(personaldetails, new PersonalDetail("Schumacher", "Michael", true, 50, 1800));
            test.AddFun(personaldetails, new PersonalDetail("Rice", "Lee", false, 36, 1850));
            test.AddFun(personaldetails, new PersonalDetail("Wish", "J", false, 28, 1980));

            // Filtering the list using the condition(Age>35)
            test.FilterFun(personaldetails, 35);

            // Sort Fun by the FirstName
            test.SortFun(personaldetails);

            // Remove male employees from the List(T)--flashback
            test.RemoveFun(personaldetails);


            // Finally Display the List
            System.Console.WriteLine();
            for (int i = 0; i < personaldetails.Count(); i++)
            {

                test.PrintDisplay(personaldetails[i]);
            }

            System.Console.ReadKey();


        }
    }
}
