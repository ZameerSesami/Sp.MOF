namespace Sp.MOF.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"POHeaderTableType", @"ArrayOfPOHeaderTableType", @"PODetailsTableType", @"ArrayOfPODetailsTableType"})]
    public sealed class uspPOInsert_TableType_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">TableType.dbo</fileNameHint>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""POHeaderTableType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""HubID"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""MinistryCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DepartmentCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UEN"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""30"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OrderCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""VariationNumber"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Description"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""550"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OrderTypeStatus"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""StatusDate"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PaymentTerms"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""420"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BillTo"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""220"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CreateTimestamp"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OrderType"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SubBusinessUnit"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SupplierCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SupplierName"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""150"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SupplierGST"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SupplierContactName"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""150"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SupplierContactPhone"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""30"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SupplierContactEmail"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""150"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DeliveryDestination"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""500"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteID"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteName"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""150"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SitePhone"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""30"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SitePhoneExt"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteFax"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""30"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteEmail"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""150"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteAddressLine1"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""260"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteAddressLine2"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteAddressLine3"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteCountryCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteProvince"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""30"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteState"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""30"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteCity"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""30"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteAreaCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteZIP"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SiteRegionCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UserName"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UserOrganisationName"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UserOrganisationNameMap"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CurrencyCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CurrencyAmount"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BuyerOrganisationCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BuyerOrganisationName"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BuyerName"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""90"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BuyerPhone"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""30"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BuyerEmail"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""150"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DocumentStatus"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POResponseStatus"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""InterfaceFileName"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""200"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""InterfaceStatus"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""InterfaceDate"" nillable=""true"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""InterfaceMessage"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""555"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""APIStatus"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""APIDate"" nillable=""true"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""APIMessage"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""555"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""POHeaderTableType"" nillable=""true"" type=""ns3:POHeaderTableType"" />
  <xs:complexType name=""ArrayOfPOHeaderTableType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""POHeaderTableType"" type=""ns3:POHeaderTableType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfPOHeaderTableType"" nillable=""true"" type=""ns3:ArrayOfPOHeaderTableType"" />
  <xs:complexType name=""PODetailsTableType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineNumber"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Status"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Description"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""550"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UOM"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Quantity"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UnitPrice"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PriceUnit"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""TotalAmount"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SOUnitPrice"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SOUOM"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SOQuantity"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineType"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""MaterialMasterCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""MaterialGroupCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PlantCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""8"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ItemCategoryCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""25"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""AdminFeeSGDAmount"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SupplierInstructions"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""420"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""NatoStockNumber"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ManufacturerPartNumber"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""35"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PartNumber"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""210"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CageCode"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""15"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CageName"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""150"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ItemCondition"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""MinimumShelfLife"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ShelfLifeRemaining"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CertificateOfConformance"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""1100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ExportLicense"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LocationLineNumber"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""10"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LocationStatus"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LocationStatusDate"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LocationQuantity"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DeliveryDestination"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""1100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DeliveryDate"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""20"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DeliveryTerms"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""5"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PortOfOrigin"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""155"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""RecipientName"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""50"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""RecipientPhone"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""30"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""RecipientEmail"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""150"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""PODetailsTableType"" nillable=""true"" type=""ns3:PODetailsTableType"" />
  <xs:complexType name=""ArrayOfPODetailsTableType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PODetailsTableType"" type=""ns3:PODetailsTableType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfPODetailsTableType"" nillable=""true"" type=""ns3:ArrayOfPODetailsTableType"" />
</xs:schema>";
        
        public uspPOInsert_TableType_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "POHeaderTableType";
                _RootElements[1] = "ArrayOfPOHeaderTableType";
                _RootElements[2] = "PODetailsTableType";
                _RootElements[3] = "ArrayOfPODetailsTableType";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo",@"POHeaderTableType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"POHeaderTableType"})]
        public sealed class POHeaderTableType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public POHeaderTableType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "POHeaderTableType";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo",@"ArrayOfPOHeaderTableType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfPOHeaderTableType"})]
        public sealed class ArrayOfPOHeaderTableType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfPOHeaderTableType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfPOHeaderTableType";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo",@"PODetailsTableType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PODetailsTableType"})]
        public sealed class PODetailsTableType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PODetailsTableType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PODetailsTableType";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo",@"ArrayOfPODetailsTableType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfPODetailsTableType"})]
        public sealed class ArrayOfPODetailsTableType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfPODetailsTableType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfPODetailsTableType";
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
