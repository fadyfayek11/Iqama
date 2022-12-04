using System.ComponentModel.DataAnnotations.Schema;

namespace Iqama.Data.Models
{
    [Table("VV_SRV_LKUP")]
    public class Lookup
    {
        [Column("SRV_LKUP_ID")]
        public string Id { get; set; }
        
        [Column("SRV_LKUP_DESC_EN")]
        public string LookupEn { get; set; }
        
        [Column("SRV_LKUP_DESC_AR")]
        public string LookupAr { get; set; } 
        
        [Column("SRV_LKUP_IS_ACTIVE")]
        public string IsActive { get; set; }
    }
}
