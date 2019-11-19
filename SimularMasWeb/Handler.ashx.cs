using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace SimularMasWeb
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {


        public void ProcessRequest(HttpContext context)

        {
            context.Response.ContentEncoding = System.Text.Encoding.UTF8;
            context.Response.ContentType = "text/html";

            var strResult = string.Empty;

            switch (context.Request.QueryString["RequestType"].Trim())
            {
                case "AddNum":
                    strResult = this.AddNumber(
                        Convert.ToInt32(context.Request["number1"]),
                        Convert.ToInt32(context.Request["number2"]));
                    break;
            }
            context.Response.Write(strResult);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public string AddNumber(int number1, int number2)
        {
            int total = 0;

            Lib.Class1 sampleLib = new Lib.Class1();
            total = sampleLib.Add(number1, number2);

            var jsonData = new
            {
                Total = total
            };
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();

            return javaScriptSerializer.Serialize(jsonData);
        }
    }
}