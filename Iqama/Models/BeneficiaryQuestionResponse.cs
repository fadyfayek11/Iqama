using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iqama.Data.Models
{
    [Table("VV_SRV_TRX_BNFCRY_QUST")]
    public class BeneficiaryQuestionResponse
    {
        [Column("BNFCRY_QUST_ID")]
        public string Id { get; set; }
        
        [Column("TRX_BNFCRY_ID")]
        public string BeneficiaryId { get; set; }
        
        [Column("QUST_INDEX")]
        public int Index { get; set; }
        
        [Column("QUST_ID")]
        public int  FormQuestionId { get; set; }

        [Column("QUST_REPLY")]
        public string  Reply { get; set; }

        [Column("CREATED_BY")]
        public string CreatedBy { get; set; }

        [Column("CREATION_DATE")]
        public DateTime CreateDate { get; set; }

        [Column("LAST_UPDATED_BY")]
        public string UpdateBy { get; set; }

        [Column("LAST_UPDATED_DATE")]
        public DateTime UpdateDate { get; set; }

    }
}
