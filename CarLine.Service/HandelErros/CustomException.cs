using Carline.Web.HandelErros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.HandelErros
{
    public class CustomException : ApiResponse
    {
        public CustomException(int statusCode, string? message = null , string? details = null) 
            : base(statusCode, message)
        {
            Details = details;

        }

        public string? Details { get; set; }
    }
}
