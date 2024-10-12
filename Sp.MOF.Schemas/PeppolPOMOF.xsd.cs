namespace Sp.MOF.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:Order-2",@"Order")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Order"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.MOF.Schemas.PeppolPOMOF1", typeof(global::Sp.MOF.Schemas.PeppolPOMOF1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.MOF.Schemas.PeppolPOMOF2", typeof(global::Sp.MOF.Schemas.PeppolPOMOF2))]
    public sealed class PeppolPOMOF : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:cac=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" xmlns:cbc=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:Order-2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Sp.MOF.Schemas.PeppolPOMOF1"" namespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" />
  <xs:import schemaLocation=""Sp.MOF.Schemas.PeppolPOMOF2"" namespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" />
        <b:reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Order"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""cbc:CustomizationID"" />
        <xs:element ref=""cbc:ProfileID"" />
        <xs:element ref=""cbc:ID"" />
        <xs:element ref=""cbc:IssueDate"" />
        <xs:element ref=""cbc:IssueTime"" />
        <xs:element ref=""cbc:Note"" />
        <xs:element ref=""cbc:DocumentCurrencyCode"" />
        <xs:element ref=""cbc:AccountingCost"" />
        <xs:element ref=""cac:ValidityPeriod"" />
        <xs:element ref=""cac:QuotationDocumentReference"" />
        <xs:element ref=""cac:OrderDocumentReference"" />
        <xs:element ref=""cac:OriginatorDocumentReference"" />
        <xs:element ref=""cac:AdditionalDocumentReference"" />
        <xs:element ref=""cac:Contract"" />
        <xs:element ref=""cac:BuyerCustomerParty"" />
        <xs:element ref=""cac:SellerSupplierParty"" />
        <xs:element ref=""cac:OriginatorCustomerParty"" />
        <xs:element ref=""cac:AccountingCustomerParty"" />
        <xs:element ref=""cac:Delivery"" />
        <xs:element ref=""cac:DeliveryTerms"" />
        <xs:element name=""PaymentTerms"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Note"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element maxOccurs=""unbounded"" ref=""cac:AllowanceCharge"" />
        <xs:element ref=""cac:TaxTotal"" />
        <xs:element ref=""cac:AnticipatedMonetaryTotal"" />
        <xs:element maxOccurs=""unbounded"" ref=""cac:OrderLine"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PeppolPOMOF() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Order";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
