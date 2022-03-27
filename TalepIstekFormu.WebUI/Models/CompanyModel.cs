using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.WebUI.Models
{
    public class CompanyModel
    {

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public Company GetCompany { get; set; }

    }
}