using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sp.MOF.CallPeppolAPI
{
    [Serializable]
    public class PostPeppolXMLData
    {
        private string UseProdAPI = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "UseProdAPI_MOF");
        private string APIURL_UAT = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APIURL_MOF_UAT");
        private string APIURL_PO_UAT = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APIURL_PO_MOF_UAT");
        private string SourceSystemID_UAT = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APISourceSystemID_MOF_UAT");
        private string ChannelID_UAT = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APIChannelID_MOF_UAT");
        private string TransactionID_UAT = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APITransactionID_MOF_UAT");
        private string ClientID_UAT = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APIClientID_MOF_UAT");
        private string Authorization_UAT = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APIAuthorization_MOF_UAT");
        private string PEPPOLID_UAT = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APIPEPPOLID_MOF_UAT");
        //Prod variables
        private string APIURL_Prod = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APIURL_MOF_Prod");
        private string SourceSystemID_Prod = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APISourceSystemID_MOF_Prod");
        private string ChannelID_Prod = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APIChannelID_MOF_Prod");
        private string TransactionID_Prod = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APITransactionID_MOF_Prod");
        private string ClientID_Prod = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APIClientID_MOF_Prod");
        private string Authorization_Prod = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APIAuthorization_MOF_Prod");
        private string PEPPOLID_Prod = Sp.MOF.Common.SSOClientHelper.Read("Sp.MOF", "APIPEPPOLID_MOF_Prod");

        public string PostResponseData(string requestXML, string ArchivePathXML)
        {
            try
            {
                var apiresp = ProcessResponseData(requestXML, ArchivePathXML);
                return apiresp;
            }
            catch (Exception ex)
            {
                return "Error:" + ex.Message + "request: " + requestXML;
            }
        }

        public string ProcessResponseData(string xmlrequest, string ArchivePath)
        {
            string jsonText = "", ErrorLine = "0";
            try
            {
                // To convert an XML node contained in string xml into a JSON string   
                //System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                //doc.LoadXml(xmlrequest);
                //jsonText = JsonConvert.SerializeXmlNode(doc);

                byte[] bytes = Encoding.UTF8.GetBytes(xmlrequest);

                jsonText = Convert.ToBase64String(bytes).ToString();
                string FinalJson = "";
                FinalJson = "{'xmlBase64String':'" + jsonText + "'}";

                //create RestSharp client and POST request object
                string URL = "";
                if (UseProdAPI == "No")
                {
                    URL = APIURL_UAT;
                }
                else
                {
                    URL = APIURL_Prod;
                }
                var client = new RestClient(URL);
                var request = new RestRequest();
                request.Method = Method.POST;
                //request headers
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                ErrorLine = "1";
                ResponseMaster inputapi = JsonConvert.DeserializeObject<ResponseMaster>(FinalJson);
                ErrorLine = "2";
                //var inputapi = JsonConvert.DeserializeObject<ResponseMaster>(jsonText);
                //var inputapi = "{"""xmlBase64String":"";

                //add parameters and token to request
                request.AddParameter("application/json", JsonConvert.SerializeObject(inputapi), ParameterType.RequestBody);
                ErrorLine = "3";
                //request.AddParameter("Authorization", "Bearer " + authtoken, ParameterType.HttpHeader);
                if (UseProdAPI == "No")
                {
                    request.AddParameter("SourceSystemID", SourceSystemID_UAT, ParameterType.HttpHeader);
                    request.AddParameter("ChannelID", ChannelID_UAT, ParameterType.HttpHeader);
                    request.AddParameter("TransactionID", TransactionID_UAT, ParameterType.HttpHeader);
                    request.AddParameter("ClientID", ClientID_UAT, ParameterType.HttpHeader);
                    request.AddParameter("Authorization", Authorization_UAT, ParameterType.HttpHeader);
                    request.AddParameter("PEPPOLID", PEPPOLID_UAT, ParameterType.HttpHeader);
                }
                else
                {
                    request.AddParameter("SourceSystemID", SourceSystemID_Prod, ParameterType.HttpHeader);
                    request.AddParameter("ChannelID", ChannelID_Prod, ParameterType.HttpHeader);
                    request.AddParameter("TransactionID", TransactionID_Prod, ParameterType.HttpHeader);
                    request.AddParameter("ClientID", ClientID_Prod, ParameterType.HttpHeader);
                    request.AddParameter("Authorization", Authorization_Prod, ParameterType.HttpHeader);
                    request.AddParameter("PEPPOLID", PEPPOLID_Prod, ParameterType.HttpHeader);
                }
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                var response = client.Execute(request);
                ErrorLine = "4";
                //System.Xml.XmlDocument xmlresp = JsonConvert.DeserializeXmlNode(response.Content, "PeppolAPIResponse");
                if (response.IsSuccessful)
                {
                    var objAPIresponse = JsonConvert.DeserializeObject<ItemsFailureModel>(response.Content);
                    if (objAPIresponse.Succeed == true)
                    {
                        return "<PeppolAPIResponse><Succeed>true</Succeed><Timestamp>" + objAPIresponse.Timestamp.ToString() + "</Timestamp><InvoiceSubmissionID>" + objAPIresponse.InvoiceSubmissionID + "</InvoiceSubmissionID></PeppolAPIResponse>";
                    }
                    else
                    {
                        if ((objAPIresponse.ItemErrorList != null) && (objAPIresponse.ItemErrorList.Count > 0))
                        {
                            System.Text.StringBuilder sb = new System.Text.StringBuilder();
                            foreach (var item in objAPIresponse.ItemErrorList)
                            {
                                sb.Append(item.errorText);
                                sb.Append(" | ");
                            }
                            return "<PeppolAPIResponse><Succeed>false</Succeed><Timestamp>" + objAPIresponse.Timestamp.ToString() + "</Timestamp><ErrorDescription>" + sb.ToString() + "</ErrorDescription></PeppolAPIResponse>";
                        }
                        else
                        {
                            return "<PeppolAPIResponse><Succeed>false</Succeed><Timestamp>" + objAPIresponse.Timestamp.ToString() + "</Timestamp><ErrorDescription>" + objAPIresponse.ErrorDescription + "</ErrorDescription></PeppolAPIResponse>";
                        }
                    }
                }
                else
                {
                    return "<PeppolAPIResponse><Succeed>false</Succeed><Timestamp>" + DateTime.Now.ToString() + "</Timestamp><ErrorDescription>" + "StatusCode: " + response.StatusCode + "</ErrorDescription></PeppolAPIResponse>";
                }

            }
            catch (Exception ex)
            {
                return "inner ex:" + ex.Message + " Error Line :" + ErrorLine + " jsontext:" + jsonText;
            }
        }
    }
}
