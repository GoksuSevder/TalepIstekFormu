using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.WebUI.Models
{
    public class EmployListModel
    {
        public List<Employ> Employs { get; set; }
        public List<EmployList> EmployLists { get; set; }
    }
}