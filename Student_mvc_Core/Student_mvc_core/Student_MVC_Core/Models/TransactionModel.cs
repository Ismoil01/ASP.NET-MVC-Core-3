using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jQuery_Ajax_CRUD.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("№")]
        [Required(ErrorMessage = "Это поле обязательно к заполнению.")]
        [MaxLength(12, ErrorMessage = "Максимум 12 число")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("ФИО")]
        [Required(ErrorMessage = "Это поле обязательно к заполнению.")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Факультет")]
        [Required(ErrorMessage = "Это поле обязательно к заполнению.")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("Страна")]
        [Required(ErrorMessage = "Это поле обязательно к заполнению.")]
        [MaxLength(11)]
        public string SWIFTCode { get; set; }

        [DisplayName("Курс")]
        [Required(ErrorMessage = "Это поле обязательно к заполнению.")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Дата пост-я")]
        public DateTime Date { get; set; }
    }
}
