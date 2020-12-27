using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySieuthi.DTO
{
    [Table("Product")]
    public class Product
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int STT { get; set; }
        [Key]
        public int ProdID { get; set; }
        [Required]
        [StringLength(150)]
        public string ProdName { get; set; }
        public DateTime DateIn { get; set; }
        [StringLength(150)]
        public string NSX { get; set; }
        public bool State { get; set; }
        public int? CatId { get; set; }
        [ForeignKey("CatId")]
        public virtual Category Category { get; set; }

    }
}
