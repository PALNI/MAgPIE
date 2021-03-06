﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 
namespace ZondervanLibrary.PatronTranslator.Console.Patrons {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    [System.Xml.Serialization.XmlRootAttribute("oclcPersonas", Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2", IsNullable=false)]
    public partial class OclcPersonas {
        
        private Persona[] personaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("persona")]
        public Persona[] persona {
            get {
                return this.personaField;
            }
            set {
                this.personaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public partial class Persona {
        
        private CorrelationInfo[] correlationInfoField;
        
        private string oclcUserNameField;
        
        private System.DateTime oclcExpirationDateField;
        
        private bool oclcExpirationDateFieldSpecified;
        
        private NameInfo nameInfoField;
        
        private string nicknameField;
        
        private System.DateTime dateOfBirthField;
        
        private bool dateOfBirthFieldSpecified;
        
        private PersonaGender genderField;
        
        private bool genderFieldSpecified;
        
        private WmsCircPatronInfo wmsCircPatronInfoField;
        
        private WsILLInfo wsILLInfoField;
        
        private ContactInfo[] contactInfoField;
        
        private NotificationDeliveryDestination[] notificationDeliveryDestinationField;
        
        private Note[] noteField;
        
        private KeyValuePair[] additionalInfoField;
        
        private string photoURLField;
        
        private string institutionIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("correlationInfo")]
        public CorrelationInfo[] correlationInfo {
            get {
                return this.correlationInfoField;
            }
            set {
                this.correlationInfoField = value;
            }
        }
        
        /// <remarks/>
        public string oclcUserName {
            get {
                return this.oclcUserNameField;
            }
            set {
                this.oclcUserNameField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime oclcExpirationDate {
            get {
                return this.oclcExpirationDateField;
            }
            set {
                this.oclcExpirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool oclcExpirationDateSpecified {
            get {
                return this.oclcExpirationDateFieldSpecified;
            }
            set {
                this.oclcExpirationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public NameInfo nameInfo {
            get {
                return this.nameInfoField;
            }
            set {
                this.nameInfoField = value;
            }
        }
        
        /// <remarks/>
        public string nickname {
            get {
                return this.nicknameField;
            }
            set {
                this.nicknameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime dateOfBirth {
            get {
                return this.dateOfBirthField;
            }
            set {
                this.dateOfBirthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateOfBirthSpecified {
            get {
                return this.dateOfBirthFieldSpecified;
            }
            set {
                this.dateOfBirthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PersonaGender gender {
            get {
                return this.genderField;
            }
            set {
                this.genderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified {
            get {
                return this.genderFieldSpecified;
            }
            set {
                this.genderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public WmsCircPatronInfo wmsCircPatronInfo {
            get {
                return this.wmsCircPatronInfoField;
            }
            set {
                this.wmsCircPatronInfoField = value;
            }
        }
        
        /// <remarks/>
        public WsILLInfo wsILLInfo {
            get {
                return this.wsILLInfoField;
            }
            set {
                this.wsILLInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contactInfo")]
        public ContactInfo[] contactInfo {
            get {
                return this.contactInfoField;
            }
            set {
                this.contactInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("notificationDeliveryDestination")]
        public NotificationDeliveryDestination[] notificationDeliveryDestination {
            get {
                return this.notificationDeliveryDestinationField;
            }
            set {
                this.notificationDeliveryDestinationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("note")]
        public Note[] note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalInfo")]
        public KeyValuePair[] additionalInfo {
            get {
                return this.additionalInfoField;
            }
            set {
                this.additionalInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string photoURL {
            get {
                return this.photoURLField;
            }
            set {
                this.photoURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string institutionId {
            get {
                return this.institutionIdField;
            }
            set {
                this.institutionIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public partial class CorrelationInfo {
        
        private string sourceSystemField;
        
        private string idAtSourceField;
        
        /// <remarks/>
        public string sourceSystem {
            get {
                return this.sourceSystemField;
            }
            set {
                this.sourceSystemField = value;
            }
        }
        
        /// <remarks/>
        public string idAtSource {
            get {
                return this.idAtSourceField;
            }
            set {
                this.idAtSourceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public partial class KeyValuePair {
        
        private string businessContextField;
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        public string businessContext {
            get {
                return this.businessContextField;
            }
            set {
                this.businessContextField = value;
            }
        }
        
        /// <remarks/>
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public partial class Note {
        
        private string textField;
        
        /// <remarks/>
        public string text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public partial class NotificationDeliveryDestination {
        
        private NotificationDeliveryDestinationDeliveryService deliveryServiceField;
        
        private string destinationField;
        
        /// <remarks/>
        public NotificationDeliveryDestinationDeliveryService deliveryService {
            get {
                return this.deliveryServiceField;
            }
            set {
                this.deliveryServiceField = value;
            }
        }
        
        /// <remarks/>
        public string destination {
            get {
                return this.destinationField;
            }
            set {
                this.destinationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public enum NotificationDeliveryDestinationDeliveryService {
        
        /// <remarks/>
        Email,
        
        /// <remarks/>
        SMS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public partial class Phone {
        
        private string numberField;
        
        private bool isPrimaryField;
        
        private bool isPrimaryFieldSpecified;
        
        /// <remarks/>
        public string number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        public bool isPrimary {
            get {
                return this.isPrimaryField;
            }
            set {
                this.isPrimaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimarySpecified {
            get {
                return this.isPrimaryFieldSpecified;
            }
            set {
                this.isPrimaryFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public partial class EmailAddress {
        
        private string emailAddressField;
        
        private bool isPrimaryField;
        
        private bool isPrimaryFieldSpecified;
        
        /// <remarks/>
        public string emailAddress {
            get {
                return this.emailAddressField;
            }
            set {
                this.emailAddressField = value;
            }
        }
        
        /// <remarks/>
        public bool isPrimary {
            get {
                return this.isPrimaryField;
            }
            set {
                this.isPrimaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimarySpecified {
            get {
                return this.isPrimaryFieldSpecified;
            }
            set {
                this.isPrimaryFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public partial class PostalAddress {
        
        private string streetAddressLine1Field;
        
        private string streetAddressLine2Field;
        
        private string cityOrLocalityField;
        
        private string stateOrProvinceField;
        
        private string postalCodeField;
        
        private string countryField;
        
        private bool isPrimaryField;
        
        private bool isPrimaryFieldSpecified;
        
        private bool isPermanentField;
        
        private bool isPermanentFieldSpecified;
        
        private System.DateTime validFromField;
        
        private bool validFromFieldSpecified;
        
        private System.DateTime validToField;
        
        private bool validToFieldSpecified;
        
        /// <remarks/>
        public string streetAddressLine1 {
            get {
                return this.streetAddressLine1Field;
            }
            set {
                this.streetAddressLine1Field = value;
            }
        }
        
        /// <remarks/>
        public string streetAddressLine2 {
            get {
                return this.streetAddressLine2Field;
            }
            set {
                this.streetAddressLine2Field = value;
            }
        }
        
        /// <remarks/>
        public string cityOrLocality {
            get {
                return this.cityOrLocalityField;
            }
            set {
                this.cityOrLocalityField = value;
            }
        }
        
        /// <remarks/>
        public string stateOrProvince {
            get {
                return this.stateOrProvinceField;
            }
            set {
                this.stateOrProvinceField = value;
            }
        }
        
        /// <remarks/>
        public string postalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        public bool isPrimary {
            get {
                return this.isPrimaryField;
            }
            set {
                this.isPrimaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimarySpecified {
            get {
                return this.isPrimaryFieldSpecified;
            }
            set {
                this.isPrimaryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool isPermanent {
            get {
                return this.isPermanentField;
            }
            set {
                this.isPermanentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPermanentSpecified {
            get {
                return this.isPermanentFieldSpecified;
            }
            set {
                this.isPermanentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime validFrom {
            get {
                return this.validFromField;
            }
            set {
                this.validFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validFromSpecified {
            get {
                return this.validFromFieldSpecified;
            }
            set {
                this.validFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime validTo {
            get {
                return this.validToField;
            }
            set {
                this.validToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validToSpecified {
            get {
                return this.validToFieldSpecified;
            }
            set {
                this.validToFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public partial class ContactInfo {
        
        private object[] itemsField;
        
        private string labelField;
        
        private bool isInvalidField;
        
        private bool isInvalidFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("email", typeof(EmailAddress))]
        [System.Xml.Serialization.XmlElementAttribute("phone", typeof(Phone))]
        [System.Xml.Serialization.XmlElementAttribute("postalAddress", typeof(PostalAddress))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        public bool isInvalid {
            get {
                return this.isInvalidField;
            }
            set {
                this.isInvalidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInvalidSpecified {
            get {
                return this.isInvalidFieldSpecified;
            }
            set {
                this.isInvalidFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public partial class WsILLInfo {
        
        private string illIdField;
        
        private WsILLInfoIllApprovalStatus illApprovalStatusField;
        
        private bool illApprovalStatusFieldSpecified;
        
        private string illPatronTypeField;
        
        private string illPickupLocationField;
        
        /// <remarks/>
        public string illId {
            get {
                return this.illIdField;
            }
            set {
                this.illIdField = value;
            }
        }
        
        /// <remarks/>
        public WsILLInfoIllApprovalStatus illApprovalStatus {
            get {
                return this.illApprovalStatusField;
            }
            set {
                this.illApprovalStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool illApprovalStatusSpecified {
            get {
                return this.illApprovalStatusFieldSpecified;
            }
            set {
                this.illApprovalStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string illPatronType {
            get {
                return this.illPatronTypeField;
            }
            set {
                this.illPatronTypeField = value;
            }
        }
        
        /// <remarks/>
        public string illPickupLocation {
            get {
                return this.illPickupLocationField;
            }
            set {
                this.illPickupLocationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public enum WsILLInfoIllApprovalStatus {
        
        /// <remarks/>
        Approved,
        
        /// <remarks/>
        New,
        
        /// <remarks/>
        Blocked,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public partial class WmsCircPatronInfo {
        
        private string barcodeField;
        
        private string pinField;
        
        private string borrowerCategoryField;
        
        private System.DateTime circRegistrationDateField;
        
        private bool circRegistrationDateFieldSpecified;
        
        private string homeBranchField;
        
        private bool isCircBlockedField;
        
        private bool isCircBlockedFieldSpecified;
        
        private bool isCollectionExemptField;
        
        private bool isCollectionExemptFieldSpecified;
        
        private bool isFineExemptField;
        
        private bool isFineExemptFieldSpecified;
        
        private bool isVerifiedField;
        
        private bool isVerifiedFieldSpecified;
        
        private bool storeCheckoutHistoryField;
        
        private bool storeCheckoutHistoryFieldSpecified;
        
        /// <remarks/>
        public string barcode {
            get {
                return this.barcodeField;
            }
            set {
                this.barcodeField = value;
            }
        }
        
        /// <remarks/>
        public string pin {
            get {
                return this.pinField;
            }
            set {
                this.pinField = value;
            }
        }
        
        /// <remarks/>
        public string borrowerCategory {
            get {
                return this.borrowerCategoryField;
            }
            set {
                this.borrowerCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime circRegistrationDate {
            get {
                return this.circRegistrationDateField;
            }
            set {
                this.circRegistrationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool circRegistrationDateSpecified {
            get {
                return this.circRegistrationDateFieldSpecified;
            }
            set {
                this.circRegistrationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string homeBranch {
            get {
                return this.homeBranchField;
            }
            set {
                this.homeBranchField = value;
            }
        }
        
        /// <remarks/>
        public bool isCircBlocked {
            get {
                return this.isCircBlockedField;
            }
            set {
                this.isCircBlockedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCircBlockedSpecified {
            get {
                return this.isCircBlockedFieldSpecified;
            }
            set {
                this.isCircBlockedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool isCollectionExempt {
            get {
                return this.isCollectionExemptField;
            }
            set {
                this.isCollectionExemptField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCollectionExemptSpecified {
            get {
                return this.isCollectionExemptFieldSpecified;
            }
            set {
                this.isCollectionExemptFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool isFineExempt {
            get {
                return this.isFineExemptField;
            }
            set {
                this.isFineExemptField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFineExemptSpecified {
            get {
                return this.isFineExemptFieldSpecified;
            }
            set {
                this.isFineExemptFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool isVerified {
            get {
                return this.isVerifiedField;
            }
            set {
                this.isVerifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isVerifiedSpecified {
            get {
                return this.isVerifiedFieldSpecified;
            }
            set {
                this.isVerifiedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool storeCheckoutHistory {
            get {
                return this.storeCheckoutHistoryField;
            }
            set {
                this.storeCheckoutHistoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool storeCheckoutHistorySpecified {
            get {
                return this.storeCheckoutHistoryFieldSpecified;
            }
            set {
                this.storeCheckoutHistoryFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public partial class NameInfo {
        
        private string prefixField;
        
        private string givenNameField;
        
        private string middleNameField;
        
        private string familyNameField;
        
        private string suffixField;
        
        private bool canSelfEditField;
        
        private bool canSelfEditFieldSpecified;
        
        /// <remarks/>
        public string prefix {
            get {
                return this.prefixField;
            }
            set {
                this.prefixField = value;
            }
        }
        
        /// <remarks/>
        public string givenName {
            get {
                return this.givenNameField;
            }
            set {
                this.givenNameField = value;
            }
        }
        
        /// <remarks/>
        public string middleName {
            get {
                return this.middleNameField;
            }
            set {
                this.middleNameField = value;
            }
        }
        
        /// <remarks/>
        public string familyName {
            get {
                return this.familyNameField;
            }
            set {
                this.familyNameField = value;
            }
        }
        
        /// <remarks/>
        public string suffix {
            get {
                return this.suffixField;
            }
            set {
                this.suffixField = value;
            }
        }
        
        /// <remarks/>
        public bool canSelfEdit {
            get {
                return this.canSelfEditField;
            }
            set {
                this.canSelfEditField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool canSelfEditSpecified {
            get {
                return this.canSelfEditFieldSpecified;
            }
            set {
                this.canSelfEditFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://worldcat.org/xmlschemas/IDMPersonas-2.2")]
    public enum PersonaGender {
        
        /// <remarks/>
        UNKNOWN,
        
        /// <remarks/>
        MALE,
        
        /// <remarks/>
        FEMALE,
    }
}
