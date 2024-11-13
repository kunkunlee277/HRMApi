using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.DTOs.HRM.Responses
{
    public class ResultViewModel
    {
        public ResultViewModel()
        {
            status = 1; //1 success; -1: error
            message = "success";

        }

        public int status { get; set; }
        public string message { get; set; }
        public object response { get; set; }
        public int totalRecord { get; set; }
    }
}
