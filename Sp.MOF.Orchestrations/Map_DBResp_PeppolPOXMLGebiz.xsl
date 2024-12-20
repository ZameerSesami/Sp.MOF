<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s3 s2 s1 s0 userCSharp" version="1.0" xmlns:ns0="urn:oasis:names:specification:ubl:schema:xsd:Order-2" xmlns:s0="http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo" xmlns:s2="http://schemas.microsoft.com/BizTalk/2003/aggschema" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns:s3="http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/InterfaceGeBizPOData" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:s1="http://Sp.MOF.Schemas.SSOValuePeppolIdType" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s2:Root" />
  </xsl:template>
  <xsl:template match="/s2:Root">
    <!--<xsl:variable name="varSSOPeppolIdType1" select="userCSharp:PrintString(string(InputMessagePart_1/Root/PeppolIdType/text()))" />-->
    <xsl:variable name="varSSOPeppolIdType" select="string(InputMessagePart_1/Root/PeppolIdType/text())" />
    <ns0:Order>
      <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:CustomizationID">
        <cbc:CustomizationID>
          <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:CustomizationID/text()" />
        </cbc:CustomizationID>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:ProfileID">
        <cbc:ProfileID>
          <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:ProfileID/text()" />
        </cbc:ProfileID>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:OrderCode">
        <cbc:ID>
          <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:OrderCode/text()" />
        </cbc:ID>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:IssueDate">
        <cbc:IssueDate>
          <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:IssueDate/text()" />
        </cbc:IssueDate>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:Note">
        <cbc:Note>
          <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:Note/text()" />
        </cbc:Note>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:DocumentCurrencyCode">
        <cbc:DocumentCurrencyCode>
          <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:DocumentCurrencyCode/text()" />
        </cbc:DocumentCurrencyCode>
      </xsl:if>
      <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SubBusinessUnit">
        <cbc:CustomerReference>
          <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SubBusinessUnit/text()" />
        </cbc:CustomerReference>
      </xsl:if>
      <cac:BuyerCustomerParty>
        <cac:Party>
          <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyEndPointID">
            <cbc:EndpointID>
              <xsl:attribute name="schemeID">
                <xsl:value-of select="&quot;0195&quot;" />
              </xsl:attribute>
              <xsl:value-of select="userCSharp:StringConcat($varSSOPeppolIdType,string(InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyEndPointID/text()))" />
            </cbc:EndpointID>
          </xsl:if>
          <cac:PartyIdentification>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyIdentificationID">
              <cbc:ID>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyIdentificationID/text()" />
              </cbc:ID>
            </xsl:if>
          </cac:PartyIdentification>
          <cac:PartyName>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyName">
              <cbc:Name>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyName/text()" />
              </cbc:Name>
            </xsl:if>
          </cac:PartyName>
          <cac:PostalAddress>
            <cac:Country>
              <cbc:IdentificationCode>
                <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCountryCode">
                  <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCountryCode/text()" />
                </xsl:if>
              </cbc:IdentificationCode>
            </cac:Country>
          </cac:PostalAddress>
          <cac:PartyLegalEntity>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyRegName">
              <cbc:RegistrationName>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyRegName/text()" />
              </cbc:RegistrationName>
              <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyIdentificationID">
                <cbc:CompanyID schemeID="0195">
                  <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyIdentificationID/text()" />
                </cbc:CompanyID>
              </xsl:if>
            </xsl:if>
          </cac:PartyLegalEntity>
          <cac:Contact>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyContactName">
              <cbc:Name>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyContactName/text()" />
              </cbc:Name>
            </xsl:if>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyContactPhone">
              <cbc:Telephone>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyContactPhone/text()" />
              </cbc:Telephone>
            </xsl:if>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyContactEmail">
              <cbc:ElectronicMail>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:BuyerCustomerPartyContactEmail/text()" />
              </cbc:ElectronicMail>
            </xsl:if>
          </cac:Contact>
        </cac:Party>
      </cac:BuyerCustomerParty>
      <cac:SellerSupplierParty>
        <cac:Party>
          <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyEndPointID">
            <cbc:EndpointID>
              <xsl:attribute name="schemeID">
                <xsl:value-of select="&quot;0195&quot;" />
              </xsl:attribute>
              <xsl:value-of select="userCSharp:StringConcat($varSSOPeppolIdType,string(InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyEndPointID/text()))" />
            </cbc:EndpointID>
          </xsl:if>
          <cac:PartyIdentification>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyIdentificationID">
              <cbc:ID>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyIdentificationID/text()" />
              </cbc:ID>
            </xsl:if>
          </cac:PartyIdentification>
          <cac:PartyName>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyRegName">
              <cbc:Name>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyRegName/text()" />
              </cbc:Name>
            </xsl:if>
          </cac:PartyName>
          <cac:PostalAddress>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyAddress1">
              <cbc:StreetName>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyAddress1/text()" />
              </cbc:StreetName>
            </xsl:if>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyAddress2">
              <cbc:AdditionalStreetName>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyAddress2/text()" />
              </cbc:AdditionalStreetName>
            </xsl:if>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyCity">
              <cbc:CityName>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyCity/text()" />
              </cbc:CityName>
            </xsl:if>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyPostalZone">
              <cbc:PostalZone>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyPostalZone/text()" />
              </cbc:PostalZone>
            </xsl:if>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyAddress3">
              <cac:AddressLine>
                <cbc:Line>
                  <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyAddress3/text()" />
                </cbc:Line>
              </cac:AddressLine>
            </xsl:if>
            <cac:Country>
              <cbc:IdentificationCode>
                <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyCountryCode">
                  <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyCountryCode/text()" />
                </xsl:if>
              </cbc:IdentificationCode>
            </cac:Country>
          </cac:PostalAddress>
          <cac:PartyLegalEntity>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyRegName">
              <cbc:RegistrationName>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyRegName/text()" />
              </cbc:RegistrationName>
              <cbc:CompanyID schemeID="0195">
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyIdentificationID/text()" />
              </cbc:CompanyID>
            </xsl:if>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyCity">
              <cac:RegistrationAddress>
                <cbc:CityName>
                  <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyCity/text()" />
                </cbc:CityName>
                <cac:Country>
                  <cbc:IdentificationCode>
                    <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyCountryCode">
                      <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyCountryCode/text()" />
                    </xsl:if>
                  </cbc:IdentificationCode>
                </cac:Country>
              </cac:RegistrationAddress>
            </xsl:if>
          </cac:PartyLegalEntity>
          <cac:Contact>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyContactName">
              <cbc:Name>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyContactName/text()" />
              </cbc:Name>
            </xsl:if>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyContactPhone">
              <cbc:Telephone>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyContactPhone/text()" />
              </cbc:Telephone>
            </xsl:if>
            <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyContactEmail">
              <cbc:ElectronicMail>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:SellerSupplierPartyContactEmail/text()" />
              </cbc:ElectronicMail>
            </xsl:if>
          </cac:Contact>
        </cac:Party>
      </cac:SellerSupplierParty>
      <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet1/s3:StoredProcedureResultSet1/s3:DeliveryLocationStreetName">
        <cac:Delivery>
          <cac:DeliveryLocation>
            <cac:Address>
              <cbc:StreetName>
                <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet1/s3:StoredProcedureResultSet1/s3:DeliveryLocationStreetName/text()" />
              </cbc:StreetName>
              <cac:Country>
                <cbc:IdentificationCode>SG</cbc:IdentificationCode>
              </cac:Country>
            </cac:Address>
          </cac:DeliveryLocation>
          <cac:RequestedDeliveryPeriod>
            <cbc:StartDate>
              <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet1/s3:StoredProcedureResultSet1/s3:DeliveryDate/text()" />
            </cbc:StartDate>
          </cac:RequestedDeliveryPeriod>
        </cac:Delivery>
      </xsl:if>
      <cac:PaymentTerms>
        <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:PaymentTerms">
          <cbc:Note>
            <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:PaymentTerms/text()" />
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
            <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:PayableAmount">
            <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:PayableAmount/text()" />
          </xsl:if>
        </cbc:LineExtensionAmount>
        <cbc:TaxExclusiveAmount>
          <xsl:attribute name="currencyID">
            <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:PayableAmount">
            <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:PayableAmount/text()" />
          </xsl:if>
        </cbc:TaxExclusiveAmount>
        <cbc:TaxInclusiveAmount>
          <xsl:attribute name="currencyID">
            <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:PayableAmount">
            <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:PayableAmount/text()" />
          </xsl:if>
        </cbc:TaxInclusiveAmount>
        <cbc:AllowanceTotalAmount>
          <xsl:attribute name="currencyID">
            <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:value-of select="&quot;0&quot;" />
        </cbc:AllowanceTotalAmount>
        <cbc:ChargeTotalAmount>
          <xsl:attribute name="currencyID">
            <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:value-of select="&quot;0&quot;" />
        </cbc:ChargeTotalAmount>
        <cbc:PrepaidAmount>
          <xsl:attribute name="currencyID">
            <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:value-of select="&quot;0&quot;" />
        </cbc:PrepaidAmount>
        <cbc:PayableAmount>
          <xsl:attribute name="currencyID">
            <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:DocumentCurrencyCode/text()" />
          </xsl:attribute>
          <xsl:if test="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:PayableAmount">
            <xsl:value-of select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:PayableAmount/text()" />
          </xsl:if>
        </cbc:PayableAmount>
      </cac:AnticipatedMonetaryTotal>

     <xsl:for-each select="InputMessagePart_0/s0:InterfaceGeBizPODataResponse/s0:StoredProcedureResultSet1">
        <xsl:for-each select="s3:StoredProcedureResultSet1">
          <cac:OrderLine>
            <xsl:if test="s3:OrderLineNote">
              <cbc:Note>
                <xsl:value-of select="s3:OrderLineNote/text()" />
              </cbc:Note>
            </xsl:if>
            <cac:LineItem>
              <cbc:ID>
                <xsl:if test="s3:LineID">
                  <xsl:value-of select="s3:LineID/text()" />
                </xsl:if>
              </cbc:ID>
              <cbc:Quantity>
                <xsl:if test="s3:Quantity">
                  <xsl:attribute name="unitCode">
                    <xsl:value-of select="s3:UOM/text()" />
                  </xsl:attribute>
                  <xsl:value-of select="s3:Quantity/text()" />
                </xsl:if>
              </cbc:Quantity>
              <cbc:LineExtensionAmount>
                <xsl:attribute name="currencyID">
                  <xsl:value-of select="../../s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:DocumentCurrencyCode/text()" />
                </xsl:attribute>
                <xsl:if test="s3:TotalAmount">
                  <xsl:value-of select="s3:TotalAmount/text()" />
                </xsl:if>
              </cbc:LineExtensionAmount>
              <xsl:if test="s3:DeliveryDate">
                <cac:Delivery>
                  <cac:RequestedDeliveryPeriod>
                    <cbc:StartDate>
                      <xsl:value-of select="s3:DeliveryDate/text()" />
                    </cbc:StartDate>
                  </cac:RequestedDeliveryPeriod>
                </cac:Delivery>
              </xsl:if>
              <cac:Price>
                <cbc:PriceAmount>
                  <xsl:attribute name="currencyID">
                    <xsl:value-of select="../../s0:StoredProcedureResultSet0/s3:StoredProcedureResultSet0/s3:DocumentCurrencyCode/text()" />
                  </xsl:attribute>
                  <xsl:if test="s3:UnitPrice">
                    <xsl:value-of select="s3:UnitPrice/text()" />
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
                <xsl:if test="s3:OrderLineNote">
                  <cbc:Description>
                    <xsl:value-of select="s3:OrderLineNote/text()" />
                  </cbc:Description>
                </xsl:if>
                <xsl:if test="s3:LineItemName">
                  <cbc:Name>
                    <xsl:value-of select="s3:LineItemName/text()" />
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
public string PrintString(string param)
{
  System.Diagnostics.EventLog.WriteEntry("InsideXSL",param);
   return param;
}
public string StringConcat(string param1,string param2)
{
   return param1+param2;
}
]]></msxsl:script>
</xsl:stylesheet>