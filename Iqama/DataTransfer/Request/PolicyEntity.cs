namespace Iqama.Data.DataTransfer.Request
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PolicyEntity
    {

        private string addressField;

        private PolicyEntityBeneficiaryContract[] beneficiariesField;

        private string cityField;

        private string emailField;

        private byte insuranceDurationField;

        private byte maritalStatusField;

        private ulong mobileField;

        private string nationalityField;

        private ushort pOBoxField;

        private uint passportNumberField;

        private string eNumberField;

        private byte visaTypeField;

        private byte visitTypeField;

        private byte visaValidityField;

        private ushort zIPCodeField;

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
        [System.Xml.Serialization.XmlArrayItemAttribute("BeneficiaryContract", IsNullable = false)]
        public PolicyEntityBeneficiaryContract[] Beneficiaries
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
        public ushort POBox
        {
            get
            {
                return this.pOBoxField;
            }
            set
            {
                this.pOBoxField = value;
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
        public string eNumber
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
        public ushort ZIPCode
        {
            get
            {
                return this.zIPCodeField;
            }
            set
            {
                this.zIPCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PolicyEntityBeneficiaryContract
    {

        private byte beneficiaryTypeField;

        private System.DateTime dateOfBirthField;

        private BeneficiaryContractDeclarationForm declarationFormField;

        private byte genderField;

        private string nameField;

        private string relationTypeField;

        /// <remarks/>
        public byte BeneficiaryType
        {
            get
            {
                return this.beneficiaryTypeField;
            }
            set
            {
                this.beneficiaryTypeField = value;
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
        public BeneficiaryContractDeclarationForm DeclarationForm
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
    public partial class BeneficiaryContractDeclarationForm
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
