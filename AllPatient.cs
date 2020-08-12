using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFhirApp
{
    class AllPatient
    {

        public class Rootobject
        {
            public string resourceType { get; set; }
            public string id { get; set; }
            public Meta meta { get; set; }
            public string type { get; set; }
            public Link[] link { get; set; }
            public Entry[] entry { get; set; }
        }

        public class Meta
        {
            public DateTime lastUpdated { get; set; }
        }

        public class Link
        {
            public string relation { get; set; }
            public string url { get; set; }
        }

        public class Entry
        {
            public string fullUrl { get; set; }
            public Resource resource { get; set; }
            public Search search { get; set; }
        }

        public class Resource
        {
            public string resourceType { get; set; }
            public string id { get; set; }
            public Meta1 meta { get; set; }
            public Text text { get; set; }
            public Identifier[] identifier { get; set; }
            public bool active { get; set; }
            public Name[] name { get; set; }
            public Telecom[] telecom { get; set; }
            public string gender { get; set; }
            public string birthDate { get; set; }
            public Address[] address { get; set; }
            public Generalpractitioner[] generalPractitioner { get; set; }
            public Extension2[] extension { get; set; }
            public DateTime deceasedDateTime { get; set; }
            public Maritalstatus maritalStatus { get; set; }
            public bool multipleBirthBoolean { get; set; }
            public Communication[] communication { get; set; }
        }

        public class Meta1
        {
            public string versionId { get; set; }
            public DateTime lastUpdated { get; set; }
            public Tag[] tag { get; set; }
            public string[] profile { get; set; }
        }

        public class Tag
        {
            public string system { get; set; }
            public string code { get; set; }
        }

        public class Text
        {
            public string status { get; set; }
            public string div { get; set; }
        }

        public class Maritalstatus
        {
            public Coding[] coding { get; set; }
            public string text { get; set; }
        }

        public class Coding
        {
            public string system { get; set; }
            public string code { get; set; }
        }

        public class Identifier
        {
            public string use { get; set; }
            public Type type { get; set; }
            public string system { get; set; }
            public string value { get; set; }
        }

        public class Type
        {
            public Coding1[] coding { get; set; }
            public string text { get; set; }
        }

        public class Coding1
        {
            public string system { get; set; }
            public string code { get; set; }
            public string display { get; set; }
        }

        public class Name
        {
            public string use { get; set; }
            public string family { get; set; }
            public string[] given { get; set; }
            public string[] prefix { get; set; }
            public string[] suffix { get; set; }
        }

        public class Telecom
        {
            public string system { get; set; }
            public string value { get; set; }
            public string use { get; set; }
        }

        public class Address
        {
            public string use { get; set; }
            public string[] line { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string postalCode { get; set; }
            public string country { get; set; }
            public Extension[] extension { get; set; }
        }

        public class Extension
        {
            public string url { get; set; }
            public Extension1[] extension { get; set; }
        }

        public class Extension1
        {
            public string url { get; set; }
            public float valueDecimal { get; set; }
        }

        public class Generalpractitioner
        {
            public string reference { get; set; }
        }

        public class Extension2
        {
            public string url { get; set; }
            public Valuecodeableconcept valueCodeableConcept { get; set; }
            public Valueaddress valueAddress { get; set; }
            public string valueString { get; set; }
            public string valueCode { get; set; }
            public bool valueBoolean { get; set; }
            public Valuehumanname valueHumanName { get; set; }
        }

        public class Valuecodeableconcept
        {
            public Coding2[] coding { get; set; }
            public string text { get; set; }
        }

        public class Coding2
        {
            public string system { get; set; }
            public string code { get; set; }
            public string display { get; set; }
        }

        public class Valueaddress
        {
            public string city { get; set; }
            public string state { get; set; }
            public string country { get; set; }
        }

        public class Valuehumanname
        {
            public string text { get; set; }
        }

        public class Communication
        {
            public Language language { get; set; }
        }

        public class Language
        {
            public Coding3[] coding { get; set; }
        }

        public class Coding3
        {
            public string system { get; set; }
            public string code { get; set; }
            public string display { get; set; }
        }

        public class Search
        {
            public string mode { get; set; }
        }

    }
}
