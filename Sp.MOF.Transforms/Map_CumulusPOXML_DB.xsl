<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var userCSharp" version="1.0" xmlns:ns4="http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/InterfacePOInsert" xmlns:ns0="http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo" xmlns:ns3="http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/PURCHASE_ORDER_DATA" />
  </xsl:template>
  <xsl:template match="/PURCHASE_ORDER_DATA">
    <ns0:InterfacePOInsert>
      <ns0:POHeaderType>
        <ns3:POHeaderTableType>
          <ns3:HubID>Cumulus</ns3:HubID>
             <ns3:MinistryCode />
            <ns3:DepartmentCode />
          <ns3:UEN>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/COMPANY_UEN/text()" />
          </ns3:UEN>
          <ns3:OrderCode>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/ORDER_CODE/text()" />
          </ns3:OrderCode>
          <ns3:VariationNumber>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/VARIATION_NUMBER/text()" />
          </ns3:VariationNumber>
          <ns3:Description>
            <xsl:value-of select="userCSharp:RemoveSplChar(PURCHASE_ORDER/HEADER/DESCRIPTION/text())" />
          </ns3:Description>
          <ns3:StatusDate>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/STATUS_DATE/text()" />
          </ns3:StatusDate>
          <ns3:PaymentTerms>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/PAYMENT_TERMS/text()" />
          </ns3:PaymentTerms>
          <ns3:SubBusinessUnit>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/SUB_BUSINESS_UNIT/text()" />
          </ns3:SubBusinessUnit>
          <ns3:SupplierCode>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/SUPPLIER/CODE/text()" />
          </ns3:SupplierCode>
          <ns3:SupplierName>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/SUPPLIER/SUPPLIER_NAME/text()" />
          </ns3:SupplierName>
          <ns3:DeliveryDestination>
            <xsl:value-of select="userCSharp:RemoveSplChar(PURCHASE_ORDER/HEADER/DELIVERY_DESTINATION/text())" />
          </ns3:DeliveryDestination>
          <ns3:SiteAddressLine1>
            <xsl:value-of select="userCSharp:RemoveSplChar(PURCHASE_ORDER/HEADER/SUPPLIER/ADDRESS/ADDRESS_LINE/text())" />
          </ns3:SiteAddressLine1>
          <ns3:SiteCountryCode>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/SUPPLIER/ADDRESS/COUNTRY/text()" />
          </ns3:SiteCountryCode>
          <ns3:SiteCity>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/SUPPLIER/ADDRESS/CITY/text()" />
          </ns3:SiteCity>
          <ns3:SiteAreaCode>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/SUPPLIER/ADDRESS/POSTALCODE/text()" />
          </ns3:SiteAreaCode>
          <ns3:SiteZIP>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/SUPPLIER/ADDRESS/POSTALCODE/text()" />
          </ns3:SiteZIP>
          <ns3:CurrencyCode>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/CURRENCY_CODE/text()" />
          </ns3:CurrencyCode>
          <ns3:BuyerOrganisationCode>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/COMPANY_UEN/text()" />
          </ns3:BuyerOrganisationCode>
          <ns3:BuyerOrganisationName>
            <xsl:value-of select="PURCHASE_ORDER/HEADER/COMPANY_NAME/text()" />
          </ns3:BuyerOrganisationName>
          <ns3:InterfaceFileName>
            <xsl:value-of select="InterfaceFileName/text()" />
          </ns3:InterfaceFileName>
        </ns3:POHeaderTableType>
      </ns0:POHeaderType>
      <ns0:PODetailsType>
        <xsl:for-each select="PURCHASE_ORDER/HEADER/ITEMS/ITEM">
          <ns3:PODetailsTableType>
            <ns3:LineNumber>
              <xsl:value-of select="LINE_NUMBER/text()" />
            </ns3:LineNumber>
            <ns3:Description>
              <xsl:value-of select="userCSharp:RemoveSplChar(DESCRIPTION/text())" />
            </ns3:Description>
            <ns3:UOM>
              <xsl:value-of select="UNIT_OF_MEASURE/text()" />
            </ns3:UOM>
            <ns3:Quantity>
              <xsl:value-of select="QUANTITY/text()" />
            </ns3:Quantity>
            <ns3:UnitPrice>
              <xsl:value-of select="UNIT_PRICE/text()" />
            </ns3:UnitPrice>
            <ns3:TotalAmount>
              <xsl:value-of select="TOTAL_AMOUNT/text()" />
            </ns3:TotalAmount>
          </ns3:PODetailsTableType>
        </xsl:for-each>
      </ns0:PODetailsType>
    </ns0:InterfacePOInsert>
  </xsl:template>
  <msxsl:script language="C#" implements-prefix="userCSharp">
    <![CDATA[
public string RemoveSplChar(string param1)
{
   return param1.Replace("#xa;","");
}
public string StringConcat(string param1)
{
   return param1;
}



]]>
  </msxsl:script>
</xsl:stylesheet>