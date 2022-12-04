using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iqama.Data.Models
{
    [Table("VV_SRV_TRX_BNFCRY")]
    public class Beneficiary
    {
        [Column("TRX_BNFCRY_ID")]
        public string Id { get; set; }
        
        [Column("SRV_TRX_ID")]
        public string TrxId { get; set; }
        
        [Column("BNFCRY_NAME")]
        public string Name { get; set; } 
        
        [Column("BNFCRY_GENDER")]
        public string Gender { get; set; }
        
        [Column("BNFCRY_TYPE_ID")]
        public string TypeId { get; set; }
        
        [Column("BNFCRY_RELATION_TYPE")]
        public string RelationType { get; set; }
        
        [Column("BNFCRY_DOB")]
        public DateTime DateOfBirth { get; set; }
        
        [Column("BNFCRY_TRX_PRICE")]
        public int Price { get; set; } 
        
        [Column("BNFCRY_TRX_STATUS")]
        public string Status { get; set; } 
        
        [Column("BNFCRY_TRX_ERROR_CODE")]
        public string ErrorCode { get; set; }
        
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
