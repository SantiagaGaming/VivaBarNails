namespace VivaBarNails.Models
{
    public class NailOrder
    {
        public int Id { get; set; }
        public string? NailName { get; set; }
        public Client? NailClient { get; set; }
        public NailMaster? Master { get; set; }
        public string? Img { get; set; }
    }
}
