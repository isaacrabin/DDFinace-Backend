namespace DDFinace_Backend.Models
{
    public class Policy
    {
        public int Id { get; set; }
        public string PolicyName { get; set; }
        public string InsuranceType { get; set; }
        public string PolicyNumber { get; set; }
        public decimal PremiumAmount { get; set; }
    }
}
