namespace Ders4_Mvc.Models
{
    public class ContactFormViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public int ContactTopicId { get; set; }

        public IEnumerable<ContactTopic> ContactTopics { get; set; }

    }
}
