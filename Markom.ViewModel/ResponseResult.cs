using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markom.ViewModel
{
    public class ResponseResult
    {
        public ResponseResult()
        {
            Success = true;
        }

        public ResponseResult(bool logic)
        {
            Success = logic;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Entity { get; set; }

    }
}
