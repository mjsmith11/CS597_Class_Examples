using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Hosting;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Net; //for making calls that return json

namespace Week10
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string file = HostingEnvironment.MapPath(@"/Students.json");//for reading a local file
            StreamReader reader = new StreamReader(file);
            string contents = reader.ReadToEnd();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(List<Student>));//making a contract with a list of student objects
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(contents));//converts to a memory stream
            List<Student> s = (List<Student>)js.ReadObject(stream);//read the stream and serialize it to a List<> object

            //Response.Write(s[0].Address.Zip);
            Response.Write(s[1].FirstName);

            //generate an http request
            //send the request 
            //read the HTTPResponse
            //Serialize and read into objects
                //define C# class(es)
                //jsonutils.com
                //Make DataContract using JSONSerializer
                //Read JSON and store in C# objects
        }
    }

    //these can be auto generated
    [DataContract]
    public class Address
    {
        [DataMember (Name ="street")] //Name=indicates a different name in json than the property
        public string Street { get; set; }

        [DataMember(Name ="city")]
        public string City { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name ="zip")]
        public string Zip { get; set; }

    }

    [DataContract]
    public class Student
    {
        [DataMember (Name ="firstName")]
        public string FirstName { get; set; }

        [DataMember]
        public string lastName { get; set; }

        [DataMember]
        public Address Address { get; set; }
    }


}