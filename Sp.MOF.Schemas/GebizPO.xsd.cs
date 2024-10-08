namespace Sp.MOF.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"GEBIZ_ORDER")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"GEBIZ_ORDER"})]
    public sealed class GebizPO : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""GEBIZ_ORDER"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""HEADER"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""MINISTRY_CODE"" type=""xs:string"" />
              <xs:element name=""DEPARTMENT_CODE"" type=""xs:unsignedByte"" />
              <xs:element name=""ORDER_CODE"" type=""xs:string"" />
              <xs:element name=""EXTERNAL_SYSTEM_CODE"" type=""xs:string"" />
              <xs:element name=""AMENDMENT_NUMBER"" type=""xs:unsignedByte"" />
              <xs:element name=""VARIATION_NUMBER"" type=""xs:unsignedByte"" />
              <xs:element name=""DESCRIPTION"" type=""xs:string"" />
              <xs:element name=""STATUS"" type=""xs:string"" />
              <xs:element name=""FS_STATUS"" type=""xs:string"" />
              <xs:element name=""STATUS_DATE"" type=""xs:dateTime"" />
              <xs:element name=""PAYMENT_TERMS"" type=""xs:string"" />
              <xs:element name=""BILL_TO"" type=""xs:string"" />
              <xs:element name=""CREATE_TIMESTAMP"" type=""xs:dateTime"" />
              <xs:element name=""TERMINATE_REASON"" nillable=""true"" type=""xs:anyType"" />
              <xs:element name=""TERMINATE_TIMESTAMP"" type=""xs:dateTime"" />
              <xs:element name=""ORDER_TYPE"" type=""xs:unsignedByte"" />
              <xs:element name=""FINANCIAL_SYSTEM"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""SUB_BUSINESS_UNIT"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""SUPPLIER"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""CODE"" type=""xs:string"" />
                    <xs:element name=""NAME"" type=""xs:string"" />
                    <xs:element name=""GST_NUMBER"" type=""xs:string"" />
                    <xs:element name=""CONTACT_NAME"" type=""xs:string"" />
                    <xs:element name=""CONTACT_PHONE"" type=""xs:unsignedInt"" />
                    <xs:element name=""CONTACT_EMAIL"" type=""xs:string"" />
                    <xs:element name=""CONTACT_FAX"" type=""xs:unsignedInt"" />
                    <xs:element name=""SITES"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""SITE"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""ID"" type=""xs:unsignedByte"" />
                                <xs:element name=""NAME"" type=""xs:string"" />
                                <xs:element name=""PHONE"" type=""xs:unsignedInt"" />
                                <xs:element name=""PHONE_EXTENSION"" nillable=""true"" type=""xs:anyType"" />
                                <xs:element name=""FAX"" type=""xs:unsignedInt"" />
                                <xs:element name=""EMAIL"" type=""xs:string"" />
                                <xs:element name=""ADDRESS_LINE1"" type=""xs:string"" />
                                <xs:element name=""ADDRESS_LINE2"" type=""xs:string"" />
                                <xs:element name=""ADDRESS_LINE3"" nillable=""true"" type=""xs:anyType"" />
                                <xs:element name=""COUNTRY_CODE"" type=""xs:string"" />
                                <xs:element name=""PROVINCE"" type=""xs:string"" />
                                <xs:element name=""STATE"" type=""xs:string"" />
                                <xs:element name=""CITY"" type=""xs:string"" />
                                <xs:element name=""AREA_CODE"" type=""xs:unsignedInt"" />
                                <xs:element name=""ZIP"" type=""xs:unsignedInt"" />
                                <xs:element name=""REGION_CODE"" nillable=""true"" type=""xs:anyType"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""USER"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""NAME"" type=""xs:string"" />
                    <xs:element name=""ORGANISATION_NAME"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""FUND_COMMIT_AMOUNT"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""CURRENCY_CODE"" type=""xs:string"" />
                    <xs:element name=""CURRENCY_AMOUNT"" type=""xs:unsignedByte"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""BUYER"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ORGANISATION_CODE"" type=""xs:unsignedByte"" />
                    <xs:element name=""ORGANISATION_NAME"" type=""xs:string"" />
                    <xs:element name=""NAME"" type=""xs:string"" />
                    <xs:element name=""PHONE"" type=""xs:unsignedInt"" />
                    <xs:element name=""FAX"" type=""xs:unsignedInt"" />
                    <xs:element name=""EMAIL"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""ITEMS"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""ITEM"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""LINE_NUMBER"" type=""xs:unsignedByte"" />
                    <xs:element name=""STATUS"" type=""xs:string"" />
                    <xs:element name=""STATUS_DATE"" type=""xs:dateTime"" />
                    <xs:element name=""DESCRIPTION"" type=""xs:string"" />
                    <xs:element name=""UNIT_OF_MEASURE"" type=""xs:string"" />
                    <xs:element name=""QUANTITY"" type=""xs:decimal"" />
                    <xs:element name=""LINE_TYPE"" type=""xs:string"" />
                    <xs:element name=""SERVICE_ORDER"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ORIG_UNIT_PRICE"" type=""xs:decimal"" />
                          <xs:element name=""ORIG_UNIT_OF_MEASURE"" type=""xs:string"" />
                          <xs:element name=""ORIG_QUANTITY"" type=""xs:unsignedByte"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""UNIT_PRICE"" type=""xs:decimal"" />
                    <xs:element name=""PRICE_UNIT"" type=""xs:unsignedByte"" />
                    <xs:element name=""TOTAL_AMOUNT"" type=""xs:decimal"" />
                    <xs:element name=""MATERIAL_MASTER_CODE"" nillable=""true"" type=""xs:anyType"" />
                    <xs:element name=""MATERIAL_GROUP_CODE"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""PLANT_CODE"" nillable=""true"" type=""xs:anyType"" />
                    <xs:element minOccurs=""0"" name=""ITEM_CATEGORY_CODE"" nillable=""true"" type=""xs:anyType"" />
                    <xs:element name=""INSTRUCTION_TO_SUPPLIER"" nillable=""true"" type=""xs:anyType"" />
                    <xs:element name=""PART_NUMBER_INFORMATION"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""NATO_STOCK_NUMBER"" nillable=""true"" type=""xs:anyType"" />
                          <xs:element name=""MANUFACTURER_PART_NUMBER"" nillable=""true"" type=""xs:anyType"" />
                          <xs:element name=""PART_NUMBER"" nillable=""true"" type=""xs:anyType"" />
                          <xs:element name=""CAGE_CODE"" nillable=""true"" type=""xs:anyType"" />
                          <xs:element name=""CAGE_NAME"" nillable=""true"" type=""xs:anyType"" />
                          <xs:element name=""ITEM_CONDITION"" nillable=""true"" type=""xs:anyType"" />
                          <xs:element name=""MINIMUM_SHELF_LIFE"" type=""xs:unsignedByte"" />
                          <xs:element name=""SHELF_LIFE_REMAINING"" type=""xs:string"" />
                          <xs:element name=""CERTIFICATE_OF_CONFORMANCE"" nillable=""true"" type=""xs:anyType"" />
                          <xs:element name=""EXPORT_LICENSE"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""LOCATIONS"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""LOCATION"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""LINE_NUMBER"" type=""xs:unsignedByte"" />
                                <xs:element name=""STATUS"" type=""xs:string"" />
                                <xs:element name=""STATUS_DATE"" type=""xs:dateTime"" />
                                <xs:element name=""QUANTITY"" type=""xs:decimal"" />
                                <xs:element name=""DELIVERY_DESTINATION"" type=""xs:string"" />
                                <xs:element name=""DELIVERY_DATE"" type=""xs:dateTime"" />
                                <xs:element name=""DELIVERY_TERMS"" type=""xs:string"" />
                                <xs:element name=""PORT_OF_ORIGIN"" type=""xs:string"" />
                                <xs:element name=""RECIPIENT"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""NAME"" type=""xs:string"" />
                                      <xs:element name=""PHONE"" type=""xs:unsignedInt"" />
                                      <xs:element name=""EMAIL"" type=""xs:string"" />
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
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GebizPO() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "GEBIZ_ORDER";
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
