using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Teacher
    {
        [Column("TeacherId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Teacher name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is a required field.")]

        public string Subject { get; set; }
        [Required(ErrorMessage = "Subject is a required field.")]
        public string Class { get; set; }
        [Required(ErrorMessage = "Class is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Position is 20 characters.")]
        public string? Position { get; set; }
        [ForeignKey(nameof(School))]
        public Guid SchoolId { get; set; }
        public School School { get; set; }
    }
}
