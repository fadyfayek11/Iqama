using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iqama.Data.Models
{
    [Table("VV_SRV_TRX")]
    public class TRX
    {
        [Column("SRV_TRX_ID", TypeName = "VARCHAR2")]
        public string Id { get; set; }

        [Column("VSTR_PASSPORT_NUM", TypeName = "VARCHAR2")]
        public string PassportNumber { get; set; }

        [Column("VSTR_INS_DURATION_DAYS", TypeName = "NUMBER")]
        public string InDurationDays { get; set; }

        [Column("VSTR_VISA_VALIDITY_DAYS", TypeName = "NUMBER")]
        public string VisaValidityDays { get; set; }

        [Column("VSTR_VISA_TYPE_ID", TypeName = "VARCHAR2")]
        public string VisaTypeId { get; set; }

        [Column("VSTR_VISIT_TYPE_ID", TypeName = "VARCHAR2")]
        public string VisitTypeId { get; set; }

        [Column("VSTR_MOB_NUM", TypeName = "VARCHAR2")]
        public string Mobile { get; set; }

        [Column("VSTR_NATIONALITY_CODE", TypeName = "VARCHAR2")]
        public string NationalityCode { get; set; }

        [Column("VSTR_ADDRESS", TypeName = "VARCHAR2")]
        public string Address { get; set; }

        [Column("VSTR_CITY", TypeName = "VARCHAR2")]
        public string City { get; set; }

        [Column("VSTR_ZIP_CODE", TypeName = "VARCHAR2")]
        public string ZipCode { get; set; }

        [Column("VSTR_POBOX", TypeName = "VARCHAR2")]
        public string PoBox { get; set; }

        [Column("VSTR_MARITAL_STATUS_ID", TypeName = "VARCHAR2")]
        public string MaritalStatusId { get; set; }

        [Column("VSTR_EMAIL", TypeName = "VARCHAR2")]
        public string Email { get; set; }

        [Column("VSTR_E_NUMBER", TypeName = "VARCHAR2")]
        public string ENumber { get; set; } //what is that

        [Column("VSTR_VISA_NUM", TypeName = "VARCHAR2")]
        public string VisaNumber { get; set; }

        [Column("VSTR_BORDER_NUM", TypeName = "VARCHAR2")]
        public string BorderNumber { get; set; }

        [Column("VSTR_IQAMA_NUM", TypeName = "VARCHAR2")]
        public string IqamaNumber { get; set; }

        [Column("SRV_TRX_FILES_PATH", TypeName = "VARCHAR2")]
        public string FilesPath { get; set; }

        [Column("SRV_TRX_STATUS", TypeName = "VARCHAR2")]
        public string Status { get; set; } //what is that

        [Column("SRV_TRX_ERROR_CODE", TypeName = "VARCHAR2")]
        public string ErrorCode { get; set; }

        [Column("SRV_TRX_DATE", TypeName = "DATE")]
        public DateTime Date { get; set; } //what is that

        [Column("SRV_TRX_TYPE_ID", TypeName = "VARCHAR2")]
        public string TypeId { get; set; } //what is that

        [Column("POLICY_CLASS_ID", TypeName = "VARCHAR2")]
        public string PolicyClassId { get; set; }

        [Column("POLICY_NUM", TypeName = "VARCHAR2")]
        public string PolicyNumber { get; set; }

        [Column("POLICY_TOTAL_PRICE", TypeName = "NUMBER")]
        public string PolicyTotalPrice { get; set; }

        [Column("POLICY_STATUS_ID", TypeName = "NUMBER")]
        public string PolicyStatusId { get; set; }

        [Column("POLICY_ISSUE_DATE", TypeName = "DATE")]
        public DateTime PolicyIssueDate { get; set; }

        [Column("POLICY_ACTIV_DATE", TypeName = "DATE")]
        public DateTime PolicyActivationDate { get; set; }

        [Column("POLICY_EXPIRY_DATE", TypeName = "DATE")]
        public DateTime PolicyExpiryDate { get; set; }

        [Column("POLICY_CANCEL_DATE", TypeName = "DATE")]
        public DateTime PolicyCancelDate { get; set; }

        [Column("POLICY_LINK_EN", TypeName = "VARCHAR2")]
        public string PolicyLinkEn { get; set; }

        [Column("POLICY_LINK_AR", TypeName = "VARCHAR2")]
        public string PolicyLinkAr { get; set; }

        [Column("POLICY_COMPANY_NUM", TypeName = "VARCHAR2")]
        public string PolicyCompanyNumber { get; set; }

        [Column("POLICY_CACEL_REASON_ID", TypeName = "VARCHAR2")]
        public string PolicyCancelReasonId { get; set; }

        [Column("CREATED_BY", TypeName = "VARCHAR2")]
        public string CreatedBy { get; set; }

        [Column("CREATION_DATE", TypeName = "DATE")]
        public DateTime CreationDate { get; set; }

        [Column("LAST_UPDATED_BY", TypeName = "VARCHAR2")]
        public string UpdatedBy { get; set; }

        [Column("LAST_UPDATED_DATE", TypeName = "DATE")]
        public DateTime UpdatedDate { get; set; }
    }
}
