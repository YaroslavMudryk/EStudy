namespace EStudy.Application.ViewModels.Emails
{
    public class EmailViewModel
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public EmailContentType ContentType { get; set; }
    }
}