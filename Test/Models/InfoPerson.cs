using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    [Table("EmployeesInfo")]
    public class InfoPerson
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public string FIO { get; set; }
        public string Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Comment { get; set; }
        public bool Maternity { get; set; }
        
        [NotMapped]
        public string Mat { get { if (this.Maternity) return "Да"; else return "Нет"; } }
        public InfoPerson()
        { }
        public InfoPerson(string fio,string position,DateTime date,string comment,bool maternity)
        {
            this.FIO = fio;
            this.Position = position;
            this.DateOfBirth = date;
            this.Comment = comment;
            this.Maternity = maternity;
        }
    }
}
