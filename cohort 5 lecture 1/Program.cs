
using System;

namespace cohort_5_lecture_1
{
    internal class Program  // class 
    {
        static void Main(string[] args)  /// function 
        {

            //data type && variables 

            // datatype nameofvariable =  value 

            int x = 5;
            Console.WriteLine(x);

            double y = 12.5;     // datatype ==== value  int == int , double == double 
            Console.WriteLine(y);

            double w = 3.45d;
            Console.WriteLine(w);

            float ww = 3.45f;
            Console.WriteLine(ww);

            string z = "suhaib";   //  char == 1 character , sttring  ==> colloection of charecter
            Console.WriteLine(z);

            char c = 's'; ;
            Console.WriteLine(c);


            bool b = true;
            Console.WriteLine(b);


            string name = "sara";  //  _ or any char , dont contain special charecter && numbers , space , reserved keyword


            Console.WriteLine("*****************ARRAY*******************");

            // declaration of array 

            //dataType[] nameofarray = {1,2,3,4}


            //array of integer 
            int[] names = { 1, 5,2,3 };

            //array of string
            string[] toqa = { "a", "b" };


            // array of float 
            float[] suhaib = { 1.1f ,2.2f,3.3f };
            //1.1f  ==> 0
            //2.2f ==> 1
            // 3.3f ==> 2


            suhaib[0] = 5.5f;
            suhaib[1] = 4; // .
            suhaib[1] = 4.4f;

            foreach (float i in suhaib)  //   i ==>  value   ,,   
            {
                Console.WriteLine(i);
            }


            //for (int i = 0; i < suhaib.Length-2; i++)  //  i==> index 
            //{
            //    Console.WriteLine(suhaib[i]);
            //}

        }
    }
}
