using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redox_to_FHIR_sampleApp.Models
{

    public class PatientFHIRModel
    {
        public string resourceType { get; set; } = "Patient";
        public string id { get; set; }
        public List<Identifier> identifier { get; set; }
        public bool active { get; set; } = true;
        public List<NameModel> name { get; set; }
        public List<Telecom> telecom { get; set; }
        public string gender { get; set; }
        public string birthDate { get; set; }
        public MaritalStatus maritalStatus { get; set; }
        public List<AddressModel> address { get; set; }

    }
    public class Identifier
    {
        public Assigner assigner { get; set; }
    }
    public class NameModel
    {
        public string use { get; set; }
        public string family { get; set; }
        public List<string> given { get; set; }
        public string text { get; set; }
    }
    public class MaritalStatus
    {
        public List<CodingModel> coding { get; set; }
        public string text { get; set; }
    }
    public class CodingModel
    {

        public string system { get; set; }
        public string code { get; set; }
        public string display { get; set; }
    }
    public class Assigner
    {
        public object reference { get; set; }
    }
    public class Telecom
    {
        public string use { get; set; }
        public string system { get; set; }
        public string value { get; set; }
    }
    public class AddressModel
    {
        public string use { get; set; } = "home";
        public List<string> line { get; set; }
        public string text { get; set; }
        public string city { get; set; }

        public string district { get; set; }

        public string state { get; set; }

        public string postalCode { get; set; }

        public string country { get; set; }
    }
}
