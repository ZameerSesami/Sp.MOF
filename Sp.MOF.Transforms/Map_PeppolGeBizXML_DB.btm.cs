namespace Sp.MOF.Transforms {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.MOF.Schemas.GebizPO", typeof(global::Sp.MOF.Schemas.GebizPO))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.MOF.Schemas.uspPOInsert_TypedProcedure_dbo+InterfacePOInsert", typeof(global::Sp.MOF.Schemas.uspPOInsert_TypedProcedure_dbo.InterfacePOInsert))]
    public sealed class Map_PeppolGeBizXML_DB : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/InterfacePOInsert"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/GEBIZ_ORDER"" />
  </xsl:template>
  <xsl:template match=""/GEBIZ_ORDER"">
    <ns0:InterfacePOInsert>
      <ns0:POHeaderType>
        <ns3:POHeaderTableType>
          <ns3:HubID>GeBiz</ns3:HubID>
          <ns3:MinistryCode>
            <xsl:value-of select=""HEADER/MINISTRY_CODE/text()"" />
          </ns3:MinistryCode>
          <ns3:DepartmentCode>
            <xsl:value-of select=""HEADER/DEPARTMENT_CODE/text()"" />
          </ns3:DepartmentCode>
          <ns3:OrderCode>
            <xsl:value-of select=""HEADER/ORDER_CODE/text()"" />
          </ns3:OrderCode>
          <ns3:VariationNumber>
            <xsl:value-of select=""HEADER/VARIATION_NUMBER/text()"" />
          </ns3:VariationNumber>
          <ns3:Description>
            <xsl:value-of select=""HEADER/DESCRIPTION/text()"" />
          </ns3:Description>
          <ns3:OrderTypeStatus>
            <xsl:value-of select=""HEADER/STATUS/text()"" />
          </ns3:OrderTypeStatus>
          <ns3:StatusDate>
            <xsl:value-of select=""HEADER/STATUS_DATE/text()"" />
          </ns3:StatusDate>
          <ns3:PaymentTerms>
            <xsl:value-of select=""HEADER/PAYMENT_TERMS/text()"" />
          </ns3:PaymentTerms>
          <ns3:BillTo>
            <xsl:value-of select=""HEADER/BILL_TO/text()"" />
          </ns3:BillTo>
          <ns3:CreateTimestamp>
            <xsl:value-of select=""HEADER/CREATE_TIMESTAMP/text()"" />
          </ns3:CreateTimestamp>
          <ns3:OrderType>
            <xsl:value-of select=""HEADER/ORDER_TYPE/text()"" />
          </ns3:OrderType>
          <ns3:SubBusinessUnit>
            <xsl:value-of select=""HEADER/FINANCIAL_SYSTEM/SUB_BUSINESS_UNIT/text()"" />
          </ns3:SubBusinessUnit>
          <ns3:SupplierCode>
            <xsl:value-of select=""HEADER/SUPPLIER/CODE/text()"" />
          </ns3:SupplierCode>
          <ns3:SupplierName>
            <xsl:value-of select=""HEADER/SUPPLIER/NAME/text()"" />
          </ns3:SupplierName>
          <ns3:SupplierGST>
            <xsl:value-of select=""HEADER/SUPPLIER/GST_NUMBER/text()"" />
          </ns3:SupplierGST>
          <ns3:SupplierContactName>
            <xsl:value-of select=""HEADER/SUPPLIER/CONTACT_NAME/text()"" />
          </ns3:SupplierContactName>
          <ns3:SupplierContactPhone>
            <xsl:value-of select=""HEADER/SUPPLIER/CONTACT_PHONE/text()"" />
          </ns3:SupplierContactPhone>
          <ns3:SupplierContactEmail>
            <xsl:value-of select=""HEADER/SUPPLIER/CONTACT_EMAIL/text()"" />
          </ns3:SupplierContactEmail>
          <ns3:DeliveryDestination>
            <xsl:value-of select=""ITEMS/ITEM/LOCATIONS/LOCATION/DELIVERY_DESTINATION/text()"" />
          </ns3:DeliveryDestination>
          <ns3:SiteID>
            <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/ID/text()"" />
          </ns3:SiteID>
          <ns3:SiteName>
            <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/NAME/text()"" />
          </ns3:SiteName>
          <ns3:SitePhone>
            <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/PHONE/text()"" />
          </ns3:SitePhone>
          <xsl:variable name=""var:v1"" select=""string(HEADER/SUPPLIER/SITES/SITE/PHONE_EXTENSION/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v1)='true'"">
            <ns3:SitePhoneExt>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns3:SitePhoneExt>
          </xsl:if>
          <xsl:if test=""string($var:v1)='false'"">
            <ns3:SitePhoneExt>
              <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/PHONE_EXTENSION/text()"" />
            </ns3:SitePhoneExt>
          </xsl:if>
          <ns3:SiteFax>
            <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/FAX/text()"" />
          </ns3:SiteFax>
          <ns3:SiteEmail>
            <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/EMAIL/text()"" />
          </ns3:SiteEmail>
          <ns3:SiteAddressLine1>
            <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/ADDRESS_LINE1/text()"" />
          </ns3:SiteAddressLine1>
          <ns3:SiteAddressLine2>
            <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/ADDRESS_LINE2/text()"" />
          </ns3:SiteAddressLine2>
          <xsl:variable name=""var:v2"" select=""string(HEADER/SUPPLIER/SITES/SITE/ADDRESS_LINE3/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v2)='true'"">
            <ns3:SiteAddressLine3>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns3:SiteAddressLine3>
          </xsl:if>
          <xsl:if test=""string($var:v2)='false'"">
            <ns3:SiteAddressLine3>
              <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/ADDRESS_LINE3/text()"" />
            </ns3:SiteAddressLine3>
          </xsl:if>
          <ns3:SiteCountryCode>
            <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/COUNTRY_CODE/text()"" />
          </ns3:SiteCountryCode>
          <ns3:SiteProvince>
            <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/PROVINCE/text()"" />
          </ns3:SiteProvince>
          <ns3:SiteState>
            <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/STATE/text()"" />
          </ns3:SiteState>
          <ns3:SiteCity>
            <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/CITY/text()"" />
          </ns3:SiteCity>
          <ns3:SiteAreaCode>
            <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/AREA_CODE/text()"" />
          </ns3:SiteAreaCode>
          <ns3:SiteZIP>
            <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/ZIP/text()"" />
          </ns3:SiteZIP>
          <xsl:variable name=""var:v3"" select=""string(HEADER/SUPPLIER/SITES/SITE/REGION_CODE/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v3)='true'"">
            <ns3:SiteRegionCode>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns3:SiteRegionCode>
          </xsl:if>
          <xsl:if test=""string($  var:v3)='false'"">
            <ns3:SiteRegionCode>
              <xsl:value-of select=""HEADER/SUPPLIER/SITES/SITE/REGION_CODE/text()"" />
            </ns3:SiteRegionCode>
          </xsl:if>
          <ns3:UserName>
            <xsl:value-of select=""HEADER/USER/NAME/text()"" />
          </ns3:UserName>
          <ns3:UserOrganisationName>
            <xsl:value-of select=""HEADER/USER/ORGANISATION_NAME/text()"" />
          </ns3:UserOrganisationName>
          <ns3:CurrencyCode>
            <xsl:value-of select=""HEADER/FUND_COMMIT_AMOUNT/CURRENCY_CODE/text()"" />
          </ns3:CurrencyCode>
          <ns3:CurrencyAmount>
            <xsl:value-of select=""HEADER/FUND_COMMIT_AMOUNT/CURRENCY_AMOUNT/text()"" />
          </ns3:CurrencyAmount>
          <ns3:BuyerOrganisationCode>
            <xsl:value-of select=""HEADER/BUYER/ORGANISATION_CODE/text()"" />
          </ns3:BuyerOrganisationCode>
          <ns3:BuyerOrganisationName>
            <xsl:value-of select=""HEADER/BUYER/ORGANISATION_NAME/text()"" />
          </ns3:BuyerOrganisationName>
          <ns3:BuyerName>
            <xsl:value-of select=""HEADER/BUYER/NAME/text()"" />
          </ns3:BuyerName>
          <ns3:BuyerPhone>
            <xsl:value-of select=""HEADER/BUYER/PHONE/text()"" />
          </ns3:BuyerPhone>
          <ns3:BuyerEmail>
            <xsl:value-of select=""HEADER/BUYER/EMAIL/text()"" />
          </ns3:BuyerEmail> 
          <ns3:InterfaceFileName>
            <xsl:value-of select=""InterfaceFileName/text()"" />
          </ns3:InterfaceFileName>
        </ns3:POHeaderTableType>
      </ns0:POHeaderType>
      <ns0:PODetailsType>
        <xsl:for-each select=""ITEMS/ITEM"">
          <ns3:PODetailsTableType>
            <ns3:LineNumber>
              <xsl:value-of select=""LINE_NUMBER/text()"" />
            </ns3:LineNumber>
            <ns3:Status>
              <xsl:value-of select=""STATUS/text()"" />
            </ns3:Status>
            <ns3:Description>
              <xsl:value-of select=""DESCRIPTION/text()"" />
            </ns3:Description>
            <ns3:UOM>
              <xsl:value-of select=""UNIT_OF_MEASURE/text()"" />
            </ns3:UOM>
            <ns3:Quantity>
              <xsl:value-of select=""QUANTITY/text()"" />
            </ns3:Quantity>
            <ns3:UnitPrice>
              <xsl:value-of select=""UNIT_PRICE/text()"" />
            </ns3:UnitPrice>
            <ns3:PriceUnit>
              <xsl:value-of select=""PRICE_UNIT/text()"" />
            </ns3:PriceUnit>
            <ns3:TotalAmount>
              <xsl:value-of select=""TOTAL_AMOUNT/text()"" />
            </ns3:TotalAmount>
            <xsl:variable name=""var:v4"" select=""string(MATERIAL_MASTER_CODE/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v4)='true'"">
              <ns3:MaterialMasterCode>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns3:MaterialMasterCode>
            </xsl:if>
            <xsl:if test=""string($var:v4)='false'"">
              <ns3:MaterialMasterCode>
                <xsl:value-of select=""MATERIAL_MASTER_CODE/text()"" />
              </ns3:MaterialMasterCode>
            </xsl:if>
            <ns3:MaterialGroupCode>
              <xsl:value-of select=""MATERIAL_GROUP_CODE/text()"" />
            </ns3:MaterialGroupCode>
            <xsl:if test=""PLANT_CODE"">
              <xsl:variable name=""var:v5"" select=""string(PLANT_CODE/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v5)='true'"">
                <ns3:PlantCode>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </ns3:PlantCode>
              </xsl:if>
              <xsl:if test=""string($var:v5)='false'"">
                <ns3:PlantCode>
                  <xsl:value-of select=""PLANT_CODE/text()"" />
                </ns3:PlantCode>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""ITEM_CATEGORY_CODE"">
              <xsl:variable name=""var:v6"" select=""string(ITEM_CATEGORY_CODE/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v6)='true'"">
                <ns3:ItemCategoryCode>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </ns3:ItemCategoryCode>
              </xsl:if>
              <xsl:if test=""string($var:v6)='false'"">
                <ns3:ItemCategoryCode>
                  <xsl:value-of select=""ITEM_CATEGORY_CODE/text()"" />
                </ns3:ItemCategoryCode>
              </xsl:if>
            </xsl:if>
            <xsl:variable name=""var:v7"" select=""string(PART_NUMBER_INFORMATION/NATO_STOCK_NUMBER/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v7)='true'"">
              <ns3:NatoStockNumber>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns3:NatoStockNumber>
            </xsl:if>
            <xsl:if test=""string($var:v7)='false'"">
              <ns3:NatoStockNumber>
                <xsl:value-of select=""PART_NUMBER_INFORMATION/NATO_STOCK_NUMBER/text()"" />
              </ns3:NatoStockNumber>
            </xsl:if>
            <xsl:variable name=""var:v8"" select=""string(PART_NUMBER_INFORMATION/MANUFACTURER_PART_NUMBER/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v8)='true'"">
              <ns3:ManufacturerPartNumber>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns3:ManufacturerPartNumber>
            </xsl:if>
            <xsl:if test=""string($var:v8)='false'"">
              <ns3:ManufacturerPartNumber>
                <xsl:value-of select=""PART_NUMBER_INFORMATION/MANUFACTURER_PART_NUMBER/text()"" />
              </ns3:ManufacturerPartNumber>
            </xsl:if>
            <xsl:variable name=""var:v9"" select=""string(PART_NUMBER_INFORMATION/PART_NUMBER/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v9)='true'"">
              <ns3:PartNumber>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns3:PartNumber>
            </xsl:if>
            <xsl:if test=""string($var:v9)='false'"">
              <ns3:PartNumber>
                <xsl:value-of select=""PART_NUMBER_INFORMATION/PART_NUMBER/text()"" />
              </ns3:PartNumber>
            </xsl:if>
            <xsl:variable name=""var:v10"" select=""string(PART_NUMBER_INFORMATION/CAGE_CODE/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v10)='true'"">
              <ns3:CageCode>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns3:CageCode>
            </xsl:if>
            <xsl:if test=""string($var:v10)='false'"">
              <ns3:CageCode>
                <xsl:value-of select=""PART_NUMBER_INFORMATION/CAGE_CODE/text()"" />
              </ns3:CageCode>
            </xsl:if>
            <xsl:variable name=""var:v11"" select=""string(PART_NUMBER_INFORMATION/CAGE_NAME/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v11)='true'"">
              <ns3:CageName>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns3:CageName>
            </xsl:if>
            <xsl:if test=""string($var:v11)='false'"">
              <ns3:CageName>
                <xsl:value-of select=""PART_NUMBER_INFORMATION/CAGE_NAME/text()"" />
              </ns3:CageName>
            </xsl:if>
            <xsl:variable name=""var:v12"" select=""string(PART_NUMBER_INFORMATION/ITEM_CONDITION/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v12)='true'"">
              <ns3:ItemCondition>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns3:ItemCondition>
            </xsl:if>
            <xsl:if test=""string($var:v12)='false'"">
              <ns3:ItemCondition>
                <xsl:value-of select=""PART_NUMBER_INFORMATION/ITEM_CONDITION/text()"" />
              </ns3:ItemCondition>
            </xsl:if>
            <ns3:MinimumShelfLife>
              <xsl:value-of select=""PART_NUMBER_INFORMATION/MINIMUM_SHELF_LIFE/text()"" />
            </ns3:MinimumShelfLife>
            <ns3:ShelfLifeRemaining>
              <xsl:value-of select=""PART_NUMBER_INFORMATION/SHELF_LIFE_REMAINING/text()"" />
            </ns3:ShelfLifeRemaining>
            <xsl:variable name=""var:v13"" select=""string(PART_NUMBER_INFORMATION/CERTIFICATE_OF_CONFORMANCE/@xsi:nil) = 'true'"" />
            <xsl:if test=""string($var:v13)='true'"">
              <ns3:CertificateOfConformance>
                <xsl:attribute name=""xsi:nil"">
                  <xsl:value-of select=""'true'"" />
                </xsl:attribute>
              </ns3:CertificateOfConformance>
            </xsl:if>
            <xsl:if test=""string($var:v13)='false'"">
              <ns3:CertificateOfConformance>
                <xsl:value-of select=""PART_NUMBER_INFORMATION/CERTIFICATE_OF_CONFORMANCE/text()"" />
              </ns3:CertificateOfConformance>
            </xsl:if>
            <ns3:ExportLicense>
              <xsl:value-of select=""PART_NUMBER_INFORMATION/EXPORT_LICENSE/text()"" />
            </ns3:ExportLicense>
            <ns3:LocationLineNumber>
              <xsl:value-of select=""LOCATIONS/LOCATION/LINE_NUMBER/text()"" />
            </ns3:LocationLineNumber>
            <ns3:LocationStatus>
              <xsl:value-of select=""LOCATIONS/LOCATION/STATUS/text()"" />
            </ns3:LocationStatus>
            <ns3:LocationStatusDate>
              <xsl:value-of select=""LOCATIONS/LOCATION/STATUS_DATE/text()"" />
            </ns3:LocationStatusDate>
            <ns3:LocationQuantity>
              <xsl:value-of select=""LOCATIONS/LOCATION/QUANTITY/text()"" />
            </ns3:LocationQuantity>
            <ns3:DeliveryDestination>
              <xsl:value-of select=""LOCATIONS/LOCATION/DELIVERY_DESTINATION/text()"" />
            </ns3:DeliveryDestination>
            <ns3:DeliveryDate>
              <xsl:value-of select=""LOCATIONS/LOCATION/DELIVERY_DATE/text()"" />
            </ns3:DeliveryDate>
            <ns3:DeliveryTerms>
              <xsl:value-of select=""LOCATIONS/LOCATION/DELIVERY_TERMS/text()"" />
            </ns3:DeliveryTerms>
            <ns3:PortOfOrigin>
              <xsl:value-of select=""LOCATIONS/LOCATION/PORT_OF_ORIGIN/text()"" />
            </ns3:PortOfOrigin>
            <ns3:RecipientName>
              <xsl:value-of select=""LOCATIONS/LOCATION/RECIPIENT/NAME/text()"" />
            </ns3:RecipientName>
            <ns3:RecipientPhone>
              <xsl:value-of select=""LOCATIONS/LOCATION/RECIPIENT/PHONE/text()"" />
            </ns3:RecipientPhone>
            <ns3:RecipientEmail>
              <xsl:value-of select=""LOCATIONS/LOCATION/RECIPIENT/EMAIL/text()"" />
            </ns3:RecipientEmail>
          </ns3:PODetailsTableType>
        </xsl:for-each>
      </ns0:PODetailsType>
    </ns0:InterfacePOInsert>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp"">
    <![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]>
  </msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Sp.MOF.Schemas.GebizPO";
        
        private const global::Sp.MOF.Schemas.GebizPO _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Sp.MOF.Schemas.uspPOInsert_TypedProcedure_dbo+InterfacePOInsert";
        
        private const global::Sp.MOF.Schemas.uspPOInsert_TypedProcedure_dbo.InterfacePOInsert _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Sp.MOF.Schemas.GebizPO";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Sp.MOF.Schemas.uspPOInsert_TypedProcedure_dbo+InterfacePOInsert";
                return _TrgSchemas;
            }
        }
    }
}
