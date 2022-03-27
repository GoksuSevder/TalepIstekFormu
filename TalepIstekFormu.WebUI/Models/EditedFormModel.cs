using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalepIstekFormu.WebUI.Models
{
    public class EditedFormModel
    {
        public int FormId { get; set; }
        public DateTime GuncellemeTarih { get; set; }
        public string TalepNumarasi { get; set; }
        public bool BugHataDuzeltmeMi { get; set; } = false;
        public bool KucukDegisklikMi { get; set; } = false;
        public bool DegisklikMi { get; set; } = false;
        public bool BuyukDegisklikProjeMi { get; set; } = false;
        public string TalepMaliyeti { get; set; }
        public string EtkilenecekSistemVeriTabanEntegrasyon { get; set; }
        public string DisKaynakSecenekveMaliyeti { get; set; }

    }
}