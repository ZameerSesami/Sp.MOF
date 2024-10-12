namespace Sp.MOF.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ValidityPeriod", @"QuotationDocumentReference", @"OrderDocumentReference", @"OriginatorDocumentReference", @"AdditionalDocumentReference", @"Contract", @"BuyerCustomerParty", @"SellerSupplierParty", @"OriginatorCustomerParty", @"AccountingCustomerParty", @"Delivery", @"DeliveryTerms", @"AllowanceCharge", @"TaxTotal", @"AnticipatedMonetaryTotal", @"OrderLine"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.MOF.Schemas.PeppolPOMOF1", typeof(global::Sp.MOF.Schemas.PeppolPOMOF1))]
    public sealed class PeppolPOMOF2 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Sp.MOF.Schemas.PeppolPOMOF1"" namespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ValidityPeriod"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q1:EndDate"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QuotationDocumentReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q2:ID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OrderDocumentReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q3=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q3:ID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OriginatorDocumentReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q4=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q4:ID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AdditionalDocumentReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q5=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q5:ID"" />
        <xs:element xmlns:q6=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q6:DocumentType"" />
        <xs:element name=""Attachment"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ExternalReference"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q7=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q7:URI"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Contract"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q8=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q8:ID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""BuyerCustomerParty"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Party"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q9=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q9:EndpointID"" />
              <xs:element name=""PartyIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q10=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q10:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyName"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q11=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q11:Name"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PostalAddress"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q12=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q12:StreetName"" />
                    <xs:element xmlns:q13=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q13:AdditionalStreetName"" />
                    <xs:element xmlns:q14=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q14:CityName"" />
                    <xs:element xmlns:q15=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q15:PostalZone"" />
                    <xs:element xmlns:q16=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q16:CountrySubentity"" />
                    <xs:element name=""Country"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q17=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q17:IdentificationCode"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyTaxScheme"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q18=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q18:CompanyID"" />
                    <xs:element name=""TaxScheme"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q19=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q19:ID"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyLegalEntity"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q20=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q20:RegistrationName"" />
                    <xs:element xmlns:q21=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q21:CompanyID"" />
                    <xs:element name=""RegistrationAddress"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q22=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q22:CityName"" />
                          <xs:element name=""Country"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element xmlns:q23=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q23:IdentificationCode"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Contact"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q24=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q24:Name"" />
                    <xs:element xmlns:q25=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q25:Telephone"" />
                    <xs:element xmlns:q26=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q26:ElectronicMail"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SellerSupplierParty"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Party"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q27=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q27:EndpointID"" />
              <xs:element name=""PartyIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q28=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q28:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PostalAddress"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q29=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q29:StreetName"" />
                    <xs:element xmlns:q30=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q30:AdditionalStreetName"" />
                    <xs:element xmlns:q31=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q31:CityName"" />
                    <xs:element xmlns:q32=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q32:PostalZone"" />
                    <xs:element xmlns:q33=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q33:CountrySubentity"" />
                    <xs:element name=""AddressLine"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q34=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q34:Line"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""Country"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q35=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q35:IdentificationCode"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyLegalEntity"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q36=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q36:RegistrationName"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Contact"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q37=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q37:Name"" />
                    <xs:element xmlns:q38=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q38:Telephone"" />
                    <xs:element xmlns:q39=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q39:ElectronicMail"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OriginatorCustomerParty"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Party"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""PartyIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q40=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q40:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyName"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q41=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q41:Name"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Contact"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q42=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q42:Name"" />
                    <xs:element xmlns:q43=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q43:Telephone"" />
                    <xs:element xmlns:q44=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q44:ElectronicMail"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AccountingCustomerParty"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Party"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q45=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q45:EndpointID"" />
              <xs:element name=""PartyIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q46=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q46:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyName"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q47=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q47:Name"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PostalAddress"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q48=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q48:StreetName"" />
                    <xs:element xmlns:q49=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q49:AdditionalStreetName"" />
                    <xs:element xmlns:q50=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q50:CityName"" />
                    <xs:element xmlns:q51=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q51:PostalZone"" />
                    <xs:element xmlns:q52=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q52:CountrySubentity"" />
                    <xs:element name=""Country"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q53=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q53:IdentificationCode"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyLegalEntity"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q54=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q54:RegistrationName"" />
                    <xs:element xmlns:q55=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q55:CompanyID"" />
                    <xs:element name=""RegistrationAddress"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q56=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q56:CityName"" />
                          <xs:element name=""Country"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element xmlns:q57=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q57:IdentificationCode"" />
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
  <xs:element name=""Delivery"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""DeliveryLocation"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q58=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q58:ID"" />
              <xs:element xmlns:q59=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q59:Name"" />
              <xs:element name=""Address"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q60=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q60:StreetName"" />
                    <xs:element xmlns:q61=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q61:AdditionalStreetName"" />
                    <xs:element xmlns:q62=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q62:CityName"" />
                    <xs:element xmlns:q63=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q63:PostalZone"" />
                    <xs:element name=""AddressLine"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q64=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q64:Line"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""Country"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q65=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q65:IdentificationCode"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""RequestedDeliveryPeriod"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q66=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q66:StartDate"" />
              <xs:element xmlns:q67=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q67:EndDate"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""DeliveryParty"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""PartyIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q68=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q68:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyName"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q69=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q69:Name"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PostalAddress"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q70=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q70:StreetName"" />
                    <xs:element xmlns:q71=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q71:AdditionalStreetName"" />
                    <xs:element xmlns:q72=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q72:CityName"" />
                    <xs:element xmlns:q73=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q73:PostalZone"" />
                    <xs:element name=""AddressLine"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q74=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q74:Line"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""Country"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q75=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q75:IdentificationCode"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Contact"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q76=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q76:Name"" />
                    <xs:element xmlns:q77=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q77:Telephone"" />
                    <xs:element xmlns:q78=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q78:ElectronicMail"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DeliveryTerms"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q79=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q79:ID"" />
        <xs:element xmlns:q80=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q80:SpecialTerms"" />
        <xs:element name=""DeliveryLocation"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q81=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q81:ID"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AllowanceCharge"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q82=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q82:ChargeIndicator"" />
        <xs:element xmlns:q83=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q83:AllowanceChargeReason"" />
        <xs:element xmlns:q84=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q84:Amount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxTotal"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q85=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q85:TaxAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AnticipatedMonetaryTotal"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q86=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q86:LineExtensionAmount"" />
        <xs:element xmlns:q87=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q87:TaxExclusiveAmount"" />
        <xs:element xmlns:q88=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q88:TaxInclusiveAmount"" />
        <xs:element xmlns:q89=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q89:AllowanceTotalAmount"" />
        <xs:element xmlns:q90=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q90:ChargeTotalAmount"" />
        <xs:element xmlns:q91=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q91:PayableRoundingAmount"" />
        <xs:element xmlns:q92=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q92:PayableAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OrderLine"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q93=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" minOccurs=""0"" ref=""q93:Note"" />
        <xs:element name=""LineItem"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q94=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q94:ID"" />
              <xs:element xmlns:q95=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q95:Quantity"" />
              <xs:element xmlns:q96=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q96:LineExtensionAmount"" />
              <xs:element xmlns:q97=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" minOccurs=""0"" ref=""q97:PartialDeliveryIndicator"" />
              <xs:element xmlns:q98=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q98:AccountingCost"" />
              <xs:element minOccurs=""0"" name=""Delivery"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""RequestedDeliveryPeriod"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q99=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q99:StartDate"" />
                          <xs:element xmlns:q100=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q100:EndDate"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""OriginatorParty"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""PartyIdentification"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q101=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q101:ID"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""PartyName"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q102=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q102:Name"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Price"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q103=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q103:PriceAmount"" />
                    <xs:element xmlns:q104=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" minOccurs=""0"" ref=""q104:BaseQuantity"" />
                    <xs:element minOccurs=""0"" name=""AllowanceCharge"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q105=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q105:ChargeIndicator"" />
                          <xs:element xmlns:q106=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q106:Amount"" />
                          <xs:element xmlns:q107=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q107:BaseAmount"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Item"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q108=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q108:Description"" />
                    <xs:element xmlns:q109=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q109:Name"" />
                    <xs:element name=""SellersItemIdentification"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q110=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q110:ID"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""StandardItemIdentification"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q111=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q111:ID"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""CommodityClassification"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q112=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q112:ItemClassificationCode"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""ClassifiedTaxCategory"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q113=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q113:ID"" />
                          <xs:element xmlns:q114=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q114:Percent"" />
                          <xs:element name=""TaxScheme"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element xmlns:q115=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q115:ID"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element maxOccurs=""unbounded"" name=""AdditionalItemProperty"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q116=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q116:Name"" />
                          <xs:element xmlns:q117=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q117:Value"" />
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
        
        public PeppolPOMOF2() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [16];
                _RootElements[0] = "ValidityPeriod";
                _RootElements[1] = "QuotationDocumentReference";
                _RootElements[2] = "OrderDocumentReference";
                _RootElements[3] = "OriginatorDocumentReference";
                _RootElements[4] = "AdditionalDocumentReference";
                _RootElements[5] = "Contract";
                _RootElements[6] = "BuyerCustomerParty";
                _RootElements[7] = "SellerSupplierParty";
                _RootElements[8] = "OriginatorCustomerParty";
                _RootElements[9] = "AccountingCustomerParty";
                _RootElements[10] = "Delivery";
                _RootElements[11] = "DeliveryTerms";
                _RootElements[12] = "AllowanceCharge";
                _RootElements[13] = "TaxTotal";
                _RootElements[14] = "AnticipatedMonetaryTotal";
                _RootElements[15] = "OrderLine";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"ValidityPeriod")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ValidityPeriod"})]
        public sealed class ValidityPeriod : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ValidityPeriod() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ValidityPeriod";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"QuotationDocumentReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"QuotationDocumentReference"})]
        public sealed class QuotationDocumentReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public QuotationDocumentReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "QuotationDocumentReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"OrderDocumentReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderDocumentReference"})]
        public sealed class OrderDocumentReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderDocumentReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderDocumentReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"OriginatorDocumentReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OriginatorDocumentReference"})]
        public sealed class OriginatorDocumentReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OriginatorDocumentReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OriginatorDocumentReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"AdditionalDocumentReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AdditionalDocumentReference"})]
        public sealed class AdditionalDocumentReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AdditionalDocumentReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AdditionalDocumentReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"Contract")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Contract"})]
        public sealed class Contract : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Contract() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Contract";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"BuyerCustomerParty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BuyerCustomerParty"})]
        public sealed class BuyerCustomerParty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BuyerCustomerParty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BuyerCustomerParty";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"SellerSupplierParty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SellerSupplierParty"})]
        public sealed class SellerSupplierParty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SellerSupplierParty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SellerSupplierParty";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"OriginatorCustomerParty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OriginatorCustomerParty"})]
        public sealed class OriginatorCustomerParty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OriginatorCustomerParty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OriginatorCustomerParty";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"AccountingCustomerParty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AccountingCustomerParty"})]
        public sealed class AccountingCustomerParty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AccountingCustomerParty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AccountingCustomerParty";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"Delivery")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Delivery"})]
        public sealed class Delivery : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Delivery() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Delivery";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"DeliveryTerms")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DeliveryTerms"})]
        public sealed class DeliveryTerms : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DeliveryTerms() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DeliveryTerms";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"AllowanceCharge")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AllowanceCharge"})]
        public sealed class AllowanceCharge : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AllowanceCharge() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AllowanceCharge";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"TaxTotal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxTotal"})]
        public sealed class TaxTotal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxTotal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxTotal";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"AnticipatedMonetaryTotal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AnticipatedMonetaryTotal"})]
        public sealed class AnticipatedMonetaryTotal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AnticipatedMonetaryTotal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AnticipatedMonetaryTotal";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"OrderLine")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderLine"})]
        public sealed class OrderLine : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderLine() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderLine";
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
}
