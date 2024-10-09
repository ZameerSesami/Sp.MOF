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
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='MINISTRY_CODE']") == null)
                {
                    sb.Append("MINISTRY_CODE cannot be empty |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='MINISTRY_CODE']").InnerText))
                    {
                        sb.Append("MINISTRY_CODE cannot be empty |");
                    }
                }
                //sb.Append("MINISTRY_CODE OK |");
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='DEPARTMENT_CODE']") == null)
                {
                    sb.Append("DEPARTMENT_CODE cannot be empty |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='DEPARTMENT_CODE']").InnerText))
                    {
                        sb.Append("DEPARTMENT_CODE cannot be empty |");
                    }
                }
                //sb.Append("DEPARTMENT_CODE OK |");
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='ORDER_CODE']") == null)
                {
                    sb.Append("ORDER_CODE cannot be empty |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='ORDER_CODE']").InnerText))
                    {
                        sb.Append("ORDER_CODE cannot be empty |");
                    }
                }
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='VARIATION_NUMBER']") == null)
                {
                    sb.Append("VARIATION_NUMBER cannot be empty |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='VARIATION_NUMBER']").InnerText))
                    {
                        sb.Append("VARIATION_NUMBER cannot be empty |");
                    }
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


                XmlNodeList NodeListPOItems = InputXML.SelectNodes("/*[local-name()='GEBIZ_ORDER']/*[local-name()='ITEMS']");

                foreach (XmlNode NodePOItemList in NodeListPOItems)
                {
                    //sb.Append("ITEMS OK: |");
                    XmlNodeList NodePOItems = NodePOItemList.SelectNodes("ITEM");
                    foreach (XmlNode NodePOItem in NodePOItems)
                    {
                        if (NodePOItem.SelectSingleNode("LINE_NUMBER") == null)
                        {
                            sb.Append("ITEM_LINE_NUMBER cannot be empty |");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(NodePOItem.SelectSingleNode("LINE_NUMBER").InnerText))
                            {
                                sb.Append("ITEM_LINE_NUMBER cannot be empty |");
                            }
                        }
                        //sb.Append("ITEM_LINE_NUMBER OK |");

                        XmlNodeList ItemServiceNodesList = NodePOItem.SelectNodes("SERVICE_ORDER");
                        foreach (XmlNode ServiceItemNode in ItemServiceNodesList)
                        {
                            if (ServiceItemNode.SelectSingleNode("ORIG_UNIT_OF_MEASURE") == null)
                            {
                                sb.Append("ORIG_UNIT_OF_MEASURE cannot be empty |");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(ServiceItemNode.SelectSingleNode("ORIG_UNIT_OF_MEASURE").InnerText))
                                {
                                    sb.Append("ORIG_UNIT_OF_MEASURE cannot be empty |");
                                }
                            }
                            //sb.Append("ORIG_UNIT_OF_MEASURE OK |");
                            if (ServiceItemNode.SelectSingleNode("ORIG_QUANTITY") == null)
                            {
                                sb.Append("ORIG_QUANTITY cannot be empty |");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(ServiceItemNode.SelectSingleNode("ORIG_QUANTITY").InnerText))
                                {
                                    sb.Append("ORIG_QUANTITY cannot be empty |");
                                }
                            }
                            //sb.Append("ORIG_QUANTITY OK |");
                        }
                        if (NodePOItem.SelectSingleNode("TOTAL_AMOUNT") == null)
                        {
                            sb.Append("ITEM_TOTAL_AMOUNT cannot be empty |");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(NodePOItem.SelectSingleNode("TOTAL_AMOUNT").InnerText))
                            {
                                sb.Append("ITEM_TOTAL_AMOUNT cannot be empty |");
                            }
                        }
                        //sb.Append("ITEM_TOTAL_AMOUNT OK |");
                        XmlNodeList NodeItemLocations = NodePOItem.SelectNodes("LOCATIONS");
                        foreach (XmlNode NodeItemLocationsList in NodeItemLocations)
                        {
                            XmlNodeList NodeLocationList = NodeItemLocationsList.SelectNodes("LOCATION");
                            foreach (XmlNode NodeItemLocation in NodeLocationList)
                            {
                                if (NodeItemLocation.SelectSingleNode("LINE_NUMBER") == null)
                                {
                                    sb.Append("LOCATION_LINE_NUMBER cannot be empty |");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(NodeItemLocation.SelectSingleNode("LINE_NUMBER").InnerText))
                                    {
                                        sb.Append("LOCATION_LINE_NUMBER cannot be empty |");
                                    }
                                }
                                //sb.Append("LOCATION_LINE_NUMBER OK |");
                                if (NodeItemLocation.SelectSingleNode("DELIVERY_DESTINATION") == null)
                                {
                                    sb.Append("LOCATION_DELIVERY_DESTINATION cannot be empty |");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(NodeItemLocation.SelectSingleNode("DELIVERY_DESTINATION").InnerText))
                                    {
                                        sb.Append("LOCATION_DELIVERY_DESTINATION cannot be empty |");
                                    }
                                }
                                //sb.Append("LOCATION_DELIVERY_DESTINATION OK |");
                                if (NodeItemLocation.SelectSingleNode("DELIVERY_DATE") == null)
                                {
                                    sb.Append("LOCATION_DELIVERY_DATE cannot be empty |");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(NodeItemLocation.SelectSingleNode("DELIVERY_DATE").InnerText))
                                    {
                                        sb.Append("LOCATION_DELIVERY_DATE cannot be empty |");
                                    }
                                }
                                //sb.Append("LOCATION_DELIVERY_DATE OK |");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                sb.Append("Error:" + ex.Message);
            }
            return sb.ToString();
        }
        public static string ValidateCumulusFile(XmlDocument InputXML)
        {
            return "OK";
        }
    }
}