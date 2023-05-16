using System;

namespace ReRiskR.Core.Exceptions
{
    public class CoreException : Exception
    {
        private string _message;
        private string _errorCode;
        private const string DefaultErrorCode = "Thing-bork-why";

        //Generates a message default pattern if the Exception fails to carry one
        public override string Message => _message ?? 
            (_message = ConvertToSentence(GetType().Name, DefaultErrorCode));

        //If Error Code is not supplied on thrown exception, returns default
        public string ErrorCode => _errorCode ??
            (_errorCode = DefaultErrorCode);

        public CoreException(string message = null, string errorCode = null)
        {
            _message = message;
            _errorCode = errorCode;
        }

        //Helper function for generating message
        static string ConvertToSentence(string message, string errorCode)
        {
            return $"{errorCode} : {message}";  
        }
    }
}
