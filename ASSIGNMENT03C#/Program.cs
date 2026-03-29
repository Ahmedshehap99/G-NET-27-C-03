namespace assignment03c_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01
            /*Q1: What will this print and explain what happens?
                double d = 9.99;
                int x = (int)d;
                Console.WriteLine(x);*/


            // this code will print integer value x = 9 , lost 0.99. 


            #endregion






            // this code will print integer value x = 9 , lost 0.99. 


            #region Question02
            /*Q2: This code doesn’t compile. Fix it with the smallest change?
                int n = 5;
                double d2 = n / 2;
                Console.WriteLine(d2); */

            //int n = 5;
            //double d2 = n / 2.0;
            //Console.WriteLine(d2);

            //// convert value 2 to 2.0 



            #endregion
            #region Question03

            /*Q3: You read a number from user input .. Write the correct line to
                 get age as int.*/

            //Console.WriteLine("Enter your age : ");
            //int age;
            //int.TryParse(Console.ReadLine(), out age);


            #endregion




            #region Question04


            /*Q4: What happens here and why ?
                  string s = "12a";
                  int x = int.Parse(s);
                  Console.WriteLine(x);*/

            //This code throws a FormatException because "12a" is not a valid integer format. 

            #endregion

            #region Question05

            ////Complete the code from the previous question so it prints
            ////Invalid if conversion into int fails, otherwise prints the number

            //string s = "12a";

            //if (int.TryParse(s, out int x))
            //{
            //    Console.WriteLine(x);

            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            #endregion
            #region Question06

            ////Q6: What will this print and explain why ?
            //// Output = 11 .  

            //object o = 10;
            //int a = (int)o;//Unboxing (explicit cast) 
            //Console.WriteLine(a + 1);


            #endregion
            #region Question07

            ///*Q7: What will this print and explain why and if there is a problem handle it ?*/

            //object o = 10;
            //long x = (long)(int)o;
            //Console.WriteLine(x);


            ////  first :InvalidCastException ,Must unbox to the exact original type first! 
            ////from object to integer and from integer to long
            #endregion

            #region Question08
            ///*Q8: Fix this to avoid exceptions and print -1 if conversion isn’t
            //    possible?
            //    object o = 10;
            //    long x = o;
            //    Console.WriteLine(x);
            // */

            //object o = 10;

            //if (long.TryParse(o?.ToString(), out long x))
            //{
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine(-1);
            //}
            #endregion
            #region Question09

            /*Q9: What will this print and explain why ?
                string? name = null;
                Console.WriteLine(name?.Length);
             */


            //Output:  null name?.Length returns null because name is null.



            #endregion

            //Output:  null name?.Length returns null because name is null.





            #region Question10
            ///*Q10: What will this print and explain the process?

            //string? name2 = null;
            //int length = name2?.Length ?? 0*/

            //string? name2 = null;
            //int length = name2?.Length ?? 0;
            //Console.WriteLine(length);

            ////Output: 0 name2?.Length returns null, and ?? 0 assigns 0 instead.

            #endregion

            #region Question11

            ///*Q11: What’s wrong with this “safe” code and how can we solve it ?

            ////string? s = null;
            ////int x = int.Parse(s ?? "0");
            ////Console.WriteLine(x);*/

            ////int.Parse(null) throws ArgumentNullException.
            //string? s = null;
            //int x = Convert.ToInt32(s);
            //Console.WriteLine(x);


            #endregion
            #region Question12
            ///*Q12: What happens here and if there is a problem, handle it
            ////string? s = null;
            ////Console.WriteLine(s!.Length);*/


            ////Throws NullReferenceException because '!' only suppresses
            ////the warning but does not prevent null at runtime.

            //string? s = null;
            //Console.WriteLine(s?.Length ??0);
            #endregion


            #region Question13
            ///*Q13: What will this print?
            ////string? s = null;
            ////int x = Convert.ToInt32(s);
            ////Console.WriteLine(x);*/


            //string? s = null;
            //int x = Convert.ToInt32(s);
            //Console.WriteLine(x);
            ////Output: 0
            #endregion

            #region Question14

            ///*Q14: Compare results and explain each result :

            ////string? s = null;
            //// A
            //// int a = int.Parse(s);
            //// B
            ////int b = Convert.ToInt32(s);
            ////Console.WriteLine(b);*/

            //string? s = null;

            //int a = int.Parse(s);
            //Console.WriteLine(s);

            //int b = Convert.ToInt32(s);
            //Console.WriteLine(b);
            ////A: int.Parse(s) → throws ArgumentNullException.
            ////B: Convert.ToInt32(s) → returns 0.
            #endregion

        }
    }
}
