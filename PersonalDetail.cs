/* 
 * Yiwen Zhao
 * Assignment_4
 * 4/18/2019
 * TestMethod used to test
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDetails
{
    class TestMethod
    {
        
        public TestMethod()
        {

            System.Console.WriteLine("Constructor!");
        }
        ~TestMethod()
        {

            System.Console.WriteLine("Deconstructor!");
        }
        // Create or Add new element to the List
        public void AddFun(IList<PersonalDetail> personaldetails, PersonalDetail PD)
        {

            personaldetails.Add(PD);
        }
        // Filtering the list using the condition(Age>35)
        public void FilterFun(IList<PersonalDetail> personaldetails, uint age_limit)
        {

            System.Console.WriteLine("The person information list: ");
            for (int i = 0; i < personaldetails.Count(); i++)
            {

                if (personaldetails[i].Age > age_limit)
                {
                    PrintDisplay(personaldetails[i]);
                }
            }
        }
        // Sort Fun by the FirstName
        public void SortFun(IList<PersonalDetail> pd)
        {

            List<string> personaldetails_back = new List<string>();

            for(int i = 0; i < pd.Count(); i++)
            {

                personaldetails_back.Add(pd[i].FirstName);
            }
            System.Console.WriteLine("Sorted FirstName: ");
            personaldetails_back.Sort();
            for (int i = 0; i < personaldetails_back.Count(); i++)
            {

                System.Console.WriteLine(personaldetails_back[i]);
            }
        }
        // Remove male employees from the List(T)--flashback
        public void RemoveFun(IList<PersonalDetail> pd)
        {

            for (int i = pd.Count() - 1; i>=0; i--)
            {

                if (pd[i].Gender)
                {

                    pd.Remove(pd[i]);
                }
            }
        }
        // Display the List
        public void PrintDisplay(PersonalDetail pd)
        {
                System.Console.WriteLine(pd.FirstName + "  " + pd.LastName + "  " + pd.Gender + "  " + pd.Age + "  " + pd.Salary);
        }
    }
}
