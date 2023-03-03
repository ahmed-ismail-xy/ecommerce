namespace ecommerce.Domain.Entities
{
    public class PasswordPrivacy
    {
        public Guid PasswordPrivacyId { get; set; }
        public string Code { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime SentAt { get; set; }
        public DateTime ConfirmedAt { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
