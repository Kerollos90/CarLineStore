namespace Carline.Web.HandelErros
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string? message)
        {
            StatusCode = statusCode;
            Message = message ?? GetErrorMessage(statusCode);
        }

        public int StatusCode { get; set; }

        public string Message { get; set; } 

        


        string GetErrorMessage( int statusCode  )
        =>  statusCode switch
            {
                200 => "200 OK - The request has succeeded.",
                201 => "201 Created - Resource created successfully.",
                204 => "204 No Content - No content to return.",
                400 => "400 Bad Request - Client sent an invalid request.",
                401 => "401 Unauthorized - Authentication required.",
                403 => "403 Forbidden - You don’t have permission.",
                404 => "404 Not Found - Resource not found.",
                405 => "405 Method Not Allowed - Method not allowed.",
                500 => "500 Internal Server Error - Something went wrong on the server.",
                502 => "502 Bad Gateway - Invalid response from upstream server.",
                503 => "503 Service Unavailable - Server is temporarily unavailable.",
                _ => $"Unknown Status Code: {statusCode}"
            };


        


    }
}
