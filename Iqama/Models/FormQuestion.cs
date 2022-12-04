using System.ComponentModel.DataAnnotations.Schema;

namespace Iqama.Data.Models
{
    [Table("VV_SRV_DCLRTN_FORM_QUTS")]
    public class FormQuestion
    {
        [Column("FORM_QUST_ID")]
        public int Id { get; set; }
        
        [Column("FORM_QUST_TYPE_ID")]
        public string TypeId { get; set; }
        
        [Column("FROM_QUST_DESC_EN")]
        public string QuestionEn { get; set; } 
        
        [Column("FROM_QUST_DESC_AR")]
        public string QuestionAr{ get; set; }
        
        [Column("FORM_QUST_IS_MANDATORY")]
        public string IsMandatory{ get; set; }
        
        [Column("FORM_QUST_IS_ACTIVE")]
        public string IsActive{ get; set; }
    }
}
