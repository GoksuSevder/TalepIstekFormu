using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalepIstekFormu.Entities
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Column(TypeName = ("Varchar"))]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter yazabilirsiniz.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string DepartmentName { get; set; }

        public bool IsDeleted { get; set; } = false;
       
        public ICollection<Employ> Employs { get; set; }
        public ICollection<Form> Forms { get; set; }
    }
}
