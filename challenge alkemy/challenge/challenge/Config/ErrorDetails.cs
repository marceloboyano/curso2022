namespace challenge.Config
{
    public class ErrorDetails
    {
       
            public ErrorDetails()
            {

            }

            public int StatusCode { get; set; }
            public string MessageProcessingHandler { get; set; }
            public string StackTrace { get; set; }
       
    }
}
