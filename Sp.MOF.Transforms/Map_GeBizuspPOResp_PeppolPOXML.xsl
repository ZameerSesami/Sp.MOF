<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s1 s0" version="1.0" xmlns:s0="http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/InterfaceGeBizPOData" xmlns:ns0="urn:oasis:names:specification:ubl:schema:xsd:Order-2" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:s1="http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s1:InterfaceGeBizPODataResponse" />
  </xsl:template>
  <xsl:template match="/s1:InterfaceGeBizPODataResponse">
    <ns0:Order>
      <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:CustomizationID">
        <cbc:CustomizationID>
          <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:CustomizationID/text()" />
        </cbc:CustomizationID>
      </xsl:if>
      <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:ProfileID">
        <cbc:ProfileID>
          <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:ProfileID/text()" />
        </cbc:ProfileID>
      </xsl:if>
      <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:OrderCode">
        <cbc:ID>
          <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:OrderCode/text()" />
        </cbc:ID>
      </xsl:if>
      <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:IssueDate">
        <cbc:IssueDate>
          <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:IssueDate/text()" />
        </cbc:IssueDate>
      </xsl:if>
      <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:Note">
        <cbc:Note>
          <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:Note/text()" />
        </cbc:Note>
      </xsl:if>
      <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:DocumentCurrencyCode">
        <cbc:DocumentCurrencyCode>
          <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:DocumentCurrencyCode/text()" />
        </cbc:DocumentCurrencyCode>
      </xsl:if>
      <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SubBusinessUnit">
        <cbc:CustomerReference>
          <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SubBusinessUnit/text()" />
        </cbc:CustomerReference>
      </xsl:if>
      <cac:BuyerCustomerParty>
        <cac:Party>
          <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyEndPointID">
            <cbc:EndpointID>
              <xsl:attribute name="schemeID">
                <xsl:value-of select="&quot;0195&quot;" />
              </xsl:attribute>
              <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyEndPointID/text()" />
            </cbc:EndpointID>
          </xsl:if>
          <cac:PartyIdentification>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyIdentificationID">
              <cbc:ID>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyIdentificationID/text()" />
              </cbc:ID>
            </xsl:if>
          </cac:PartyIdentification>
          <cac:PartyName>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyName">
              <cbc:Name>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyName/text()" />
              </cbc:Name>
            </xsl:if>
          </cac:PartyName>
          <cac:PartyLegalEntity>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyRegName">
              <cbc:RegistrationName>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyRegName/text()" />
              </cbc:RegistrationName>
            </xsl:if>
          </cac:PartyLegalEntity>
          <cac:Contact>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyContactName">
              <cbc:Name>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyContactName/text()" />
              </cbc:Name>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyContactPhone">
              <cbc:Telephone>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyContactPhone/text()" />
              </cbc:Telephone>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyContactEmail">
              <cbc:ElectronicMail>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:BuyerCustomerPartyContactEmail/text()" />
              </cbc:ElectronicMail>
            </xsl:if>
          </cac:Contact>
        </cac:Party>
      </cac:BuyerCustomerParty>
      <cac:SellerSupplierParty>
        <cac:Party>
          <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyEndPointID">
            <cbc:EndpointID>
              <xsl:attribute name="schemeID">
                <xsl:value-of select="&quot;0195&quot;" />
              </xsl:attribute>
              <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyEndPointID/text()" />
            </cbc:EndpointID>
          </xsl:if>
          <cac:PartyName>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyRegName">
              <cbc:Name>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyRegName/text()" />
              </cbc:Name>
            </xsl:if>
          </cac:PartyName>
          <cac:PartyIdentification>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyIdentificationID">
              <cbc:ID>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyIdentificationID/text()" />
              </cbc:ID>
            </xsl:if>
          </cac:PartyIdentification>
          <cac:PostalAddress>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyStreet">
              <cbc:StreetName>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyStreet/text()" />
              </cbc:StreetName>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyAddtlStreet">
              <cbc:AdditionalStreetName>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyAddtlStreet/text()" />
              </cbc:AdditionalStreetName>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyCity">
              <cbc:CityName>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyCity/text()" />
              </cbc:CityName>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyPostalZone">
              <cbc:PostalZone>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyPostalZone/text()" />
              </cbc:PostalZone>
            </xsl:if>
            <cac:Country>
              <cbc:IdentificationCode>
                <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyCountryCode">
                  <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyCountryCode/text()" />
                </xsl:if>
              </cbc:IdentificationCode>
            </cac:Country>
          </cac:PostalAddress>
          <cac:PartyLegalEntity>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyRegName">
              <cbc:RegistrationName>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyRegName/text()" />
              </cbc:RegistrationName>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyCity">
              <cac:RegistrationAddress>
                <cbc:CityName>
                  <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyCity/text()" />
                </cbc:CityName>
                <cac:Country>
                  <cbc:IdentificationCode>
                    <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyCountryCode">
                      <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyCountryCode/text()" />
                    </xsl:if>
                  </cbc:IdentificationCode>
                </cac:Country>
              </cac:RegistrationAddress>
            </xsl:if>
          </cac:PartyLegalEntity>
          <cac:Contact>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyContactName">
              <cbc:Name>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyContactName/text()" />
              </cbc:Name>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyContactPhone">
              <cbc:Telephone>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyContactPhone/text()" />
              </cbc:Telephone>
            </xsl:if>
            <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyContactEmail">
              <cbc:ElectronicMail>
                <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:SellerSupplierPartyContactEmail/text()" />
              </cbc:ElectronicMail>
            </xsl:if>
          </cac:Contact>
        </cac:Party>
      </cac:SellerSupplierParty>
      <xsl:if test="s1:StoredProcedureResultSet1/s0:StoredProcedureResultSet1/s0:DeliveryLocationStreetName">
        <cac:Delivery>
          <cac:DeliveryLocation>
            <cac:Address>
              <cbc:StreetName>
                <xsl:value-of select="s1:StoredProcedureResultSet1/s0:StoredProcedureResultSet1/s0:DeliveryLocationStreetName/text()" />
              </cbc:StreetName>
              <cac:Country>
                <cbc:IdentificationCode>SG</cbc:IdentificationCode>
              </cac:Country>
            </cac:Address>
          </cac:DeliveryLocation>
        </cac:Delivery>
      </xsl:if>
      <cac:PaymentTerms>
        <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:PaymentTerms">
          <cbc:Note>
            <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:PaymentTerms/text()" />
          </cbc:Note>
        </xsl:if>
      </cac:PaymentTerms>
      <cac:AnticipatedMonetaryTotal>
        <!--<cbc:LineExtensionAmount currencyID="NOK">6525.00</cbc:LineExtensionAmount>
        <cbc:TaxExclusiveAmount currencyID="NOK">6272.50</cbc:TaxExclusiveAmount>
        <cbc:TaxInclusiveAmount currencyID="NOK">6372.50</cbc:TaxInclusiveAmount>
        <cbc:AllowanceTotalAmount currencyID="NOK">652.50</cbc:AllowanceTotalAmount>
        <cbc:ChargeTotalAmount currencyID="NOK">400.00</cbc:ChargeTotalAmount>
        <cbc:PrepaidAmount currencyID="NOK">10.00</cbc:PrepaidAmount>
        <cbc:PayableRoundingAmount currencyID="NOK">0.50</cbc:PayableRoundingAmount>-->
        <cbc:LineExtensionAmount>
          <xsl:attribute name="currencyID">
            <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:PayableAmount">
            <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:PayableAmount/text()" />
          </xsl:if>
        </cbc:LineExtensionAmount>
        <cbc:TaxExclusiveAmount>
          <xsl:attribute name="currencyID">
            <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:PayableAmount">
            <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:PayableAmount/text()" />
          </xsl:if>
        </cbc:TaxExclusiveAmount>
        <cbc:TaxInclusiveAmount>
          <xsl:attribute name="currencyID">
            <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:PayableAmount">
            <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:PayableAmount/text()" />
          </xsl:if>
        </cbc:TaxInclusiveAmount>
        <cbc:AllowanceTotalAmount>
          <xsl:attribute name="currencyID">
            <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:value-of select="&quot;0&quot;" />
        </cbc:AllowanceTotalAmount>
        <cbc:ChargeTotalAmount>
          <xsl:attribute name="currencyID">
            <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:value-of select="&quot;0&quot;" />
        </cbc:ChargeTotalAmount>
        <cbc:PrepaidAmount>
          <xsl:attribute name="currencyID">
            <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:value-of select="&quot;0&quot;" />
        </cbc:PrepaidAmount>
        <cbc:PayableAmount>
          <xsl:attribute name="currencyID">
            <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:if test="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:PayableAmount">
            <xsl:value-of select="s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:PayableAmount/text()" />
          </xsl:if>
        </cbc:PayableAmount>
      </cac:AnticipatedMonetaryTotal>
      <xsl:for-each select="s1:StoredProcedureResultSet1">
        <xsl:for-each select="s0:StoredProcedureResultSet1">
          <cac:OrderLine>
            <xsl:if test="s0:OrderLineNote">
              <cbc:Note>
                <xsl:value-of select="s0:OrderLineNote/text()" />
              </cbc:Note>
            </xsl:if>
            <cac:LineItem>
              <cbc:ID>
                <xsl:if test="s0:LineID">
                  <xsl:value-of select="s0:LineID/text()" />
                </xsl:if>
              </cbc:ID>
              <cbc:Quantity>
                <xsl:if test="s0:Quantity">
                  <xsl:attribute name="unitCode">
                    <xsl:value-of select="s0:UOM/text()" />
                  </xsl:attribute>
                  <xsl:value-of select="s0:Quantity/text()" />
                </xsl:if>
              </cbc:Quantity>
              <cbc:LineExtensionAmount>
                <xsl:attribute name="currencyID">
                  <xsl:value-of select="../../s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:DocumentCurrencyCode/text()" />
                </xsl:attribute>
                <xsl:if test="s0:TotalAmount">
                  <xsl:value-of select="s0:TotalAmount/text()" />
                </xsl:if>
              </cbc:LineExtensionAmount>
              <xsl:if test="s0:DeliveryDate">
                <cac:Delivery>
                  <cac:RequestedDeliveryPeriod>
                    <cbc:StartDate>
                      <xsl:value-of select="s0:DeliveryDate/text()" />
                    </cbc:StartDate>
                  </cac:RequestedDeliveryPeriod>
                </cac:Delivery>
              </xsl:if>
              <cac:Price>
                <cbc:PriceAmount>
                  <xsl:attribute name="currencyID">
                    <xsl:value-of select="../../s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:DocumentCurrencyCode/text()" />
                  </xsl:attribute>
                  <xsl:if test="s0:UnitPrice">
                    <xsl:value-of select="s0:UnitPrice/text()" />
                  </xsl:if>
                </cbc:PriceAmount>
                <!--<cbc:BaseQuantity>
                  <xsl:if test="s0:UOM">
                    <xsl:attribute name="unitCode">
                      <xsl:value-of select="s0:UOM/text()" />
                    </xsl:attribute>
                  </xsl:if>
                </cbc:BaseQuantity>-->
              </cac:Price>
              <cac:Item>
                <xsl:if test="s0:OrderLineNote">
                  <cbc:Description>
                    <xsl:value-of select="s0:OrderLineNote/text()" />
                  </cbc:Description>
                </xsl:if>
                <xsl:if test="s0:LineItemName">
                  <cbc:Name>
                    <xsl:value-of select="s0:LineItemName/text()" />
                  </cbc:Name>
                </xsl:if>
              </cac:Item>
            </cac:LineItem>
          </cac:OrderLine>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:Order>
  </xsl:template>
  <msxsl:script language="C#" implements-prefix="userCSharp">
    <![CDATA[
public string StringConcat(string param0)
{
  //Sp.MOF.Common.TransformSSOClientHelper obj = new Sp.MOF.Common.TransformSSOClientHelper();
   return param0;
}
]]>
  </msxsl:script>
</xsl:stylesheet>