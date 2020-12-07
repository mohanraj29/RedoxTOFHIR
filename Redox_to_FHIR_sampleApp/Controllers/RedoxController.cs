using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Redox_to_FHIR_sampleApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Redox_to_FHIR_sampleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedoxController : ControllerBase
    {
        // GET: api/<RedoxController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RedoxController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RedoxController>
        [HttpPost]
        public ActionResult<PatientFHIRModel> Post(Patientadmin_Arrival value)
        {
            List<Identifier> identifiers = new List<Identifier>();
            Identifier identifire = new Identifier();
            Assigner assigner = new Assigner()
            {
                reference = "Organization/675555"
            };
            identifire.assigner = assigner;
            identifiers.Add(identifire);
            List<Telecom> telecom = new List<Telecom>();
            
            if (value.Patient.Demographics.PhoneNumber.Home != null)
            {
                Telecom tele = new Telecom();
                tele.use = "home";
                tele.system = "phone";
                tele.value = value.Patient.Demographics.PhoneNumber.Home;
                telecom.Add(tele);
            }
            if (value.Patient.Demographics.PhoneNumber.Office != null)
            {
                Telecom tele = new Telecom();
                tele.use = "work";
                tele.system = "phone";
                tele.value = value.Patient.Demographics.PhoneNumber.Office;
                telecom.Add(tele);
            }
            if (value.Patient.Demographics.PhoneNumber.Mobile != null)
            {
                Telecom tele = new Telecom();
                tele.use = "mobile";
                tele.system = "phone";
                tele.value = value.Patient.Demographics.PhoneNumber.Mobile;
                telecom.Add(tele);
            }
            List<NameModel> nameList = new List<NameModel>();
            NameModel name = new NameModel();
            name.use = "official";
            name.family = value.Patient.Demographics.LastName;
            List<string> given = new List<string>();
            given.Add(value.Patient.Demographics.FirstName);
            name.given = given;
            name.text = value.Patient.Demographics.LastName + ", " + value.Patient.Demographics.FirstName;
            nameList.Add(name);
            List<string> streat = new List<string>();
            streat.Add(value.Patient.Demographics.Address.StreetAddress);
            AddressModel address = new AddressModel()
            {
                city = value.Patient.Demographics.Address.City,
                country = value.Patient.Demographics.Address.Country,
                district = value.Patient.Demographics.Address.County,
                line = streat,
                postalCode = value.Patient.Demographics.Address.ZIP,
                state = value.Patient.Demographics.Address.State,
                text = string.Join(",", streat)+", "+ value.Patient.Demographics.Address.City+", "+ value.Patient.Demographics.Address.State+" "+
                        value.Patient.Demographics.Address.ZIP+", "+ value.Patient.Demographics.Address.Country
            };
            string id= "";
            foreach(var item in value.Patient.Identifiers)
            {
                if(item.IDType == "EHRID")
                {
                    id = item.ID;
                }
            }
            List<AddressModel> adr = new List<AddressModel>();
            adr.Add(address);
            MaritalStatus maritalStatus = new MaritalStatus();
            maritalStatus.text = value.Patient.Demographics.MaritalStatus;
            CodingModel coding = new CodingModel();
            coding.system = "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus";
            switch (value.Patient.Demographics.MaritalStatus)
            {
                case "Divorced":
                        coding.code = "D";
                    coding.display = "Divorced";
                        break;
                case "Legally Separated	": 
                case "Separated":
                    coding.code = "L";
                    coding.display = "Legally Separated";
                    break;
                case "Single":
                case "Unmarried":
                    coding.code = "U";
                    coding.display = "unmarried";
                    break;
                case "Married":
                    coding.code = "M";
                    coding.display = "Married";
                    break;
                default:
                    coding.code = "UNK";
                    coding.display = "unknown";
                    coding.system = "http://terminology.hl7.org/CodeSystem/v3-NullFlavor";
                    break;
            }

            List<CodingModel> codeList = new List<CodingModel>();
            codeList.Add(coding);
            maritalStatus.coding = codeList;
            PatientFHIRModel patient = new PatientFHIRModel()
            {
                id = id,
                address = adr,
                maritalStatus = maritalStatus,
                birthDate = value.Patient.Demographics.DOB,
                gender = value.Patient.Demographics.Sex.ToLower(),
                identifier = identifiers,
                name = nameList,
                telecom = telecom      
            };

            return patient;
        }

        
    }
}
