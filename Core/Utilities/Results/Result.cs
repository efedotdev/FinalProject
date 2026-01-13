using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       

        public Result(bool success, string message):this(success)// diğer constructor'ı da çağırır.
        {
            Message = message; // get -only property'lere constructor üzerinden set edilebilir.
            
        }
        public Result(bool success)//constructor overloading
        {
         
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
