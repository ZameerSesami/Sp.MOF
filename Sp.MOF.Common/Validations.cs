using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sp.MOF.Common
{
    public class Validations
    {
        public static string ValidateGeBizFile(XmlDocument InputXML)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            try
            {
                if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='MINISTRY_CODE']").InnerText))
                {
                    sb.Append("MINISTRY_CODE cannot be empty |");
                }
                if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='DEPARTMENT_CODE']").InnerText))
                {
                    sb.Append("DEPARTMENT_CODE cannot be empty |");
                }
                if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='ORDER_CODE']").InnerText))
                {
                    sb.Append("ORDER_CODE cannot be empty |");
                }
                if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='VARIATION_NUMBER']").InnerText))
                {
                    sb.Append("VARIATION_NUMBER cannot be empty |");
                }
                if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='CREATE_TIMESTAMP']").InnerText))
                {
                    sb.Append("CREATE_TIMESTAMP cannot be empty |");
                }
                if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='ORDER_TYPE']").InnerText))
                {
                    sb.Append("ORDER_TYPE cannot be empty |");
                }
                if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='SUPPLIER']/*[local-name()='SITES']/*[local-name()='SITE']/*[local-name()='ID']").InnerText))
                {
                    sb.Append("SITE_ID cannot be empty |");
                }
                if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='SUPPLIER']/*[local-name()='SITES']/*[local-name()='SITE']/*[local-name()='ADDRESS_LINE1']").InnerText))
                {
                    sb.Append("SITE_ADDRESS_LINE1 cannot be empty |");
                }
                if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='FUND_COMMIT_AMOUNT']/*[local-name()='CURRENCY_CODE']").InnerText))
                {
                    sb.Append("CURRENCY_CODE cannot be empty |");
                }
                if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='FUND_COMMIT_AMOUNT']/*[local-name()='CURRENCY_AMOUNT']").InnerText))
                {
                    sb.Append("CURRENCY_AMOUNT cannot be empty |");
                }
                if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='FUND_COMMIT_AMOUNT']/*[local-name()='CURRENCY_AMOUNT']").InnerText))
                {
                    sb.Append("CURRENCY_AMOUNT cannot be empty |");
                }


                XmlNodeList NodeListPOLine = InputXML.SelectNodes("/*[local-name()='GEBIZ_ORDER']/*[local-name()='ITEMS']");
                foreach (XmlNode NodeInvoiceLine in NodeListPOLine)
                {
                    XmlNodeList NodeListLineItem = NodeInvoiceLine.SelectNodes("ITEM");
                    foreach (XmlNode NodeLineItem in NodeListLineItem)
                    {
                        if (string.IsNullOrEmpty(NodeLineItem.SelectSingleNode("LINE_NUMBER").InnerText))
                        {
                            sb.Append("ITEM_LINE_NUMBER cannot be empty |");
                        }
                        if (string.IsNullOrEmpty(NodeLineItem.SelectSingleNode("/*[local-name()='SERVICE_ORDER']/*[local-name()='ORIG_UNIT_OF_MEASURE']").InnerText))
                        {
                            sb.Append("ORIG_UNIT_OF_MEASURE cannot be empty |");
                        }
                        if (string.IsNullOrEmpty(NodeLineItem.SelectSingleNode("/*[local-name()='SERVICE_ORDER']/*[local-name()='ORIG_QUANTITY']").InnerText))
                        {
                            sb.Append("ORIG_QUANTITY cannot be empty |");
                        }
                        if (string.IsNullOrEmpty(NodeLineItem.SelectSingleNode("TOTAL_AMOUNT").InnerText))
                        {
                            sb.Append("ITEM_TOTAL_AMOUNT cannot be empty |");
                        }
                        if (string.IsNullOrEmpty(NodeLineItem.SelectSingleNode("/*[local-name()='LOCATIONS']/*[local-name()='LOCATION']/*[local-name()='LINE_NUMBER']").InnerText))
                        {
                            sb.Append("LOCATION_LINE_NUMBER cannot be empty |");
                        }
                        if (string.IsNullOrEmpty(NodeLineItem.SelectSingleNode("/*[local-name()='LOCATIONS']/*[local-name()='LOCATION']/*[local-name()='DELIVERY_DESTINATION']").InnerText))
                        {
                            sb.Append("LOCATION_DELIVERY_DESTINATION cannot be empty |");
                        }
                        if (string.IsNullOrEmpty(NodeLineItem.SelectSingleNode("/*[local-name()='LOCATIONS']/*[local-name()='LOCATION']/*[local-name()='DELIVERY_DATE']").InnerText))
                        {
                            sb.Append("LOCATION_DELIVERY_DATE cannot be empty |");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                sb.Append(ex.Message + "|");
            }
            return sb.ToString();
        }
    }
}