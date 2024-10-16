<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s1 s0 userCSharp" version="1.0" xmlns:s0="http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/InterfaceMOFPOData" xmlns:ns0="urn:oasis:names:specification:ubl:schema:xsd:Order-2" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:s1="http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s1:InterfaceMOFPODataResponse" />
  </xsl:template>
  <xsl:template match="/s1:InterfaceMOFPODataResponse">
    <xsl:variable name="var:v1" select="userCSharp:StringConcat(string(s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:VariationNumber/text()) , string(s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:Description/text()))" />
    <ns0:Order>
      <cbc:CustomizationID>urn:fdc:peppol.eu:poacc:trns:order:3</cbc:CustomizationID>
      <cbc:ProfileID>urn:fdc:peppol.eu:poacc:bis:order_only:3</cbc:ProfileID>
      <cbc:ID>
        <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/OrderCode">
          <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/OrderCode/text()" />
        </xsl:if>
      </cbc:ID>
      <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:StatusDate">
        <cbc:IssueDate>
          <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:StatusDate/text()" />
        </cbc:IssueDate>
      </xsl:if>
      <!--<xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:OrderTypeCode">-->
      <cbc:OrderTypeCode>220</cbc:OrderTypeCode>
      <!--</xsl:if>-->
      <cbc:Note>
        <xsl:value-of select="$var:v1" />
      </cbc:Note>
      <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:CurrencyCode">
        <cbc:DocumentCurrencyCode>
          <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:CurrencyCode/s0:CurrencyCode/text()" />
        </cbc:DocumentCurrencyCode>
      </xsl:if>
      <cac:BuyerCustomerParty>
        <cac:Party>
          <cac:PartyLegalEntity>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:UserOrganisationName">
              <cbc:RegistrationName>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:UserOrganisationName/text()" />
              </cbc:RegistrationName>
            </xsl:if>
          </cac:PartyLegalEntity>
          <cac:Contact>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerName">
              <cbc:Name>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerName/text()" />
              </cbc:Name>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerPhone">
              <cbc:Telephone>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerPhone/text()" />
              </cbc:Telephone>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerEmail">
              <cbc:ElectronicMail>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerEmail/text()" />
              </cbc:ElectronicMail>
            </xsl:if>
          </cac:Contact>
        </cac:Party>
      </cac:BuyerCustomerParty>
      <cac:SellerSupplierParty>
        <cac:Party>
          <cbc:EndpointID>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SupplierCode">
              <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SupplierCode/text()" />
            </xsl:if>
          </cbc:EndpointID>
          <cac:PostalAddress>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SiteAddressLine1">
              <cbc:StreetName>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SiteAddressLine1/text()" />
              </cbc:StreetName>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SiteAddressLine2">
              <cbc:AdditionalStreetName>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SiteAddressLine2/text()" />
              </cbc:AdditionalStreetName>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SiteCity">
              <cbc:CityName>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SiteCity/text()" />
              </cbc:CityName>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SiteZIP">
              <cbc:PostalZone>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SiteZIP/text()" />
              </cbc:PostalZone>
            </xsl:if>
            <cac:Country>
              <cbc:IdentificationCode>
                <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SiteCountryCode">
                  <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SiteCountryCode/text()" />
                </xsl:if>
              </cbc:IdentificationCode>
            </cac:Country>
          </cac:PostalAddress>
          <cac:PartyLegalEntity>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SupplierName">
              <cbc:RegistrationName>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SupplierName/text()" />
              </cbc:RegistrationName>
            </xsl:if>
          </cac:PartyLegalEntity>
          <cac:Contact>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SupplierContactName">
              <cbc:Name>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SupplierContactName/text()" />
              </cbc:Name>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SupplierContactPhone">
              <cbc:Telephone>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SupplierContactPhone/text()" />
              </cbc:Telephone>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SupplierContactEmail">
              <cbc:ElectronicMail>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SupplierContactEmail/text()" />
              </cbc:ElectronicMail>
            </xsl:if>
          </cac:Contact>
        </cac:Party>
      </cac:SellerSupplierParty>
      <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/PaymentTerms">
        <cac:PaymentTerms>
          <cbc:Note>
            <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/PaymentTerms/text()" />
          </cbc:Note>
        </cac:PaymentTerms>
      </xsl:if>

      <xsl:for-each select="s1:StoredProcedureResultSet1/s0:StoredProcedureResultSet1">
        <cac:OrderLine>
          <xsl:if test="s0:Status">
            <cbc:Note>
              <xsl:value-of select="s0:Status/text()" />
            </cbc:Note>
          </xsl:if>
          <cac:LineItem>
            <cbc:ID>
              <xsl:if test="s0:LineNumber">
                <xsl:value-of select="s0:LineNumber/text()" />
              </xsl:if>
            </cbc:ID>
            <cbc:Quantity>
              <xsl:if test="s0:UOM">
                <xsl:attribute name="unitCode">
                  <xsl:value-of select="s0:UOM/text()" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test="s0:Quantity">
                <xsl:value-of select="s0:Quantity/text()" />
              </xsl:if>
            </cbc:Quantity>
            <cbc:LineExtensionAmount>
              <xsl:if test="s0:TotalAmount">
                <xsl:value-of select="s0:TotalAmount/text()" />
              </xsl:if>
            </cbc:LineExtensionAmount>
            <cac:Delivery>
              <cac:RequestedDeliveryPeriod>
                <xsl:if test="s0:DeliveryDate">
                  <cbc:StartDate>
                    <xsl:value-of select="s0:DeliveryDate/text()" />
                  </cbc:StartDate>
                </xsl:if>
              </cac:RequestedDeliveryPeriod>
            </cac:Delivery>
            <cac:Price>
              <cbc:PriceAmount>
                <xsl:if test="s0:UnitPrice">
                  <xsl:value-of select="s0:UnitPrice/text()" />
                </xsl:if>
              </cbc:PriceAmount>
            </cac:Price>
            <cac:Item>
              <xsl:if test="s0:Description">
                <cbc:Name>
                  <xsl:value-of select="s0:Description/text()" />
                </cbc:Name>
              </xsl:if>
            </cac:Item>
          </cac:LineItem>
        </cac:OrderLine>
      </xsl:for-each>
    </ns0:Order>
  </xsl:template>
  <msxsl:script language="C#" implements-prefix="userCSharp">
    <![CDATA[
public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}



]]>
  </msxsl:script>
</xsl:stylesheet>