using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.WebUI.Models
{
    public class FormListModel
    {
        public List<FormList> FormLists { get; set; }
        public FormList FormList { get; set; }
    }
}