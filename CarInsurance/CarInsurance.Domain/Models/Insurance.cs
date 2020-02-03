namespace CarInsurance.Domain.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public double InsurancePrice { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int InsuredId { get; set; }
        public Insured Insured { get; set; }
    }
}
