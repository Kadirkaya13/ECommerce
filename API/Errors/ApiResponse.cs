using API.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }


        public ApiResponse(int statusCode, string message=null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }


        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            string errorMessage = string.Empty;
            switch (statusCode)
            {
                case 400:
                    errorMessage= Messages.badRequest;
                    break;
                case 401:
                    errorMessage = Messages.unAuthorized;
                    break;
                case 404:
                    errorMessage = Messages.resouceNotFound;
                    break;
                case 500:
                    errorMessage = Messages.serverError;
                    break;
            }
            return errorMessage;
        }

       
        
    }
    
}
