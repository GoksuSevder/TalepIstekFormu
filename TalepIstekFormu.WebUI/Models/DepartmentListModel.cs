using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.WebUI.Models
{
    public class DepartmentListModel
    {
        public List<Department> Departments { get; set; }
        
    }
}