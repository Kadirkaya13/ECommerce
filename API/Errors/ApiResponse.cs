using API.Utility;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message=null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

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
