using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GetRequestAndParse;

namespace DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            var r =  ReqParse.GetReq().Result;
            Console.WriteLine(r.value[0].joke.ToString());
           
            
            Console.ReadLine();

        }
        //static void Call()
        //{
        //    var call = ReqParse.GetReq();
        //}
    }
}
