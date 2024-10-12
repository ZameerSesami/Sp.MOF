namespace Sp.MOF.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"PeppolAPIResponse")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Boolean), "Succeed", XPath = @"/*[local-name()='PeppolAPIResponse' and namespace-uri()='']/*[local-name()='Succeed' and namespace-uri()='']", XsdType = @"boolean")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "InvoiceSubmissionID", XPath = @"/*[local-name()='PeppolAPIResponse' and namespace-uri()='']/*[local-name()='InvoiceSubmissionID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Timestamp", XPath = @"/*[local-name()='PeppolAPIResponse' and namespace-uri()='']/*[local-name()='Timestamp' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ErrorDescription", XPath = @"/*[local-name()='PeppolAPIResponse' and namespace-uri()='']/*[local-name()='ErrorDescription' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PeppolAPIResponse"})]
    public sealed class PeppolAPIResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PeppolAPIResponse"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='PeppolAPIResponse' and namespace-uri()='']/*[local-name()='Succeed' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PeppolAPIResponse' and namespace-uri()='']/*[local-name()='InvoiceSubmissionID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PeppolAPIResponse' and namespace-uri()='']/*[local-name()='Timestamp' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PeppolAPIResponse' and namespace-uri()='']/*[local-name()='ErrorDescription' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Succeed"" type=""xs:boolean"" />
        <xs:element name=""InvoiceSubmissionID"" type=""xs:string"" />
        <xs:element name=""ErrorDescription"" type=""xs:string"" />
        <xs:element name=""Timestamp"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PeppolAPIResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PeppolAPIResponse";
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
