namespace VivaBarNails.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? ClientName { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime VisitDate { get; set; }
        public NailMaster? NailMaster { get; set; }

    }
}
