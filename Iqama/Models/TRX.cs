using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iqama.Data.Models
{
    [Table("VV_SRV_TRX")]
    public class TRX
    {
        [Column("SRV_TRX_ID")]
        public string Id { get; set; }

        [Column("VSTR_PASSPORT_NUM")]
        public string PassportNumber { get; set; }

        [Column("VSTR_INS_DURATION_DAYS")]
        public string InDurationDays { get; set; }

        [Column("VSTR_VISA_VALIDITY_DAYS")]
        public string VisaValidityDays { get; set; }

        [Column("VSTR_VISA_TYPE_ID")]
        public string VisaTypeId { get; set; }

        [Column("VSTR_VISIT_TYPE_ID")]
        public string VisitTypeId { get; set; }

        [Column("VSTR_MOB_NUM")]
        public string Mobile { get; set; }

        [Column("VSTR_NATIONALITY_CODE")]
        public string NationalityCode { get; set; }

        [Column("VSTR_ADDRESS")]
        public string Address { get; set; }

        [Column("VSTR_CITY")]
        public string City { get; set; }

        [Column("VSTR_ZIP_CODE")]
        public string ZipCode { get; set; }

        [Column("VSTR_POBOX")]
        public string PoBox { get; set; }

        [Column("VSTR_MARITAL_STATUS_ID")]
        public string MaritalStatusId { get; set; }

        [Column("VSTR_EMAIL")]
        public string Email { get; set; }

        [Column("VSTR_E_NUMBER")]
        public string ENumber { get; set; } 

        [Column("VSTR_VISA_NUM")]
        public string VisaNumber { get; set; }

        [Column("VSTR_BORDER_NUM")]
        public string BorderNumber { get; set; }

        [Column("VSTR_IQAMA_NUM")]
        public string IqamaNumber { get; set; }

        [Column("SRV_TRX_FILES_PATH")]
        public string FilesPath { get; set; }

        [Column("SRV_TRX_STATUS")]
        public string Status { get; set; } 

        [Column("SRV_TRX_ERROR_CODE")]
        public string ErrorCode { get; set; }

        [Column("SRV_TRX_DATE", TypeName = "DATE")]
        public DateTime Date { get; set; } 

        [Column("SRV_TRX_TYPE_ID")]
        public string TypeId { get; set; } 

        [Column("POLICY_CLASS_ID")]
        public string PolicyClassId { get; set; }

        [Column("POLICY_NUM")]
        public string PolicyNumber { get; set; }

        [Column("POLICY_TOTAL_PRICE")]
        public string PolicyTotalPrice { get; set; }

        [Column("POLICY_STATUS_ID")]
        public string PolicyStatusId { get; set; }

        [Column("POLICY_ISSUE_DATE", TypeName = "DATE")]
        public DateTime PolicyIssueDate { get; set; }

        [Column("POLICY_ACTIV_DATE", TypeName = "DATE")]
        public DateTime PolicyActivationDate { get; set; }

        [Column("POLICY_EXPIRY_DATE", TypeName = "DATE")]
        public DateTime PolicyExpiryDate { get; set; }

        [Column("POLICY_CANCEL_DATE", TypeName = "DATE")]
        public DateTime PolicyCancelDate { get; set; }

        [Column("POLICY_LINK_EN")]
        public string PolicyLinkEn { get; set; }

        [Column("POLICY_LINK_AR")]
        public string PolicyLinkAr { get; set; }

        [Column("POLICY_COMPANY_NUM")]
        public string PolicyCompanyNumber { get; set; }

        [Column("POLICY_CACEL_REASON_ID")]
        public string PolicyCancelReasonId { get; set; }

        [Column("CREATED_BY")]
        public string CreatedBy { get; set; }

        [Column("CREATION_DATE", TypeName = "DATE")]
        public DateTime CreationDate { get; set; }

        [Column("LAST_UPDATED_BY")]
        public string UpdatedBy { get; set; }

        [Column("LAST_UPDATED_DATE", TypeName = "DATE")]
        public DateTime UpdatedDate { get; set; }
    }
}
