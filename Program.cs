using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NewFhirApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var hostURI = "https://r3.smarthealthit.org/";
            FhirClient client = new FhirClient(hostURI);
            //List<string> PatientID = GetPatientsID(client);
            //foreach (var patient in PatientID)
            //{
            //    CreatePatientFile(client, "smart-1137192");
            //}
            CreatePatientFile(client, "smart-1137192");
        }

        private static void CreatePatientFile(FhirClient client, string patientid)
        {
            string SericeRootURI = "https://r3.smarthealthit.org/";
            UriBuilder UriBuildX = new UriBuilder(SericeRootURI);
            Bundle bundle = null;


            UriBuildX.Path = "Patient/" + patientid;
            var Returnedresource = client.InstanceOperation(UriBuildX.Uri, "everything");
            if (Returnedresource is Bundle)
            {
                bundle = Returnedresource as Bundle;
            }
            //var query = new string[] { "name=Rob" };
            //var bundle = client.Search("Patient", query);
        }

        private static List<string> GetPatientsID(FhirClient client)
        {
            List<string> patId = new List<string>();
            var result = client.Search<Patient>();
           while(result != null)
            {
                if(result.Entry != null)
                {
                    foreach(var pat in result.Entry)
                    {
                        patId.Add(pat.Resource.Id);
                    }
                }

                result = client.Continue(result);
            }
            

            return patId;
        }
    }
}
