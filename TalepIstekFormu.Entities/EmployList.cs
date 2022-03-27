using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalepIstekFormu.Entities
{
    public class EmployList
    {
        public int EmployId { get; set; }
        public string EmployName { get; set; }
        public string EmploySurname { get; set; }
        public string DepartmentName { get; set; }
        public string CompanyName { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
