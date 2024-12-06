namespace Sp.MOF.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"PURCHASE_ORDER_DATA")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PURCHASE_ORDER_DATA"})]
    public sealed class CumulusPO : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PURCHASE_ORDER_DATA"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PURCHASE_ORDER"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""HEADER"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""COMPANY_UEN"" type=""xs:string"" />
                    <xs:element name=""COMPANY_NAME"" type=""xs:string"" />
                    <xs:element name=""ORDER_CODE"" type=""xs:string"" />
                    <xs:element name=""VARIATION_NUMBER"" type=""xs:string"" />
                    <xs:element name=""DESCRIPTION"" type=""xs:string"" />
                    <xs:element name=""STATUS_DATE"" type=""xs:date"" />
                    <xs:element name=""CURRENCY_CODE"" type=""xs:string"" />
                    <xs:element name=""PAYMENT_TERMS"" type=""xs:string"" />
                    <xs:element name=""SUB_BUSINESS_UNIT"" type=""xs:string"" />
                    <xs:element name=""SUPPLIER"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""CODE"" type=""xs:string"" />
                          <xs:element name=""SUPPLIER_NAME"" type=""xs:string"" />
                          <xs:element name=""ADDRESS"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""CITY"" type=""xs:string"" />
                                <xs:element name=""POSTALCODE"" type=""xs:string"" />
                                <xs:element name=""ADDRESS_LINE"" type=""xs:string"" />
                                <xs:element name=""COUNTRY"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""DELIVERY_DESTINATION"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""ITEMS"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ITEM"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""LINE_NUMBER"" type=""xs:string"" />
                                <xs:element name=""DESCRIPTION"" type=""xs:string"" />
                                <xs:element name=""UNIT_OF_MEASURE"" type=""xs:string"" />
                                <xs:element name=""UNIT_PRICE"" type=""xs:string"" />
                                <xs:element name=""QUANTITY"" type=""xs:string"" />
                                <xs:element name=""TOTAL_AMOUNT"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CumulusPO() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PURCHASE_ORDER_DATA";
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
