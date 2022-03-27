using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalepIstekFormu.Entities
{
    public class Form
    {
        [Key]
        public int FormId { get; set; }
        [Display(Order = 2)]
        public int EmployId { get; set; }
        [ForeignKey("EmployId")]
        public virtual Employ Employ { get; set; }
        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        [Display(Order = 3)]
        [Column(TypeName = ("Varchar"))]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter yazabilirsiniz.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string TalebinGerceklesecegiSistem { get; set; }

        [Display(Order = 4)]
        [Column(TypeName = ("Varchar"))]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter yazabilirsiniz.")]
        public string TalepNumarasi { get; set; }

        [Display(Order = 5)]
        [Column(TypeName = "datetime2")]
        public DateTime OlusturulmaTarih { get; set; }

        [Display(Order = 6)]
        [Column(TypeName = "datetime2")]
        public DateTime GuncellemeTarih { get; set; }


        [Display(Order = 7)]
        [Column(TypeName = ("Varchar"))]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter yazabilirsiniz.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string DepartmentName { get; set; }


        [Display(Order = 8)]
        [Column(TypeName = ("Varchar"))]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter yazabilirsiniz.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string CompanyName { get; set; }

        [Display(Order = 9)]
        [Column(TypeName = ("Varchar"))]
        [StringLength(300, ErrorMessage = "En fazla 100 karakter yazabilirsiniz.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string TalepOzet { get; set; }

        [Display(Order = 10)]
        [Column(TypeName = ("Varchar"))]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter yazabilirsiniz.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string TalepGerekce { get; set; }

        [Display(Order = 11)]
        public bool MevcutSistemeEkMi { get; set; } = false;

        [Display(Order = 12)]
        public bool MevcutFonksiyonMu { get; set; } = false;

        [Display(Order = 13)]
        public bool YeniSistemMi { get; set; } = false;

        [Display(Order = 14)]
        public bool RaporlamaMi { get; set; } = false;

        [Display(Order = 15)]
        [Column(TypeName = ("Varchar"))]
        [StringLength(300, ErrorMessage = "En fazla 100 karakter yazabilirsiniz.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string TalepKapsamIcerik { get; set; }

        [Display(Order = 16)]
        [Column(TypeName = ("Varchar"))]
        [StringLength(300, ErrorMessage = "En fazla 100 karakter yazabilirsiniz.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string KullaniciGrupKullanimSikligi { get; set; }

        [Display(Order = 17)]
        [Column(TypeName = ("Varchar"))]
        [StringLength(300, ErrorMessage = "En fazla 100 karakter yazabilirsiniz.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string HedeflenenFayda { get; set; }

        [Display(Order = 18)]
        public bool GelirArtisiMi { get; set; } = false;
        [Display(Order = 19)]
        public bool MaliyetAzaltmaMi { get; set; } = false;
        [Display(Order = 20)]
        public bool RegulasyonaUyumMu { get; set; } = false;
        [Display(Order = 21)]
        public bool TakipIzlenebilirlikArtisMi { get; set; } = false;
        [Display(Order = 22)]
        public bool DigerMi { get; set; } = false;

        [Display(Order = 23)]
        [Column(TypeName = ("Varchar"))]
        [StringLength(300, ErrorMessage = "En fazla 100 karakter yazabilirsiniz.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string Riskler { get; set; }
        [Display(Order = 24)]
        [Column(TypeName = ("Varchar"))]
        [StringLength(300, ErrorMessage = "En fazla 100 karakter yazabilirsiniz.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string RaporlamaGereksinimi { get; set; }

        [Display(Order = 25)]
        [Column(TypeName = ("Varchar"))]
        [StringLength(300, ErrorMessage = "En fazla 100 karakter yazabilirsiniz.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string CozumBilgileri { get; set; }

        [Display(Order = 26)]
        [Column(TypeName = "datetime2")]
        public DateTime DevreyeAlimTarihi { get; set; }

        public FormDurum FormDurum { get; set; } = (FormDurum)1;

        public bool BugHataDuzeltmeMi { get; set; } = false;
        public bool KucukDegisklikMi { get; set; } = false;
        public bool DegisklikMi { get; set; } = false;
        public bool BuyukDegisklikProjeMi { get; set; } = false;

        [Column(TypeName = ("Varchar"))]
        [StringLength(300, ErrorMessage = "En fazla 100 karakter yazabilirsiniz.")]
        public string TalepMaliyeti { get; set; }

        [Column(TypeName = ("Varchar"))]
        [StringLength(300, ErrorMessage = "En fazla 100 karakter yazabilirsiniz.")]
        public string EtkilenecekSistemVeriTabanEntegrasyon { get; set; }

        [Column(TypeName = ("Varchar"))]
        [StringLength(300, ErrorMessage = "En fazla 100 karakter yazabilirsiniz.")]
        public string DisKaynakSecenekveMaliyeti { get; set; }

    }
    public enum FormDurum
    {
        YeniKayit = 1, Inceleniyor = 2, Onaylandi = 3, Reddedildi = 4, Kapatildi = 5
    }
}
