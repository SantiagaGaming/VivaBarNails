using System.ComponentModel.DataAnnotations;

namespace VivaBarNails.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Укажите имя для записи.")]
        public string? ClientName { get; set; }

        [Required(ErrorMessage ="Укажите номер телефона.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Номер телефона должен состоять из 10 цифр.(9215556565)")]
        [RegularExpression(@"^[1-9]+[0-9]*$", ErrorMessage = "Номер телефона может содержать только цифры!")]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Выберите свободную дату для записи.")]
        public DateTime VisitDate { get; set; }
        public NailMaster? NailMaster { get; set; }

    }
}
