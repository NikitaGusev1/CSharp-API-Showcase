using System.Collections.Generic;
using Newtonsoft.Json;

namespace GetRequestAndParse
{

    public class Rootobject
    {
        public string type { get; set; }
        public Value[] value { get; set; }
    }

    public class Value
    {
        public int id { get; set; }
        public string joke { get; set; }
        public string[] categories { get; set; }
    }

}
