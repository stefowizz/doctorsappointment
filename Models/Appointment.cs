using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace doctorsappointment.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }


        [DisplayName("Patient ID")]
        [Column(TypeName = "nvarchar(8)")]
        [Required(ErrorMessage ="This field is required!")]
        [MaxLength(8, ErrorMessage = "Maximum 8 characters only")]
        public string? patientId { get; set; } 


        [DisplayName("Title")]
        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(20, ErrorMessage = "Maximum 20 characters only")]
        public string? Title { get; set; }


        [DisplayName("First Name")]
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(30, ErrorMessage = "Maximum 30 characters only")]
        public string? FirstName { get; set;}


        [DisplayName("Last Name")]
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(30, ErrorMessage = "Maximum 30 characters only")]
        public string? LastName { get; set;}


        [DisplayName("Doctor of Choice")] 
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(70, ErrorMessage = "Maximum 70 characters only")]
        public string? Doctor { get; set;}  


        [DisplayName("Email")]
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(78, ErrorMessage = "Maximum 78 characters only")]
        public string? Email { get; set;}


        [DisplayName("Phone Number")]
        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only")] 
        public string? PhoneNumber { get; set;}

        [DisplayFormat(DataFormatString = "{0: MMM-dd-yyyy}")]
        public DateTime Date { get; set;} 
        
  
    }
}
