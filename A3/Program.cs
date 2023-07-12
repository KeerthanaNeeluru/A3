using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //p1
               
                //string to int 
                string str;
                int i;
                bool b;
                Console.WriteLine("Enter string");
                str= Console.ReadLine();
                //int.TryParse(str, out i);//1
               //i=System.Int32.Parse(str);//2
              // i=int.Parse(str);//3
                //Console.WriteLine("converted : " + i);



                //b=int.TryParse(str, out i);//p2-1
                /*if (b)
                {
                    Console.WriteLine("Conversion is succesfull");
                    Console.WriteLine($" {i} * 5 : {(i * 5)}");
                }
                else { Console.WriteLine("Conversion failed"); }*/
/*              //p2-2
                DateTime dt;
                dt=System.DateTime.Parse(str);
                Console.WriteLine("convert to datetime : "+dt);
                var lastmonth = new DateTime(dt.Year, dt.Month - 1, 1);

                Console.WriteLine($"{dt}- 1month : {lastmonth}");*/
                //p2-3
                //str to timespan
                TimeSpan ts;
                ts=TimeSpan.Parse(str);
                Console.WriteLine("string in timespan : "+ts);
                TimeSpan add = new TimeSpan(ts.Hours + 2,ts.Minutes,ts.Seconds);
                Console.WriteLine($"{ts} + 2 Hours : "+add);
                
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error !!! "+e.Message);
            }
            catch(Exception e) {
                Console.WriteLine("ERROR !!!! "+e.Message);
            }
            finally {
                Console.WriteLine("End");
                Console.ReadKey();
            }


        }
    }
}
