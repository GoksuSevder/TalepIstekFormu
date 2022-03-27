using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.WebUI.Models
{
    public class DepartmentModel
    {
        public int DepartmentId { get; set; }

        [Column(TypeName = ("Varchar"))]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter yazabilirsiniz.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string DepartmentName { get; set; }

        public Department GetDepartment { get; set; }



        //public ICollection<Employ> Employs { get; set; }
    }
}