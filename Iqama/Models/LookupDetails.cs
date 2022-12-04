using System.ComponentModel.DataAnnotations.Schema;

namespace Iqama.Data.Models
{
    [Table("VV_SRV_LKUP_DTL")]
    public class LookupDetails
    {
        [Column("SRV_LKUP_DTL_ID")]
        public string Id { get; set; }
        
        [Column("SRV_LKUP_ID")]
        public string LookupId { get; set; }
        
        [Column("SRV_LKUP_DTL_DESC_EN")]
        public string DetailsEn { get; set; }
        
        [Column("SRV_LKUP_DTL_DESC_AR")]
        public string DetailsAr { get; set; }
        
        [Column("SRV_LKUP_DTL_IS_ACTIVE")]
        public string IsActive { get; set; }

    }
}
