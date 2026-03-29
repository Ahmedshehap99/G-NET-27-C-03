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

        }
    }
}
