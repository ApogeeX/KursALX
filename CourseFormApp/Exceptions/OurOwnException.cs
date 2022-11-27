namespace CourseFormApp.Exeptions
{
    public class OurOwnException : Exception
    {
        public OurOwnException()
        {
        }

        public OurOwnException(string? message) : base(message)
        {
        }

        public OurOwnException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
