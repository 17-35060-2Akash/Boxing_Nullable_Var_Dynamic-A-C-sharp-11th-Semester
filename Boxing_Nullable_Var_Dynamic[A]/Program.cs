using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Nullable_Var_Dynamic_A_
{
    class Sample
    {
        //public int? y = 200;//nullable
        //var y = "hello";//error
        dynamic y;

        //Error
        //public void SampleMethod(var y = 4)
        //{
        //    var i = 5;
        //}

        public void SampleMethod(dynamic y)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing
            //int x = 10;
            //Object obj = x;//boxing,value will be known as boxed value
            //x = 100;
            //obj = 200;
            //Console.WriteLine("x:"+x);
            //Console.WriteLine("obj:" + obj);
            //Unboxing
            //int y =(int) obj;
            //obj = 50;
            //y = 100;
            //Console.WriteLine("y:"+y);
            //Console.WriteLine("obj:" + obj);

            //Nullable
            //Nullable<bool> check=null;
            //check = true;
            //Console.WriteLine(check.HasValue);
            //Console.WriteLine("check:"+check);
            //Nullable<int> x = null;
            //int? x = null;
            //x = 2;
            //Console.WriteLine(x.HasValue);
            //Console.WriteLine("x:" + x);
            //Sample s = new Sample();
            //s.y = null;

            //var keyword
            //var x=2;
            //x = "hello";//error
            //Console.WriteLine(x);

            //dynamic keyword
            dynamic x = 7;
            Console.WriteLine(x.GetType());
            x = "hello";
            Console.WriteLine(x.GetType());
            Console.WriteLine(x);
        }
    }
}
