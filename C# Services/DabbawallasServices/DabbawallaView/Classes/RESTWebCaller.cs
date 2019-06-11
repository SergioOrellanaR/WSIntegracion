using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using DabbawallasREST;
using DabbawallasREST.Models;

namespace DabbawallaView.Classes
{
    public class RESTWebCaller
    {
        public string MethodCallerGET(string restPath)
        {
            //string restPath = "http://localhost:6970/dabbawallas/login/authenticate";
            WebRequest request = WebRequest.Create(restPath);
            request.Method = "GET";
            //request.Credentials = new NetworkCredential("USERNAME", "PASS");
            HttpWebResponse response = null;
            response = (HttpWebResponse)request.GetResponse();
            string responseString = null;
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream);
                responseString = reader.ReadToEnd();
                reader.Close();
                return responseString;
            }
        }

        public string MethodCallerPOST(string restPath, string serializedPostData)
        {
            //string restPath = "http://localhost:6970/dabbawallas/login/authenticate";
            WebRequest request = WebRequest.Create(restPath);
            request.Method = "POST";
            request.ContentType = "application/json";


            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(serializedPostData);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                string responseString = null;
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    responseString = reader.ReadToEnd();
                    reader.Close();
                    return responseString;
                }
            }
            catch (Exception e)
            {
                return null;
            }
           
        }

        public string ObjectToJson<T> (T obj)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(T));
            MemoryStream msObj = new MemoryStream();
            js.WriteObject(msObj, obj);
            msObj.Position = 0;
            StreamReader sr = new StreamReader(msObj);
            string json = sr.ReadToEnd();
            sr.Close();
            msObj.Close();
            return json;
        }
    }
}