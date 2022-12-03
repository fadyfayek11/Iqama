using Iqama.Data.DataTransfer.Response;

namespace Iqama.Data.DataTransfer.Request
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class policyContract
    {

        private byte addressField;

        private Beneficiaries beneficiariesField;

        private uint borderNumberField;

        private string cityField;

        private byte companyNumberField;

        private string emailField;

        private string expiaryDateField;

        private byte insuranceDurationField;

        private System.DateTime issueDateField;

        private byte maritalStatusField;

        private byte merchantIDField;

        private uint mobileField;

        private string nationalityField;

        private uint passportNumberField;

        private byte poBoxField;

        private string policyLinkARField;

        private string policyLinkENField;

        private byte policyNumberField;

        private byte priceField;

        private uint visaNumberField;

        private byte visaTypeField;

        private byte visaValidityField;

        private byte visitTypeField;

        private ushort zipCodeField;

        private byte eNumberField;

        /// <remarks/>
        public byte Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public Beneficiaries Beneficiaries
        {
            get
            {
                return this.beneficiariesField;
            }
            set
            {
                this.beneficiariesField = value;
            }
        }

        /// <remarks/>
        public uint BorderNumber
        {
            get
            {
                return this.borderNumberField;
            }
            set
            {
                this.borderNumberField = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public byte CompanyNumber
        {
            get
            {
                return this.companyNumberField;
            }
            set
            {
                this.companyNumberField = value;
            }
        }

        /// <remarks/>
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public string ExpiaryDate
        {
            get
            {
                return this.expiaryDateField;
            }
            set
            {
                this.expiaryDateField = value;
            }
        }

        /// <remarks/>
        public byte InsuranceDuration
        {
            get
            {
                return this.insuranceDurationField;
            }
            set
            {
                this.insuranceDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public byte MaritalStatus
        {
            get
            {
                return this.maritalStatusField;
            }
            set
            {
                this.maritalStatusField = value;
            }
        }

        /// <remarks/>
        public byte MerchantID
        {
            get
            {
                return this.merchantIDField;
            }
            set
            {
                this.merchantIDField = value;
            }
        }

        /// <remarks/>
        public uint Mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }

        /// <remarks/>
        public string Nationality
        {
            get
            {
                return this.nationalityField;
            }
            set
            {
                this.nationalityField = value;
            }
        }

        /// <remarks/>
        public uint PassportNumber
        {
            get
            {
                return this.passportNumberField;
            }
            set
            {
                this.passportNumberField = value;
            }
        }

        /// <remarks/>
        public byte PoBox
        {
            get
            {
                return this.poBoxField;
            }
            set
            {
                this.poBoxField = value;
            }
        }

        /// <remarks/>
        public string PolicyLinkAR
        {
            get
            {
                return this.policyLinkARField;
            }
            set
            {
                this.policyLinkARField = value;
            }
        }

        /// <remarks/>
        public string PolicyLinkEN
        {
            get
            {
                return this.policyLinkENField;
            }
            set
            {
                this.policyLinkENField = value;
            }
        }

        /// <remarks/>
        public byte PolicyNumber
        {
            get
            {
                return this.policyNumberField;
            }
            set
            {
                this.policyNumberField = value;
            }
        }

        /// <remarks/>
        public byte Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public uint VisaNumber
        {
            get
            {
                return this.visaNumberField;
            }
            set
            {
                this.visaNumberField = value;
            }
        }

        /// <remarks/>
        public byte VisaType
        {
            get
            {
                return this.visaTypeField;
            }
            set
            {
                this.visaTypeField = value;
            }
        }

        /// <remarks/>
        public byte VisaValidity
        {
            get
            {
                return this.visaValidityField;
            }
            set
            {
                this.visaValidityField = value;
            }
        }

        /// <remarks/>
        public byte VisitType
        {
            get
            {
                return this.visitTypeField;
            }
            set
            {
                this.visitTypeField = value;
            }
        }

        /// <remarks/>
        public ushort ZipCode
        {
            get
            {
                return this.zipCodeField;
            }
            set
            {
                this.zipCodeField = value;
            }
        }

        /// <remarks/>
        public byte eNumber
        {
            get
            {
                return this.eNumberField;
            }
            set
            {
                this.eNumberField = value;
            }
        }
    }
}
