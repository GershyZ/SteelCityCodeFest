using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

using Xamarin.Forms;
using RestSharp;
/**
* host: ec2-54-83-25-217.compute-1.amazonaws.com
port: 5432 (default)
user: xhmftqiyzuxswk\
password: 74a02ba7fd0f776209d85b0c22393e1d62757557bfdef890c64e0d6362ea0038
database: dfke4oln8ld7f
**/
namespace FieldAgentForm
{
	public partial class App : Application
	{ 
        const string _user = "xhmftqiyzuxswk";
        const string _pwd = "74a02ba7fd0f776209d85b0c22393e1d62757557bfdef890c64e0d6362ea0038";
            const string baseUrl = "https://steel-city-codefest.herokuapp.com/";
        
        private static Dictionary<string, string> _form_data;
		public App ()
		{
			InitializeComponent();            
            MainPage = new FieldAgentForm.IAFormPage();
        }

        public static void SendData()
        {
            //client.Authenticator = new HttpBasicAuthenticator(_user, _pwd);
            string endpoint = string.Format("http://steel-city-codefest.herokuapp.com/upload-individual-assessment?disaster_id=0");


            foreach (KeyValuePair<string, string> p in _form_data)
            {
                endpoint += "&" + p.Key + "=" + p.Value;

            }
            var client = new RestClient(endpoint);
            var reques = new RestRequest(Method.GET);
            IRestResponse resp = client.Execute(reques);
            Console.WriteLine(resp.ErrorMessage);
        }
        public static void addFormData(Dictionary<string, string> data)
        {
           foreach(KeyValuePair<string,string> p in data)
            {
                _form_data[p.Key] = p.Value;
            }
        }
        protected override void OnStart ()
		{
            _form_data = new Dictionary<string, string>();
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}        
	}
}
