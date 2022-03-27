using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.WebUI.Models
{
    public class EmployModel
    {
        public int EmployId { get; set; }
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public string EmployName { get; set; }
        public string EmploySurname { get; set; }
        public string CompanyName { get; set; }
        public string DepartmentName { get; set; }

        public Employ Employ { get; set; }

    }
}

