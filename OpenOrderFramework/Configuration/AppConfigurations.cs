using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;

namespace OpenOrderFramework.Configuration
{
    public class AppConfigurations : IConfiguration
    {
        string _orderEmail;
        string _emailApiKey;
        string _domainForApiKey;
        string _fromName;
        string _fromEmail;
        List<string> _creditCardtype;

        public string OrderEmail
        {
            get
            {
                if (!String.IsNullOrEmpty(_orderEmail))
                    return _orderEmail;
                else
                {
                    
                    NameValueCollection appSettings =
                       ConfigurationManager.AppSettings;

                    _orderEmail = appSettings["OrderEmail"];
                    return _orderEmail;
                }
            }
            set
            {
                _orderEmail = value;
            }
        }

        public string EmailApiKey
        {
            get
            {
                if (!String.IsNullOrEmpty(_emailApiKey))
                    return _emailApiKey;
                else
                {

                    NameValueCollection appSettings =
                       ConfigurationManager.AppSettings;

                    _emailApiKey = appSettings["EmailApiKey"];
                    return _emailApiKey;
                }
            }
            set
            {
                _emailApiKey = value;
            }
        }

        public string DomainForApiKey
        {
            get
            {
                if (!String.IsNullOrEmpty(_domainForApiKey))
                    return _domainForApiKey;
                else
                {

                    NameValueCollection appSettings =
                       ConfigurationManager.AppSettings;

                    _domainForApiKey = appSettings["DomainForApiKey"];
                    return _domainForApiKey;
                }
            }
            set
            {
                _domainForApiKey = value;
            }
        }


        public string FromName
        {
            get
            {
                if (!String.IsNullOrEmpty(_fromName))
                    return _fromName;
                else
                {

                    NameValueCollection appSettings =
                       ConfigurationManager.AppSettings;

                    _domainForApiKey = appSettings["FromName"];
                    return _fromName;
                }
            }
            set
            {
                _fromName = value;
            }
        }


        public string FromEmail
        {
            get
            {
                if (!String.IsNullOrEmpty(_fromEmail))
                    return _fromEmail;
                else
                {

                    NameValueCollection appSettings =
                       ConfigurationManager.AppSettings;

                    _domainForApiKey = appSettings["FromEmail"];
                    return _fromEmail;
                }
            }
            set
            {
                _fromEmail = value;
            }
        }



        public List<string> CreditCardType
        {
            get
            {
                if ( (_creditCardtype != null) )
                    return _creditCardtype;
                else
                {

                    NameValueCollection appSettings =
                       ConfigurationManager.AppSettings;

                    _creditCardtype = appSettings["AcceptedCreditCardTypes"].Split(',').ToList();
                    return _creditCardtype;
                }
            }
            set
            {
                _creditCardtype = value;
            }
        }
    }
}