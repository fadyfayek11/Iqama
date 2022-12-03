namespace Iqama.Data.DataTransfer.Response
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ExtendVisa
    {

        private string addressField;

        private Beneficiaries beneficiariesField;

        private ulong borderNumberField;

        private string cityField;

        private byte companyNumberField;

        private string emailField;

        private System.DateTime expiaryDateField;

        private byte insuranceDurationField;

        private System.DateTime issueDateField;

        private byte maritalStatusField;

        private uint merchantIDField;

        private ulong mobileField;

        private string nationalityField;

        private string passportNumberField;

        private ushort poBoxField;

        private string policyLinkARField;

        private string policyLinkENField;

        private uint policyNumberField;

        private byte priceField;

        private uint visaNumberField;

        private byte visaTypeField;

        private byte visitTypeField;

        private byte visaValidityField;

        private ushort zipCodeField;

        private uint eNumberField;


        /// <remarks/>
        public string Address
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
        public ulong BorderNumber
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ExpiaryDate
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
        public uint MerchantID
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
        public ulong Mobile
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
        public string PassportNumber
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
        public ushort PoBox
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
        public uint PolicyNumber
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
        public uint eNumber
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Beneficiaries
    {

        private BeneficiaryContract beneficiaryContractField;

        /// <remarks/>
        public BeneficiaryContract BeneficiaryContract
        {
            get
            {
                return this.beneficiaryContractField;
            }
            set
            {
                this.beneficiaryContractField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BeneficiaryContract
    {

        private byte beneficaryTypeField;

        private System.DateTime dateOfBirthField;

        private DeclarationForm declarationFormField;

        private byte genderField;

        private string nameField;

        private string relationTypeField;

        /// <remarks/>
        public byte BeneficaryType
        {
            get
            {
                return this.beneficaryTypeField;
            }
            set
            {
                this.beneficaryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirthField;
            }
            set
            {
                this.dateOfBirthField = value;
            }
        }

        /// <remarks/>
        public DeclarationForm DeclarationForm
        {
            get
            {
                return this.declarationFormField;
            }
            set
            {
                this.declarationFormField = value;
            }
        }

        /// <remarks/>
        public byte Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string RelationType
        {
            get
            {
                return this.relationTypeField;
            }
            set
            {
                this.relationTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DeclarationForm
    {

        private bool question1Field;

        private bool question2Field;

        private bool question3Field;

        private bool question4Field;

        private bool question5Field;

        private byte question6Field;

        /// <remarks/>
        public bool Question1
        {
            get
            {
                return this.question1Field;
            }
            set
            {
                this.question1Field = value;
            }
        }

        /// <remarks/>
        public bool Question2
        {
            get
            {
                return this.question2Field;
            }
            set
            {
                this.question2Field = value;
            }
        }

        /// <remarks/>
        public bool Question3
        {
            get
            {
                return this.question3Field;
            }
            set
            {
                this.question3Field = value;
            }
        }

        /// <remarks/>
        public bool Question4
        {
            get
            {
                return this.question4Field;
            }
            set
            {
                this.question4Field = value;
            }
        }

        /// <remarks/>
        public bool Question5
        {
            get
            {
                return this.question5Field;
            }
            set
            {
                this.question5Field = value;
            }
        }

        /// <remarks/>
        public byte Question6
        {
            get
            {
                return this.question6Field;
            }
            set
            {
                this.question6Field = value;
            }
        }
    }
}
