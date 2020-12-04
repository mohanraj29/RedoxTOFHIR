
namespace Redox_to_FHIR_sampleApp.Models
{
    #pragma warning disable // Disable all warnings

    public partial class Source : System.ComponentModel.INotifyPropertyChanged
    {
        private string _iD;
        private string _name;
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Source FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Source>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Message : System.ComponentModel.INotifyPropertyChanged
    {
        private double? _iD;
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Message FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Message>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Transmission : System.ComponentModel.INotifyPropertyChanged
    {
        private double? _iD;
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Transmission FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Transmission>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PhoneNumber : System.ComponentModel.INotifyPropertyChanged
    {
        private string _home;
        private string _office;
        private string _mobile;
    
        [Newtonsoft.Json.JsonProperty("Home", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Home
        {
            get { return _home; }
            set 
            {
                if (_home != value)
                {
                    _home = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Office", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Office
        {
            get { return _office; }
            set 
            {
                if (_office != value)
                {
                    _office = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Mobile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mobile
        {
            get { return _mobile; }
            set 
            {
                if (_mobile != value)
                {
                    _mobile = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static PhoneNumber FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PhoneNumber>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Address : System.ComponentModel.INotifyPropertyChanged
    {
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zIP;
        private string _county;
        private string _country;
    
        [Newtonsoft.Json.JsonProperty("StreetAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StreetAddress
        {
            get { return _streetAddress; }
            set 
            {
                if (_streetAddress != value)
                {
                    _streetAddress = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City
        {
            get { return _city; }
            set 
            {
                if (_city != value)
                {
                    _city = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("State", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State
        {
            get { return _state; }
            set 
            {
                if (_state != value)
                {
                    _state = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ZIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZIP
        {
            get { return _zIP; }
            set 
            {
                if (_zIP != value)
                {
                    _zIP = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("County", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string County
        {
            get { return _county; }
            set 
            {
                if (_county != value)
                {
                    _county = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Country", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Country
        {
            get { return _country; }
            set 
            {
                if (_country != value)
                {
                    _country = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Address FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Address>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Type : System.ComponentModel.INotifyPropertyChanged
    {
        private string _code;
        private string _codeset;
        private string _name;
    
        [Newtonsoft.Json.JsonProperty("Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code
        {
            get { return _code; }
            set 
            {
                if (_code != value)
                {
                    _code = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Codeset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Codeset
        {
            get { return _codeset; }
            set 
            {
                if (_codeset != value)
                {
                    _codeset = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Type FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Type>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Severity : System.ComponentModel.INotifyPropertyChanged
    {
        private string _code;
        private string _codeset;
        private string _name;
    
        [Newtonsoft.Json.JsonProperty("Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code
        {
            get { return _code; }
            set 
            {
                if (_code != value)
                {
                    _code = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Codeset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Codeset
        {
            get { return _codeset; }
            set 
            {
                if (_codeset != value)
                {
                    _codeset = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Severity FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Severity>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PhoneNumber_1 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _office;
    
        [Newtonsoft.Json.JsonProperty("Office", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Office
        {
            get { return _office; }
            set 
            {
                if (_office != value)
                {
                    _office = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static PhoneNumber_1 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PhoneNumber_1>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Location : System.ComponentModel.INotifyPropertyChanged
    {
        private string _type;
        private string _facility;
        private string _department;
        private string _room;
    
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type
        {
            get { return _type; }
            set 
            {
                if (_type != value)
                {
                    _type = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Facility", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Facility
        {
            get { return _facility; }
            set 
            {
                if (_facility != value)
                {
                    _facility = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Department", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Department
        {
            get { return _department; }
            set 
            {
                if (_department != value)
                {
                    _department = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Room", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Room
        {
            get { return _room; }
            set 
            {
                if (_room != value)
                {
                    _room = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Location FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Location>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Spouse : System.ComponentModel.INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Spouse FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Spouse>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PhoneNumber_2 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _home;
        private string _business;
        private string _mobile;
    
        [Newtonsoft.Json.JsonProperty("Home", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Home
        {
            get { return _home; }
            set 
            {
                if (_home != value)
                {
                    _home = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Business", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Business
        {
            get { return _business; }
            set 
            {
                if (_business != value)
                {
                    _business = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Mobile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mobile
        {
            get { return _mobile; }
            set 
            {
                if (_mobile != value)
                {
                    _mobile = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static PhoneNumber_2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PhoneNumber_2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Plan : System.ComponentModel.INotifyPropertyChanged
    {
        private string _iD;
        private string _iDType;
        private string _name;
        private string _type;
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IDType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IDType
        {
            get { return _iDType; }
            set 
            {
                if (_iDType != value)
                {
                    _iDType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type
        {
            get { return _type; }
            set 
            {
                if (_type != value)
                {
                    _type = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Plan FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Plan>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DestinationsItem : System.ComponentModel.INotifyPropertyChanged
    {
        private string _iD;
        private string _name;
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static DestinationsItem FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DestinationsItem>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class IdentifiersItem : System.ComponentModel.INotifyPropertyChanged
    {
        private string _iD;
        private string _iDType;
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IDType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string IDType
        {
            get { return _iDType; }
            set 
            {
                if (_iDType != value)
                {
                    _iDType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static IdentifiersItem FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IdentifiersItem>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DiagnosesItem : System.ComponentModel.INotifyPropertyChanged
    {
        private string _code;
        private string _codeset;
        private string _name;
        private string _type;
        private string _documentedDateTime;
    
        [Newtonsoft.Json.JsonProperty("Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code
        {
            get { return _code; }
            set 
            {
                if (_code != value)
                {
                    _code = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Codeset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Codeset
        {
            get { return _codeset; }
            set 
            {
                if (_codeset != value)
                {
                    _codeset = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type
        {
            get { return _type; }
            set 
            {
                if (_type != value)
                {
                    _type = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DocumentedDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DocumentedDateTime
        {
            get { return _documentedDateTime; }
            set 
            {
                if (_documentedDateTime != value)
                {
                    _documentedDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static DiagnosesItem FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DiagnosesItem>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ReactionItem : System.ComponentModel.INotifyPropertyChanged
    {
        private string _code;
        private string _codeset;
        private string _name;
    
        [Newtonsoft.Json.JsonProperty("Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code
        {
            get { return _code; }
            set 
            {
                if (_code != value)
                {
                    _code = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Codeset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Codeset
        {
            get { return _codeset; }
            set 
            {
                if (_codeset != value)
                {
                    _codeset = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static ReactionItem FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ReactionItem>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class IdentifiersItem_1 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _iD;
        private string _iDType;
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IDType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IDType
        {
            get { return _iDType; }
            set 
            {
                if (_iDType != value)
                {
                    _iDType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static IdentifiersItem_1 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IdentifiersItem_1>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Location_1 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _type;
        private string _facility;
        private string _department;
        private string _room;
        private string _bed;
    
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type
        {
            get { return _type; }
            set 
            {
                if (_type != value)
                {
                    _type = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Facility", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Facility
        {
            get { return _facility; }
            set 
            {
                if (_facility != value)
                {
                    _facility = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Department", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Department
        {
            get { return _department; }
            set 
            {
                if (_department != value)
                {
                    _department = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Room", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Room
        {
            get { return _room; }
            set 
            {
                if (_room != value)
                {
                    _room = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Bed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bed
        {
            get { return _bed; }
            set 
            {
                if (_bed != value)
                {
                    _bed = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Location_1 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Location_1>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DischargeStatus : System.ComponentModel.INotifyPropertyChanged
    {
        private string _code;
        private string _codeset;
        private string _description;
    
        [Newtonsoft.Json.JsonProperty("Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code
        {
            get { return _code; }
            set 
            {
                if (_code != value)
                {
                    _code = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Codeset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Codeset
        {
            get { return _codeset; }
            set 
            {
                if (_codeset != value)
                {
                    _codeset = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set 
            {
                if (_description != value)
                {
                    _description = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static DischargeStatus FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DischargeStatus>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DischargeLocation : System.ComponentModel.INotifyPropertyChanged
    {
        private string _type;
        private string _facility;
        private string _department;
        private string _room;
    
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type
        {
            get { return _type; }
            set 
            {
                if (_type != value)
                {
                    _type = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Facility", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Facility
        {
            get { return _facility; }
            set 
            {
                if (_facility != value)
                {
                    _facility = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Department", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Department
        {
            get { return _department; }
            set 
            {
                if (_department != value)
                {
                    _department = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Room", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Room
        {
            get { return _room; }
            set 
            {
                if (_room != value)
                {
                    _room = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static DischargeLocation FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DischargeLocation>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PreviousIdentifiersItem : System.ComponentModel.INotifyPropertyChanged
    {
        private string _iD;
        private string _iDType;
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IDType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string IDType
        {
            get { return _iDType; }
            set 
            {
                if (_iDType != value)
                {
                    _iDType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static PreviousIdentifiersItem FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PreviousIdentifiersItem>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Visit : System.ComponentModel.INotifyPropertyChanged
    {
        private string _visitNumber;
    
        [Newtonsoft.Json.JsonProperty("VisitNumber", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string VisitNumber
        {
            get { return _visitNumber; }
            set 
            {
                if (_visitNumber != value)
                {
                    _visitNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Visit FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Visit>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Meta : System.ComponentModel.INotifyPropertyChanged
    {
        private string _dataModel;
        private string _eventType;
        private string _eventDateTime;
        private bool? _test;
        private Source _source = new Source();
        private System.Collections.ObjectModel.ObservableCollection<DestinationsItem> _destinations = new System.Collections.ObjectModel.ObservableCollection<DestinationsItem>();
        private Message _message = new Message();
        private Transmission _transmission = new Transmission();
        private string _facilityCode;
    
        [Newtonsoft.Json.JsonProperty("DataModel", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string DataModel
        {
            get { return _dataModel; }
            set 
            {
                if (_dataModel != value)
                {
                    _dataModel = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EventType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string EventType
        {
            get { return _eventType; }
            set 
            {
                if (_eventType != value)
                {
                    _eventType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EventDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EventDateTime
        {
            get { return _eventDateTime; }
            set 
            {
                if (_eventDateTime != value)
                {
                    _eventDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Test", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Test
        {
            get { return _test; }
            set 
            {
                if (_test != value)
                {
                    _test = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Source", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Source Source
        {
            get { return _source; }
            set 
            {
                if (_source != value)
                {
                    _source = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Destinations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<DestinationsItem> Destinations
        {
            get { return _destinations; }
            set 
            {
                if (_destinations != value)
                {
                    _destinations = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Message Message
        {
            get { return _message; }
            set 
            {
                if (_message != value)
                {
                    _message = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Transmission", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Transmission Transmission
        {
            get { return _transmission; }
            set 
            {
                if (_transmission != value)
                {
                    _transmission = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FacilityCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FacilityCode
        {
            get { return _facilityCode; }
            set 
            {
                if (_facilityCode != value)
                {
                    _facilityCode = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Meta FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Meta>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patient : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> _identifiers = new System.Collections.ObjectModel.ObservableCollection<IdentifiersItem>();
        private Demographics2 _demographics = new Demographics2();
        private System.Collections.ObjectModel.ObservableCollection<object> _notes = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<ContactsItem> _contacts = new System.Collections.ObjectModel.ObservableCollection<ContactsItem>();
        private System.Collections.ObjectModel.ObservableCollection<DiagnosesItem> _diagnoses = new System.Collections.ObjectModel.ObservableCollection<DiagnosesItem>();
        private System.Collections.ObjectModel.ObservableCollection<AllergiesItem> _allergies = new System.Collections.ObjectModel.ObservableCollection<AllergiesItem>();
        private PCP2 _pCP = new PCP2();
    
        [Newtonsoft.Json.JsonProperty("Identifiers", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> Identifiers
        {
            get { return _identifiers; }
            set 
            {
                if (_identifiers != value)
                {
                    _identifiers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Demographics", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Demographics2 Demographics
        {
            get { return _demographics; }
            set 
            {
                if (_demographics != value)
                {
                    _demographics = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Notes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Notes
        {
            get { return _notes; }
            set 
            {
                if (_notes != value)
                {
                    _notes = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Contacts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ContactsItem> Contacts
        {
            get { return _contacts; }
            set 
            {
                if (_contacts != value)
                {
                    _contacts = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Diagnoses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<DiagnosesItem> Diagnoses
        {
            get { return _diagnoses; }
            set 
            {
                if (_diagnoses != value)
                {
                    _diagnoses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Allergies", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<AllergiesItem> Allergies
        {
            get { return _allergies; }
            set 
            {
                if (_allergies != value)
                {
                    _allergies = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PCP", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PCP2 PCP
        {
            get { return _pCP; }
            set 
            {
                if (_pCP != value)
                {
                    _pCP = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patient FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patient>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Demographics : System.ComponentModel.INotifyPropertyChanged
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _dOB;
        private string _sSN;
        private string _sex;
        private string _race;
        private bool? _isHispanic;
        private string _maritalStatus;
        private bool? _isDeceased;
        private string _deathDateTime;
        private PhoneNumber _phoneNumber = new PhoneNumber();
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private string _language;
        private System.Collections.ObjectModel.ObservableCollection<object> _citizenship = new System.Collections.ObjectModel.ObservableCollection<object>();
        private Address _address = new Address();
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiddleName
        {
            get { return _middleName; }
            set 
            {
                if (_middleName != value)
                {
                    _middleName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DOB", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DOB
        {
            get { return _dOB; }
            set 
            {
                if (_dOB != value)
                {
                    _dOB = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("SSN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SSN
        {
            get { return _sSN; }
            set 
            {
                if (_sSN != value)
                {
                    _sSN = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Sex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Sex
        {
            get { return _sex; }
            set 
            {
                if (_sex != value)
                {
                    _sex = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Race", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Race
        {
            get { return _race; }
            set 
            {
                if (_race != value)
                {
                    _race = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IsHispanic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsHispanic
        {
            get { return _isHispanic; }
            set 
            {
                if (_isHispanic != value)
                {
                    _isHispanic = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MaritalStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaritalStatus
        {
            get { return _maritalStatus; }
            set 
            {
                if (_maritalStatus != value)
                {
                    _maritalStatus = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IsDeceased", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsDeceased
        {
            get { return _isDeceased; }
            set 
            {
                if (_isDeceased != value)
                {
                    _isDeceased = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DeathDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeathDateTime
        {
            get { return _deathDateTime; }
            set 
            {
                if (_deathDateTime != value)
                {
                    _deathDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language
        {
            get { return _language; }
            set 
            {
                if (_language != value)
                {
                    _language = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Citizenship", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Citizenship
        {
            get { return _citizenship; }
            set 
            {
                if (_citizenship != value)
                {
                    _citizenship = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Demographics FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Demographics>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PCP : System.ComponentModel.INotifyPropertyChanged
    {
        private string _nPI;
        private string _iD;
        private string _iDType;
        private string _firstName;
        private string _lastName;
        private System.Collections.ObjectModel.ObservableCollection<object> _credentials = new System.Collections.ObjectModel.ObservableCollection<object>();
        private Address _address = new Address();
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private PhoneNumber_1 _phoneNumber = new PhoneNumber_1();
        private Location _location = new Location();
    
        [Newtonsoft.Json.JsonProperty("NPI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NPI
        {
            get { return _nPI; }
            set 
            {
                if (_nPI != value)
                {
                    _nPI = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IDType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IDType
        {
            get { return _iDType; }
            set 
            {
                if (_iDType != value)
                {
                    _iDType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Credentials", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Credentials
        {
            get { return _credentials; }
            set 
            {
                if (_credentials != value)
                {
                    _credentials = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber_1 PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location
        {
            get { return _location; }
            set 
            {
                if (_location != value)
                {
                    _location = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static PCP FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PCP>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AttendingProvider : System.ComponentModel.INotifyPropertyChanged
    {
        private string _iD;
        private string _iDType;
        private string _firstName;
        private string _lastName;
        private System.Collections.ObjectModel.ObservableCollection<object> _credentials = new System.Collections.ObjectModel.ObservableCollection<object>();
        private Address _address = new Address();
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private PhoneNumber _phoneNumber = new PhoneNumber();
        private Location _location = new Location();
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IDType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IDType
        {
            get { return _iDType; }
            set 
            {
                if (_iDType != value)
                {
                    _iDType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Credentials", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Credentials
        {
            get { return _credentials; }
            set 
            {
                if (_credentials != value)
                {
                    _credentials = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location
        {
            get { return _location; }
            set 
            {
                if (_location != value)
                {
                    _location = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static AttendingProvider FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AttendingProvider>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ConsultingProvider : System.ComponentModel.INotifyPropertyChanged
    {
        private string _iD;
        private string _iDType;
        private string _firstName;
        private string _lastName;
        private System.Collections.ObjectModel.ObservableCollection<object> _credentials = new System.Collections.ObjectModel.ObservableCollection<object>();
        private Address _address = new Address();
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private PhoneNumber _phoneNumber = new PhoneNumber();
        private Location _location = new Location();
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IDType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IDType
        {
            get { return _iDType; }
            set 
            {
                if (_iDType != value)
                {
                    _iDType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Credentials", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Credentials
        {
            get { return _credentials; }
            set 
            {
                if (_credentials != value)
                {
                    _credentials = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location
        {
            get { return _location; }
            set 
            {
                if (_location != value)
                {
                    _location = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static ConsultingProvider FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ConsultingProvider>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ReferringProvider : System.ComponentModel.INotifyPropertyChanged
    {
        private string _iD;
        private string _iDType;
        private string _firstName;
        private string _lastName;
        private System.Collections.ObjectModel.ObservableCollection<object> _credentials = new System.Collections.ObjectModel.ObservableCollection<object>();
        private Address _address = new Address();
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private PhoneNumber _phoneNumber = new PhoneNumber();
        private Location _location = new Location();
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IDType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IDType
        {
            get { return _iDType; }
            set 
            {
                if (_iDType != value)
                {
                    _iDType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Credentials", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Credentials
        {
            get { return _credentials; }
            set 
            {
                if (_credentials != value)
                {
                    _credentials = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location
        {
            get { return _location; }
            set 
            {
                if (_location != value)
                {
                    _location = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static ReferringProvider FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ReferringProvider>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AdmittingProvider : System.ComponentModel.INotifyPropertyChanged
    {
        private string _iD;
        private string _iDType;
        private string _firstName;
        private string _lastName;
        private System.Collections.ObjectModel.ObservableCollection<object> _credentials = new System.Collections.ObjectModel.ObservableCollection<object>();
        private Address _address = new Address();
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private PhoneNumber _phoneNumber = new PhoneNumber();
        private Location _location = new Location();
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IDType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IDType
        {
            get { return _iDType; }
            set 
            {
                if (_iDType != value)
                {
                    _iDType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Credentials", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Credentials
        {
            get { return _credentials; }
            set 
            {
                if (_credentials != value)
                {
                    _credentials = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location
        {
            get { return _location; }
            set 
            {
                if (_location != value)
                {
                    _location = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static AdmittingProvider FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AdmittingProvider>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Guarantor : System.ComponentModel.INotifyPropertyChanged
    {
        private string _number;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _sSN;
        private string _dOB;
        private string _sex;
        private Spouse _spouse = new Spouse();
        private Address _address = new Address();
        private PhoneNumber_2 _phoneNumber = new PhoneNumber_2();
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private string _type;
        private string _relationToPatient;
        private Employer2 _employer = new Employer2();
    
        [Newtonsoft.Json.JsonProperty("Number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Number
        {
            get { return _number; }
            set 
            {
                if (_number != value)
                {
                    _number = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiddleName
        {
            get { return _middleName; }
            set 
            {
                if (_middleName != value)
                {
                    _middleName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("SSN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SSN
        {
            get { return _sSN; }
            set 
            {
                if (_sSN != value)
                {
                    _sSN = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DOB", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DOB
        {
            get { return _dOB; }
            set 
            {
                if (_dOB != value)
                {
                    _dOB = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Sex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Sex
        {
            get { return _sex; }
            set 
            {
                if (_sex != value)
                {
                    _sex = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Spouse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Spouse Spouse
        {
            get { return _spouse; }
            set 
            {
                if (_spouse != value)
                {
                    _spouse = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber_2 PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type
        {
            get { return _type; }
            set 
            {
                if (_type != value)
                {
                    _type = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("RelationToPatient", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RelationToPatient
        {
            get { return _relationToPatient; }
            set 
            {
                if (_relationToPatient != value)
                {
                    _relationToPatient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Employer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Employer2 Employer
        {
            get { return _employer; }
            set 
            {
                if (_employer != value)
                {
                    _employer = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Guarantor FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Guarantor>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Employer : System.ComponentModel.INotifyPropertyChanged
    {
        private string _name;
        private Address _address = new Address();
        private string _phoneNumber;
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Employer FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Employer>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Company : System.ComponentModel.INotifyPropertyChanged
    {
        private string _iD;
        private string _iDType;
        private string _name;
        private Address _address = new Address();
        private string _phoneNumber;
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IDType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IDType
        {
            get { return _iDType; }
            set 
            {
                if (_iDType != value)
                {
                    _iDType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Company FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Company>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Insured : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifiersItem_1> _identifiers = new System.Collections.ObjectModel.ObservableCollection<IdentifiersItem_1>();
        private string _lastName;
        private string _middleName;
        private string _firstName;
        private string _sSN;
        private string _relationship;
        private string _dOB;
        private string _sex;
        private Address _address = new Address();
    
        [Newtonsoft.Json.JsonProperty("Identifiers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<IdentifiersItem_1> Identifiers
        {
            get { return _identifiers; }
            set 
            {
                if (_identifiers != value)
                {
                    _identifiers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiddleName
        {
            get { return _middleName; }
            set 
            {
                if (_middleName != value)
                {
                    _middleName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("SSN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SSN
        {
            get { return _sSN; }
            set 
            {
                if (_sSN != value)
                {
                    _sSN = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Relationship", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Relationship
        {
            get { return _relationship; }
            set 
            {
                if (_relationship != value)
                {
                    _relationship = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DOB", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DOB
        {
            get { return _dOB; }
            set 
            {
                if (_dOB != value)
                {
                    _dOB = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Sex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Sex
        {
            get { return _sex; }
            set 
            {
                if (_sex != value)
                {
                    _sex = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Insured FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Insured>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Models : System.ComponentModel.INotifyPropertyChanged
    {
        private Patientadmin_Arrival _patientadmin_Arrival = new Patientadmin_Arrival();
        private Patientadmin_Cancel _patientadmin_Cancel = new Patientadmin_Cancel();
        private Patientadmin_Censusquery _patientadmin_Censusquery = new Patientadmin_Censusquery();
        private Patientadmin_Censusqueryresponse _patientadmin_Censusqueryresponse = new Patientadmin_Censusqueryresponse();
        private Patientadmin_Discharge _patientadmin_Discharge = new Patientadmin_Discharge();
        private Patientadmin_Newpatient _patientadmin_Newpatient = new Patientadmin_Newpatient();
        private Patientadmin_Patientmerge _patientadmin_Patientmerge = new Patientadmin_Patientmerge();
        private Patientadmin_Patientupdate _patientadmin_Patientupdate = new Patientadmin_Patientupdate();
        private Patientadmin_Preadmit _patientadmin_Preadmit = new Patientadmin_Preadmit();
        private Patientadmin_Registration _patientadmin_Registration = new Patientadmin_Registration();
        private Patientadmin_Transfer _patientadmin_Transfer = new Patientadmin_Transfer();
        private Patientadmin_Visitmerge _patientadmin_Visitmerge = new Patientadmin_Visitmerge();
        private Patientadmin_Visitquery _patientadmin_Visitquery = new Patientadmin_Visitquery();
        private Patientadmin_Visitqueryresponse _patientadmin_Visitqueryresponse = new Patientadmin_Visitqueryresponse();
        private Patientadmin_Visitupdate _patientadmin_Visitupdate = new Patientadmin_Visitupdate();
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Arrival", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Arrival Patientadmin_Arrival
        {
            get { return _patientadmin_Arrival; }
            set 
            {
                if (_patientadmin_Arrival != value)
                {
                    _patientadmin_Arrival = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Cancel", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Cancel Patientadmin_Cancel
        {
            get { return _patientadmin_Cancel; }
            set 
            {
                if (_patientadmin_Cancel != value)
                {
                    _patientadmin_Cancel = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Censusquery", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Censusquery Patientadmin_Censusquery
        {
            get { return _patientadmin_Censusquery; }
            set 
            {
                if (_patientadmin_Censusquery != value)
                {
                    _patientadmin_Censusquery = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Censusqueryresponse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Censusqueryresponse Patientadmin_Censusqueryresponse
        {
            get { return _patientadmin_Censusqueryresponse; }
            set 
            {
                if (_patientadmin_Censusqueryresponse != value)
                {
                    _patientadmin_Censusqueryresponse = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Discharge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Discharge Patientadmin_Discharge
        {
            get { return _patientadmin_Discharge; }
            set 
            {
                if (_patientadmin_Discharge != value)
                {
                    _patientadmin_Discharge = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Newpatient", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Newpatient Patientadmin_Newpatient
        {
            get { return _patientadmin_Newpatient; }
            set 
            {
                if (_patientadmin_Newpatient != value)
                {
                    _patientadmin_Newpatient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Patientmerge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Patientmerge Patientadmin_Patientmerge
        {
            get { return _patientadmin_Patientmerge; }
            set 
            {
                if (_patientadmin_Patientmerge != value)
                {
                    _patientadmin_Patientmerge = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Patientupdate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Patientupdate Patientadmin_Patientupdate
        {
            get { return _patientadmin_Patientupdate; }
            set 
            {
                if (_patientadmin_Patientupdate != value)
                {
                    _patientadmin_Patientupdate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Preadmit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Preadmit Patientadmin_Preadmit
        {
            get { return _patientadmin_Preadmit; }
            set 
            {
                if (_patientadmin_Preadmit != value)
                {
                    _patientadmin_Preadmit = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Registration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Registration Patientadmin_Registration
        {
            get { return _patientadmin_Registration; }
            set 
            {
                if (_patientadmin_Registration != value)
                {
                    _patientadmin_Registration = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Transfer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Transfer Patientadmin_Transfer
        {
            get { return _patientadmin_Transfer; }
            set 
            {
                if (_patientadmin_Transfer != value)
                {
                    _patientadmin_Transfer = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Visitmerge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Visitmerge Patientadmin_Visitmerge
        {
            get { return _patientadmin_Visitmerge; }
            set 
            {
                if (_patientadmin_Visitmerge != value)
                {
                    _patientadmin_Visitmerge = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Visitquery", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Visitquery Patientadmin_Visitquery
        {
            get { return _patientadmin_Visitquery; }
            set 
            {
                if (_patientadmin_Visitquery != value)
                {
                    _patientadmin_Visitquery = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Visitqueryresponse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Visitqueryresponse Patientadmin_Visitqueryresponse
        {
            get { return _patientadmin_Visitqueryresponse; }
            set 
            {
                if (_patientadmin_Visitqueryresponse != value)
                {
                    _patientadmin_Visitqueryresponse = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patientadmin_Visitupdate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Patientadmin_Visitupdate Patientadmin_Visitupdate
        {
            get { return _patientadmin_Visitupdate; }
            set 
            {
                if (_patientadmin_Visitupdate != value)
                {
                    _patientadmin_Visitupdate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Models FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Models>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Demographics2 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _dOB;
        private string _sSN;
        private string _sex;
        private string _race;
        private bool? _isHispanic;
        private string _maritalStatus;
        private bool? _isDeceased;
        private string _deathDateTime;
        private PhoneNumber _phoneNumber = new PhoneNumber();
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private string _language;
        private System.Collections.ObjectModel.ObservableCollection<object> _citizenship = new System.Collections.ObjectModel.ObservableCollection<object>();
        private Address _address = new Address();
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiddleName
        {
            get { return _middleName; }
            set 
            {
                if (_middleName != value)
                {
                    _middleName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DOB", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DOB
        {
            get { return _dOB; }
            set 
            {
                if (_dOB != value)
                {
                    _dOB = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("SSN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SSN
        {
            get { return _sSN; }
            set 
            {
                if (_sSN != value)
                {
                    _sSN = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Sex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Sex
        {
            get { return _sex; }
            set 
            {
                if (_sex != value)
                {
                    _sex = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Race", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Race
        {
            get { return _race; }
            set 
            {
                if (_race != value)
                {
                    _race = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IsHispanic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsHispanic
        {
            get { return _isHispanic; }
            set 
            {
                if (_isHispanic != value)
                {
                    _isHispanic = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MaritalStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaritalStatus
        {
            get { return _maritalStatus; }
            set 
            {
                if (_maritalStatus != value)
                {
                    _maritalStatus = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IsDeceased", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsDeceased
        {
            get { return _isDeceased; }
            set 
            {
                if (_isDeceased != value)
                {
                    _isDeceased = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DeathDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeathDateTime
        {
            get { return _deathDateTime; }
            set 
            {
                if (_deathDateTime != value)
                {
                    _deathDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language
        {
            get { return _language; }
            set 
            {
                if (_language != value)
                {
                    _language = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Citizenship", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Citizenship
        {
            get { return _citizenship; }
            set 
            {
                if (_citizenship != value)
                {
                    _citizenship = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Demographics2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Demographics2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ContactsItem : System.ComponentModel.INotifyPropertyChanged
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private Address _address = new Address();
        private PhoneNumber _phoneNumber = new PhoneNumber();
        private string _relationToPatient;
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<object> _roles = new System.Collections.ObjectModel.ObservableCollection<object>();
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiddleName
        {
            get { return _middleName; }
            set 
            {
                if (_middleName != value)
                {
                    _middleName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("RelationToPatient", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RelationToPatient
        {
            get { return _relationToPatient; }
            set 
            {
                if (_relationToPatient != value)
                {
                    _relationToPatient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Roles", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Roles
        {
            get { return _roles; }
            set 
            {
                if (_roles != value)
                {
                    _roles = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static ContactsItem FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ContactsItem>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AllergiesItem : System.ComponentModel.INotifyPropertyChanged
    {
        private string _code;
        private string _codeset;
        private string _name;
        private Type _type = new Type();
        private string _onsetDateTime;
        private System.Collections.ObjectModel.ObservableCollection<ReactionItem> _reaction = new System.Collections.ObjectModel.ObservableCollection<ReactionItem>();
        private Severity _severity = new Severity();
        private string _status;
    
        [Newtonsoft.Json.JsonProperty("Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code
        {
            get { return _code; }
            set 
            {
                if (_code != value)
                {
                    _code = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Codeset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Codeset
        {
            get { return _codeset; }
            set 
            {
                if (_codeset != value)
                {
                    _codeset = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Type Type
        {
            get { return _type; }
            set 
            {
                if (_type != value)
                {
                    _type = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("OnsetDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OnsetDateTime
        {
            get { return _onsetDateTime; }
            set 
            {
                if (_onsetDateTime != value)
                {
                    _onsetDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Reaction", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ReactionItem> Reaction
        {
            get { return _reaction; }
            set 
            {
                if (_reaction != value)
                {
                    _reaction = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Severity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Severity Severity
        {
            get { return _severity; }
            set 
            {
                if (_severity != value)
                {
                    _severity = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status
        {
            get { return _status; }
            set 
            {
                if (_status != value)
                {
                    _status = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static AllergiesItem FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AllergiesItem>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PCP2 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _nPI;
        private string _iD;
        private string _iDType;
        private string _firstName;
        private string _lastName;
        private System.Collections.ObjectModel.ObservableCollection<object> _credentials = new System.Collections.ObjectModel.ObservableCollection<object>();
        private Address _address = new Address();
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private PhoneNumber_1 _phoneNumber = new PhoneNumber_1();
        private Location _location = new Location();
    
        [Newtonsoft.Json.JsonProperty("NPI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NPI
        {
            get { return _nPI; }
            set 
            {
                if (_nPI != value)
                {
                    _nPI = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IDType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IDType
        {
            get { return _iDType; }
            set 
            {
                if (_iDType != value)
                {
                    _iDType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Credentials", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Credentials
        {
            get { return _credentials; }
            set 
            {
                if (_credentials != value)
                {
                    _credentials = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber_1 PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location
        {
            get { return _location; }
            set 
            {
                if (_location != value)
                {
                    _location = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static PCP2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PCP2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Employer2 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _name;
        private Address _address = new Address();
        private string _phoneNumber;
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Employer2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Employer2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Arrival : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private Patient _patient = new Patient();
        private Visit _visit = new Visit();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patient", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Patient Patient
        {
            get { return _patient; }
            set 
            {
                if (_patient != value)
                {
                    _patient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Visit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Visit Visit
        {
            get { return _visit; }
            set 
            {
                if (_visit != value)
                {
                    _visit = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Arrival FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Arrival>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Cancel : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta2 _meta = new Meta2();
        private Patient2 _patient = new Patient2();
        private Visit2 _visit = new Visit2();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta2 Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patient", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Patient2 Patient
        {
            get { return _patient; }
            set 
            {
                if (_patient != value)
                {
                    _patient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Visit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Visit2 Visit
        {
            get { return _visit; }
            set 
            {
                if (_visit != value)
                {
                    _visit = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Cancel FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Cancel>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Censusquery : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private System.Collections.ObjectModel.ObservableCollection<object> _patientClasses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<object> _departments = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<object> _facilities = new System.Collections.ObjectModel.ObservableCollection<object>();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PatientClasses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> PatientClasses
        {
            get { return _patientClasses; }
            set 
            {
                if (_patientClasses != value)
                {
                    _patientClasses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Departments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Departments
        {
            get { return _departments; }
            set 
            {
                if (_departments != value)
                {
                    _departments = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Facilities", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Facilities
        {
            get { return _facilities; }
            set 
            {
                if (_facilities != value)
                {
                    _facilities = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Censusquery FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Censusquery>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Censusqueryresponse : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private System.Collections.ObjectModel.ObservableCollection<PatientsItem> _patients = new System.Collections.ObjectModel.ObservableCollection<PatientsItem>();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patients", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<PatientsItem> Patients
        {
            get { return _patients; }
            set 
            {
                if (_patients != value)
                {
                    _patients = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Censusqueryresponse FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Censusqueryresponse>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Discharge : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private Patient _patient = new Patient();
        private Visit3 _visit = new Visit3();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patient", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Patient Patient
        {
            get { return _patient; }
            set 
            {
                if (_patient != value)
                {
                    _patient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Visit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Visit3 Visit
        {
            get { return _visit; }
            set 
            {
                if (_visit != value)
                {
                    _visit = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Discharge FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Discharge>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Newpatient : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private Patient3 _patient = new Patient3();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patient", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Patient3 Patient
        {
            get { return _patient; }
            set 
            {
                if (_patient != value)
                {
                    _patient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Newpatient FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Newpatient>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Patientmerge : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private Patient4 _patient = new Patient4();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patient", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Patient4 Patient
        {
            get { return _patient; }
            set 
            {
                if (_patient != value)
                {
                    _patient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Patientmerge FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Patientmerge>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Patientupdate : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private Patient5 _patient = new Patient5();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patient", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Patient5 Patient
        {
            get { return _patient; }
            set 
            {
                if (_patient != value)
                {
                    _patient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Patientupdate FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Patientupdate>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Preadmit : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private Patient _patient = new Patient();
        private Visit _visit = new Visit();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patient", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Patient Patient
        {
            get { return _patient; }
            set 
            {
                if (_patient != value)
                {
                    _patient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Visit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Visit Visit
        {
            get { return _visit; }
            set 
            {
                if (_visit != value)
                {
                    _visit = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Preadmit FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Preadmit>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Registration : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private Patient _patient = new Patient();
        private Visit _visit = new Visit();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patient", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Patient Patient
        {
            get { return _patient; }
            set 
            {
                if (_patient != value)
                {
                    _patient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Visit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Visit Visit
        {
            get { return _visit; }
            set 
            {
                if (_visit != value)
                {
                    _visit = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Registration FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Registration>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Transfer : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private Patient _patient = new Patient();
        private Visit4 _visit = new Visit4();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patient", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Patient Patient
        {
            get { return _patient; }
            set 
            {
                if (_patient != value)
                {
                    _patient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Visit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Visit4 Visit
        {
            get { return _visit; }
            set 
            {
                if (_visit != value)
                {
                    _visit = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Transfer FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Transfer>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Visitmerge : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private Patient6 _patient = new Patient6();
        private Visit _visit = new Visit();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patient", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Patient6 Patient
        {
            get { return _patient; }
            set 
            {
                if (_patient != value)
                {
                    _patient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Visit", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Visit Visit
        {
            get { return _visit; }
            set 
            {
                if (_visit != value)
                {
                    _visit = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Visitmerge FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Visitmerge>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Visitquery : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private System.Collections.ObjectModel.ObservableCollection<object> _patientClasses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<object> _departments = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<object> _facilities = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<object> _visitStatuses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<PatientsItem2> _patients = new System.Collections.ObjectModel.ObservableCollection<PatientsItem2>();
        private System.Collections.ObjectModel.ObservableCollection<object> _visitNumbers = new System.Collections.ObjectModel.ObservableCollection<object>();
        private string _visitStartDateTime;
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PatientClasses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> PatientClasses
        {
            get { return _patientClasses; }
            set 
            {
                if (_patientClasses != value)
                {
                    _patientClasses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Departments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Departments
        {
            get { return _departments; }
            set 
            {
                if (_departments != value)
                {
                    _departments = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Facilities", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Facilities
        {
            get { return _facilities; }
            set 
            {
                if (_facilities != value)
                {
                    _facilities = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("VisitStatuses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> VisitStatuses
        {
            get { return _visitStatuses; }
            set 
            {
                if (_visitStatuses != value)
                {
                    _visitStatuses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patients", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<PatientsItem2> Patients
        {
            get { return _patients; }
            set 
            {
                if (_patients != value)
                {
                    _patients = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("VisitNumbers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> VisitNumbers
        {
            get { return _visitNumbers; }
            set 
            {
                if (_visitNumbers != value)
                {
                    _visitNumbers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("VisitStartDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisitStartDateTime
        {
            get { return _visitStartDateTime; }
            set 
            {
                if (_visitStartDateTime != value)
                {
                    _visitStartDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Visitquery FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Visitquery>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Visitqueryresponse : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private System.Collections.ObjectModel.ObservableCollection<PatientsItem3> _patients = new System.Collections.ObjectModel.ObservableCollection<PatientsItem3>();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patients", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<PatientsItem3> Patients
        {
            get { return _patients; }
            set 
            {
                if (_patients != value)
                {
                    _patients = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Visitqueryresponse FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Visitqueryresponse>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patientadmin_Visitupdate : System.ComponentModel.INotifyPropertyChanged
    {
        private Meta _meta = new Meta();
        private Patient _patient = new Patient();
        private Visit5 _visit = new Visit5();
    
        [Newtonsoft.Json.JsonProperty("Meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta
        {
            get { return _meta; }
            set 
            {
                if (_meta != value)
                {
                    _meta = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Patient", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Patient Patient
        {
            get { return _patient; }
            set 
            {
                if (_patient != value)
                {
                    _patient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Visit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Visit5 Visit
        {
            get { return _visit; }
            set 
            {
                if (_visit != value)
                {
                    _visit = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patientadmin_Visitupdate FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patientadmin_Visitupdate>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Meta2 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _dataModel;
        private string _eventType;
        private string _eventDateTime;
        private string _canceledEvent;
        private bool? _test;
        private Source _source = new Source();
        private System.Collections.ObjectModel.ObservableCollection<DestinationsItem> _destinations = new System.Collections.ObjectModel.ObservableCollection<DestinationsItem>();
        private Message _message = new Message();
        private Transmission _transmission = new Transmission();
        private string _facilityCode;
    
        [Newtonsoft.Json.JsonProperty("DataModel", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string DataModel
        {
            get { return _dataModel; }
            set 
            {
                if (_dataModel != value)
                {
                    _dataModel = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EventType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string EventType
        {
            get { return _eventType; }
            set 
            {
                if (_eventType != value)
                {
                    _eventType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EventDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EventDateTime
        {
            get { return _eventDateTime; }
            set 
            {
                if (_eventDateTime != value)
                {
                    _eventDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("CanceledEvent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CanceledEvent
        {
            get { return _canceledEvent; }
            set 
            {
                if (_canceledEvent != value)
                {
                    _canceledEvent = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Test", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Test
        {
            get { return _test; }
            set 
            {
                if (_test != value)
                {
                    _test = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Source", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Source Source
        {
            get { return _source; }
            set 
            {
                if (_source != value)
                {
                    _source = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Destinations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<DestinationsItem> Destinations
        {
            get { return _destinations; }
            set 
            {
                if (_destinations != value)
                {
                    _destinations = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Message Message
        {
            get { return _message; }
            set 
            {
                if (_message != value)
                {
                    _message = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Transmission", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Transmission Transmission
        {
            get { return _transmission; }
            set 
            {
                if (_transmission != value)
                {
                    _transmission = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FacilityCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FacilityCode
        {
            get { return _facilityCode; }
            set 
            {
                if (_facilityCode != value)
                {
                    _facilityCode = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Meta2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Meta2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patient2 : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> _identifiers = new System.Collections.ObjectModel.ObservableCollection<IdentifiersItem>();
        private Demographics _demographics = new Demographics();
        private System.Collections.ObjectModel.ObservableCollection<object> _notes = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<ContactsItem2> _contacts = new System.Collections.ObjectModel.ObservableCollection<ContactsItem2>();
        private System.Collections.ObjectModel.ObservableCollection<DiagnosesItem> _diagnoses = new System.Collections.ObjectModel.ObservableCollection<DiagnosesItem>();
        private System.Collections.ObjectModel.ObservableCollection<AllergiesItem2> _allergies = new System.Collections.ObjectModel.ObservableCollection<AllergiesItem2>();
        private PCP3 _pCP = new PCP3();
    
        [Newtonsoft.Json.JsonProperty("Identifiers", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> Identifiers
        {
            get { return _identifiers; }
            set 
            {
                if (_identifiers != value)
                {
                    _identifiers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Demographics", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Demographics Demographics
        {
            get { return _demographics; }
            set 
            {
                if (_demographics != value)
                {
                    _demographics = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Notes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Notes
        {
            get { return _notes; }
            set 
            {
                if (_notes != value)
                {
                    _notes = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Contacts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ContactsItem2> Contacts
        {
            get { return _contacts; }
            set 
            {
                if (_contacts != value)
                {
                    _contacts = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Diagnoses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<DiagnosesItem> Diagnoses
        {
            get { return _diagnoses; }
            set 
            {
                if (_diagnoses != value)
                {
                    _diagnoses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Allergies", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<AllergiesItem2> Allergies
        {
            get { return _allergies; }
            set 
            {
                if (_allergies != value)
                {
                    _allergies = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PCP", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PCP3 PCP
        {
            get { return _pCP; }
            set 
            {
                if (_pCP != value)
                {
                    _pCP = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patient2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patient2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Visit2 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _visitNumber;
        private string _accountNumber;
        private string _patientClass;
        private string _visitDateTime;
        private double? _duration;
        private string _reason;
        private System.Collections.ObjectModel.ObservableCollection<object> _instructions = new System.Collections.ObjectModel.ObservableCollection<object>();
        private double? _balance;
        private double? _diagnosisRelatedGroup;
        private double? _diagnosisRelatedGroupType;
        private AttendingProvider _attendingProvider = new AttendingProvider();
        private ConsultingProvider _consultingProvider = new ConsultingProvider();
        private ReferringProvider _referringProvider = new ReferringProvider();
        private AdmittingProvider _admittingProvider = new AdmittingProvider();
        private Location _location = new Location();
        private Guarantor2 _guarantor = new Guarantor2();
        private System.Collections.ObjectModel.ObservableCollection<InsurancesItem> _insurances = new System.Collections.ObjectModel.ObservableCollection<InsurancesItem>();
    
        [Newtonsoft.Json.JsonProperty("VisitNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisitNumber
        {
            get { return _visitNumber; }
            set 
            {
                if (_visitNumber != value)
                {
                    _visitNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AccountNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountNumber
        {
            get { return _accountNumber; }
            set 
            {
                if (_accountNumber != value)
                {
                    _accountNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PatientClass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PatientClass
        {
            get { return _patientClass; }
            set 
            {
                if (_patientClass != value)
                {
                    _patientClass = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("VisitDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisitDateTime
        {
            get { return _visitDateTime; }
            set 
            {
                if (_visitDateTime != value)
                {
                    _visitDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Duration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Duration
        {
            get { return _duration; }
            set 
            {
                if (_duration != value)
                {
                    _duration = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reason
        {
            get { return _reason; }
            set 
            {
                if (_reason != value)
                {
                    _reason = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Instructions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Instructions
        {
            get { return _instructions; }
            set 
            {
                if (_instructions != value)
                {
                    _instructions = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Balance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Balance
        {
            get { return _balance; }
            set 
            {
                if (_balance != value)
                {
                    _balance = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DiagnosisRelatedGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DiagnosisRelatedGroup
        {
            get { return _diagnosisRelatedGroup; }
            set 
            {
                if (_diagnosisRelatedGroup != value)
                {
                    _diagnosisRelatedGroup = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DiagnosisRelatedGroupType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DiagnosisRelatedGroupType
        {
            get { return _diagnosisRelatedGroupType; }
            set 
            {
                if (_diagnosisRelatedGroupType != value)
                {
                    _diagnosisRelatedGroupType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AttendingProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AttendingProvider AttendingProvider
        {
            get { return _attendingProvider; }
            set 
            {
                if (_attendingProvider != value)
                {
                    _attendingProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ConsultingProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ConsultingProvider ConsultingProvider
        {
            get { return _consultingProvider; }
            set 
            {
                if (_consultingProvider != value)
                {
                    _consultingProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ReferringProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ReferringProvider ReferringProvider
        {
            get { return _referringProvider; }
            set 
            {
                if (_referringProvider != value)
                {
                    _referringProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AdmittingProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AdmittingProvider AdmittingProvider
        {
            get { return _admittingProvider; }
            set 
            {
                if (_admittingProvider != value)
                {
                    _admittingProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location
        {
            get { return _location; }
            set 
            {
                if (_location != value)
                {
                    _location = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Guarantor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Guarantor2 Guarantor
        {
            get { return _guarantor; }
            set 
            {
                if (_guarantor != value)
                {
                    _guarantor = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Insurances", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<InsurancesItem> Insurances
        {
            get { return _insurances; }
            set 
            {
                if (_insurances != value)
                {
                    _insurances = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Visit2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Visit2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PatientsItem : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> _identifiers = new System.Collections.ObjectModel.ObservableCollection<IdentifiersItem>();
        private Demographics _demographics = new Demographics();
        private System.Collections.ObjectModel.ObservableCollection<VisitsItem> _visits = new System.Collections.ObjectModel.ObservableCollection<VisitsItem>();
    
        [Newtonsoft.Json.JsonProperty("Identifiers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> Identifiers
        {
            get { return _identifiers; }
            set 
            {
                if (_identifiers != value)
                {
                    _identifiers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Demographics", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Demographics Demographics
        {
            get { return _demographics; }
            set 
            {
                if (_demographics != value)
                {
                    _demographics = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Visits", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<VisitsItem> Visits
        {
            get { return _visits; }
            set 
            {
                if (_visits != value)
                {
                    _visits = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static PatientsItem FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PatientsItem>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Visit3 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _visitNumber;
        private string _accountNumber;
        private string _patientClass;
        private string _visitDateTime;
        private string _dischargeDateTime;
        private DischargeStatus _dischargeStatus = new DischargeStatus();
        private DischargeLocation _dischargeLocation = new DischargeLocation();
        private double? _duration;
        private string _reason;
        private System.Collections.ObjectModel.ObservableCollection<object> _instructions = new System.Collections.ObjectModel.ObservableCollection<object>();
        private double? _balance;
        private double? _diagnosisRelatedGroup;
        private double? _diagnosisRelatedGroupType;
        private AttendingProvider _attendingProvider = new AttendingProvider();
        private ConsultingProvider _consultingProvider = new ConsultingProvider();
        private ReferringProvider _referringProvider = new ReferringProvider();
        private AdmittingProvider _admittingProvider = new AdmittingProvider();
        private Location _location = new Location();
        private Guarantor _guarantor = new Guarantor();
        private System.Collections.ObjectModel.ObservableCollection<InsurancesItem2> _insurances = new System.Collections.ObjectModel.ObservableCollection<InsurancesItem2>();
    
        [Newtonsoft.Json.JsonProperty("VisitNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisitNumber
        {
            get { return _visitNumber; }
            set 
            {
                if (_visitNumber != value)
                {
                    _visitNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AccountNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountNumber
        {
            get { return _accountNumber; }
            set 
            {
                if (_accountNumber != value)
                {
                    _accountNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PatientClass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PatientClass
        {
            get { return _patientClass; }
            set 
            {
                if (_patientClass != value)
                {
                    _patientClass = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("VisitDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisitDateTime
        {
            get { return _visitDateTime; }
            set 
            {
                if (_visitDateTime != value)
                {
                    _visitDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DischargeDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DischargeDateTime
        {
            get { return _dischargeDateTime; }
            set 
            {
                if (_dischargeDateTime != value)
                {
                    _dischargeDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DischargeStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DischargeStatus DischargeStatus
        {
            get { return _dischargeStatus; }
            set 
            {
                if (_dischargeStatus != value)
                {
                    _dischargeStatus = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DischargeLocation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DischargeLocation DischargeLocation
        {
            get { return _dischargeLocation; }
            set 
            {
                if (_dischargeLocation != value)
                {
                    _dischargeLocation = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Duration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Duration
        {
            get { return _duration; }
            set 
            {
                if (_duration != value)
                {
                    _duration = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reason
        {
            get { return _reason; }
            set 
            {
                if (_reason != value)
                {
                    _reason = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Instructions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Instructions
        {
            get { return _instructions; }
            set 
            {
                if (_instructions != value)
                {
                    _instructions = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Balance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Balance
        {
            get { return _balance; }
            set 
            {
                if (_balance != value)
                {
                    _balance = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DiagnosisRelatedGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DiagnosisRelatedGroup
        {
            get { return _diagnosisRelatedGroup; }
            set 
            {
                if (_diagnosisRelatedGroup != value)
                {
                    _diagnosisRelatedGroup = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DiagnosisRelatedGroupType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DiagnosisRelatedGroupType
        {
            get { return _diagnosisRelatedGroupType; }
            set 
            {
                if (_diagnosisRelatedGroupType != value)
                {
                    _diagnosisRelatedGroupType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AttendingProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AttendingProvider AttendingProvider
        {
            get { return _attendingProvider; }
            set 
            {
                if (_attendingProvider != value)
                {
                    _attendingProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ConsultingProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ConsultingProvider ConsultingProvider
        {
            get { return _consultingProvider; }
            set 
            {
                if (_consultingProvider != value)
                {
                    _consultingProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ReferringProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ReferringProvider ReferringProvider
        {
            get { return _referringProvider; }
            set 
            {
                if (_referringProvider != value)
                {
                    _referringProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AdmittingProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AdmittingProvider AdmittingProvider
        {
            get { return _admittingProvider; }
            set 
            {
                if (_admittingProvider != value)
                {
                    _admittingProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location
        {
            get { return _location; }
            set 
            {
                if (_location != value)
                {
                    _location = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Guarantor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Guarantor Guarantor
        {
            get { return _guarantor; }
            set 
            {
                if (_guarantor != value)
                {
                    _guarantor = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Insurances", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<InsurancesItem2> Insurances
        {
            get { return _insurances; }
            set 
            {
                if (_insurances != value)
                {
                    _insurances = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Visit3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Visit3>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patient3 : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> _identifiers = new System.Collections.ObjectModel.ObservableCollection<IdentifiersItem>();
        private Demographics _demographics = new Demographics();
        private System.Collections.ObjectModel.ObservableCollection<object> _notes = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<ContactsItem3> _contacts = new System.Collections.ObjectModel.ObservableCollection<ContactsItem3>();
        private System.Collections.ObjectModel.ObservableCollection<AllergiesItem3> _allergies = new System.Collections.ObjectModel.ObservableCollection<AllergiesItem3>();
        private PCP _pCP = new PCP();
        private Guarantor _guarantor = new Guarantor();
        private System.Collections.ObjectModel.ObservableCollection<InsurancesItem3> _insurances = new System.Collections.ObjectModel.ObservableCollection<InsurancesItem3>();
    
        [Newtonsoft.Json.JsonProperty("Identifiers", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> Identifiers
        {
            get { return _identifiers; }
            set 
            {
                if (_identifiers != value)
                {
                    _identifiers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Demographics", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Demographics Demographics
        {
            get { return _demographics; }
            set 
            {
                if (_demographics != value)
                {
                    _demographics = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Notes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Notes
        {
            get { return _notes; }
            set 
            {
                if (_notes != value)
                {
                    _notes = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Contacts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ContactsItem3> Contacts
        {
            get { return _contacts; }
            set 
            {
                if (_contacts != value)
                {
                    _contacts = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Allergies", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<AllergiesItem3> Allergies
        {
            get { return _allergies; }
            set 
            {
                if (_allergies != value)
                {
                    _allergies = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PCP", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PCP PCP
        {
            get { return _pCP; }
            set 
            {
                if (_pCP != value)
                {
                    _pCP = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Guarantor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Guarantor Guarantor
        {
            get { return _guarantor; }
            set 
            {
                if (_guarantor != value)
                {
                    _guarantor = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Insurances", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<InsurancesItem3> Insurances
        {
            get { return _insurances; }
            set 
            {
                if (_insurances != value)
                {
                    _insurances = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patient3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patient3>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patient4 : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> _identifiers = new System.Collections.ObjectModel.ObservableCollection<IdentifiersItem>();
        private System.Collections.ObjectModel.ObservableCollection<PreviousIdentifiersItem> _previousIdentifiers = new System.Collections.ObjectModel.ObservableCollection<PreviousIdentifiersItem>();
        private Demographics _demographics = new Demographics();
        private System.Collections.ObjectModel.ObservableCollection<object> _notes = new System.Collections.ObjectModel.ObservableCollection<object>();
    
        [Newtonsoft.Json.JsonProperty("Identifiers", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> Identifiers
        {
            get { return _identifiers; }
            set 
            {
                if (_identifiers != value)
                {
                    _identifiers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PreviousIdentifiers", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<PreviousIdentifiersItem> PreviousIdentifiers
        {
            get { return _previousIdentifiers; }
            set 
            {
                if (_previousIdentifiers != value)
                {
                    _previousIdentifiers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Demographics", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Demographics Demographics
        {
            get { return _demographics; }
            set 
            {
                if (_demographics != value)
                {
                    _demographics = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Notes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Notes
        {
            get { return _notes; }
            set 
            {
                if (_notes != value)
                {
                    _notes = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patient4 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patient4>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patient5 : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> _identifiers = new System.Collections.ObjectModel.ObservableCollection<IdentifiersItem>();
        private Demographics _demographics = new Demographics();
        private System.Collections.ObjectModel.ObservableCollection<object> _notes = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<ContactsItem4> _contacts = new System.Collections.ObjectModel.ObservableCollection<ContactsItem4>();
        private System.Collections.ObjectModel.ObservableCollection<DiagnosesItem> _diagnoses = new System.Collections.ObjectModel.ObservableCollection<DiagnosesItem>();
        private System.Collections.ObjectModel.ObservableCollection<AllergiesItem4> _allergies = new System.Collections.ObjectModel.ObservableCollection<AllergiesItem4>();
        private PCP _pCP = new PCP();
        private System.Collections.ObjectModel.ObservableCollection<InsurancesItem4> _insurances = new System.Collections.ObjectModel.ObservableCollection<InsurancesItem4>();
        private Guarantor _guarantor = new Guarantor();
    
        [Newtonsoft.Json.JsonProperty("Identifiers", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> Identifiers
        {
            get { return _identifiers; }
            set 
            {
                if (_identifiers != value)
                {
                    _identifiers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Demographics", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Demographics Demographics
        {
            get { return _demographics; }
            set 
            {
                if (_demographics != value)
                {
                    _demographics = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Notes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Notes
        {
            get { return _notes; }
            set 
            {
                if (_notes != value)
                {
                    _notes = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Contacts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ContactsItem4> Contacts
        {
            get { return _contacts; }
            set 
            {
                if (_contacts != value)
                {
                    _contacts = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Diagnoses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<DiagnosesItem> Diagnoses
        {
            get { return _diagnoses; }
            set 
            {
                if (_diagnoses != value)
                {
                    _diagnoses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Allergies", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<AllergiesItem4> Allergies
        {
            get { return _allergies; }
            set 
            {
                if (_allergies != value)
                {
                    _allergies = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PCP", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PCP PCP
        {
            get { return _pCP; }
            set 
            {
                if (_pCP != value)
                {
                    _pCP = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Insurances", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<InsurancesItem4> Insurances
        {
            get { return _insurances; }
            set 
            {
                if (_insurances != value)
                {
                    _insurances = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Guarantor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Guarantor Guarantor
        {
            get { return _guarantor; }
            set 
            {
                if (_guarantor != value)
                {
                    _guarantor = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patient5 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patient5>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Visit4 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _visitNumber;
        private string _accountNumber;
        private string _patientClass;
        private string _visitDateTime;
        private string _dischargeDateTime;
        private DischargeStatus _dischargeStatus = new DischargeStatus();
        private double? _duration;
        private string _reason;
        private System.Collections.ObjectModel.ObservableCollection<object> _instructions = new System.Collections.ObjectModel.ObservableCollection<object>();
        private double? _balance;
        private double? _diagnosisRelatedGroup;
        private double? _diagnosisRelatedGroupType;
        private AttendingProvider _attendingProvider = new AttendingProvider();
        private ConsultingProvider _consultingProvider = new ConsultingProvider();
        private ReferringProvider _referringProvider = new ReferringProvider();
        private AdmittingProvider _admittingProvider = new AdmittingProvider();
        private Location _location = new Location();
        private PreviousLocation _previousLocation = new PreviousLocation();
        private Guarantor _guarantor = new Guarantor();
        private System.Collections.ObjectModel.ObservableCollection<InsurancesItem5> _insurances = new System.Collections.ObjectModel.ObservableCollection<InsurancesItem5>();
    
        [Newtonsoft.Json.JsonProperty("VisitNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisitNumber
        {
            get { return _visitNumber; }
            set 
            {
                if (_visitNumber != value)
                {
                    _visitNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AccountNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountNumber
        {
            get { return _accountNumber; }
            set 
            {
                if (_accountNumber != value)
                {
                    _accountNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PatientClass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PatientClass
        {
            get { return _patientClass; }
            set 
            {
                if (_patientClass != value)
                {
                    _patientClass = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("VisitDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisitDateTime
        {
            get { return _visitDateTime; }
            set 
            {
                if (_visitDateTime != value)
                {
                    _visitDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DischargeDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DischargeDateTime
        {
            get { return _dischargeDateTime; }
            set 
            {
                if (_dischargeDateTime != value)
                {
                    _dischargeDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DischargeStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DischargeStatus DischargeStatus
        {
            get { return _dischargeStatus; }
            set 
            {
                if (_dischargeStatus != value)
                {
                    _dischargeStatus = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Duration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Duration
        {
            get { return _duration; }
            set 
            {
                if (_duration != value)
                {
                    _duration = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reason
        {
            get { return _reason; }
            set 
            {
                if (_reason != value)
                {
                    _reason = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Instructions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Instructions
        {
            get { return _instructions; }
            set 
            {
                if (_instructions != value)
                {
                    _instructions = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Balance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Balance
        {
            get { return _balance; }
            set 
            {
                if (_balance != value)
                {
                    _balance = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DiagnosisRelatedGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DiagnosisRelatedGroup
        {
            get { return _diagnosisRelatedGroup; }
            set 
            {
                if (_diagnosisRelatedGroup != value)
                {
                    _diagnosisRelatedGroup = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DiagnosisRelatedGroupType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DiagnosisRelatedGroupType
        {
            get { return _diagnosisRelatedGroupType; }
            set 
            {
                if (_diagnosisRelatedGroupType != value)
                {
                    _diagnosisRelatedGroupType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AttendingProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AttendingProvider AttendingProvider
        {
            get { return _attendingProvider; }
            set 
            {
                if (_attendingProvider != value)
                {
                    _attendingProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ConsultingProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ConsultingProvider ConsultingProvider
        {
            get { return _consultingProvider; }
            set 
            {
                if (_consultingProvider != value)
                {
                    _consultingProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ReferringProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ReferringProvider ReferringProvider
        {
            get { return _referringProvider; }
            set 
            {
                if (_referringProvider != value)
                {
                    _referringProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AdmittingProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AdmittingProvider AdmittingProvider
        {
            get { return _admittingProvider; }
            set 
            {
                if (_admittingProvider != value)
                {
                    _admittingProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location
        {
            get { return _location; }
            set 
            {
                if (_location != value)
                {
                    _location = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PreviousLocation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PreviousLocation PreviousLocation
        {
            get { return _previousLocation; }
            set 
            {
                if (_previousLocation != value)
                {
                    _previousLocation = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Guarantor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Guarantor Guarantor
        {
            get { return _guarantor; }
            set 
            {
                if (_guarantor != value)
                {
                    _guarantor = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Insurances", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<InsurancesItem5> Insurances
        {
            get { return _insurances; }
            set 
            {
                if (_insurances != value)
                {
                    _insurances = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Visit4 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Visit4>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Patient6 : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> _identifiers = new System.Collections.ObjectModel.ObservableCollection<IdentifiersItem>();
        private System.Collections.ObjectModel.ObservableCollection<PreviousIdentifiersItem> _previousIdentifiers = new System.Collections.ObjectModel.ObservableCollection<PreviousIdentifiersItem>();
        private Demographics _demographics = new Demographics();
        private System.Collections.ObjectModel.ObservableCollection<object> _notes = new System.Collections.ObjectModel.ObservableCollection<object>();
    
        [Newtonsoft.Json.JsonProperty("Identifiers", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> Identifiers
        {
            get { return _identifiers; }
            set 
            {
                if (_identifiers != value)
                {
                    _identifiers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PreviousIdentifiers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<PreviousIdentifiersItem> PreviousIdentifiers
        {
            get { return _previousIdentifiers; }
            set 
            {
                if (_previousIdentifiers != value)
                {
                    _previousIdentifiers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Demographics", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Demographics Demographics
        {
            get { return _demographics; }
            set 
            {
                if (_demographics != value)
                {
                    _demographics = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Notes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Notes
        {
            get { return _notes; }
            set 
            {
                if (_notes != value)
                {
                    _notes = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Patient6 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patient6>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PatientsItem2 : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> _identifiers = new System.Collections.ObjectModel.ObservableCollection<IdentifiersItem>();
    
        [Newtonsoft.Json.JsonProperty("Identifiers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> Identifiers
        {
            get { return _identifiers; }
            set 
            {
                if (_identifiers != value)
                {
                    _identifiers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static PatientsItem2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PatientsItem2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PatientsItem3 : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> _identifiers = new System.Collections.ObjectModel.ObservableCollection<IdentifiersItem>();
        private Demographics _demographics = new Demographics();
        private System.Collections.ObjectModel.ObservableCollection<VisitsItem2> _visits = new System.Collections.ObjectModel.ObservableCollection<VisitsItem2>();
    
        [Newtonsoft.Json.JsonProperty("Identifiers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> Identifiers
        {
            get { return _identifiers; }
            set 
            {
                if (_identifiers != value)
                {
                    _identifiers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Demographics", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Demographics Demographics
        {
            get { return _demographics; }
            set 
            {
                if (_demographics != value)
                {
                    _demographics = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Visits", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<VisitsItem2> Visits
        {
            get { return _visits; }
            set 
            {
                if (_visits != value)
                {
                    _visits = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static PatientsItem3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PatientsItem3>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Visit5 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _visitNumber;
        private string _accountNumber;
        private string _patientClass;
        private string _visitDateTime;
        private string _dischargeDateTime;
        private double? _duration;
        private string _reason;
        private System.Collections.ObjectModel.ObservableCollection<object> _instructions = new System.Collections.ObjectModel.ObservableCollection<object>();
        private double? _balance;
        private double? _diagnosisRelatedGroup;
        private double? _diagnosisRelatedGroupType;
        private AttendingProvider _attendingProvider = new AttendingProvider();
        private ConsultingProvider _consultingProvider = new ConsultingProvider();
        private ReferringProvider _referringProvider = new ReferringProvider();
        private AdmittingProvider _admittingProvider = new AdmittingProvider();
        private Location _location = new Location();
        private Guarantor _guarantor = new Guarantor();
        private System.Collections.ObjectModel.ObservableCollection<InsurancesItem6> _insurances = new System.Collections.ObjectModel.ObservableCollection<InsurancesItem6>();
    
        [Newtonsoft.Json.JsonProperty("VisitNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisitNumber
        {
            get { return _visitNumber; }
            set 
            {
                if (_visitNumber != value)
                {
                    _visitNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AccountNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountNumber
        {
            get { return _accountNumber; }
            set 
            {
                if (_accountNumber != value)
                {
                    _accountNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PatientClass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PatientClass
        {
            get { return _patientClass; }
            set 
            {
                if (_patientClass != value)
                {
                    _patientClass = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("VisitDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisitDateTime
        {
            get { return _visitDateTime; }
            set 
            {
                if (_visitDateTime != value)
                {
                    _visitDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DischargeDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DischargeDateTime
        {
            get { return _dischargeDateTime; }
            set 
            {
                if (_dischargeDateTime != value)
                {
                    _dischargeDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Duration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Duration
        {
            get { return _duration; }
            set 
            {
                if (_duration != value)
                {
                    _duration = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reason
        {
            get { return _reason; }
            set 
            {
                if (_reason != value)
                {
                    _reason = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Instructions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Instructions
        {
            get { return _instructions; }
            set 
            {
                if (_instructions != value)
                {
                    _instructions = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Balance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Balance
        {
            get { return _balance; }
            set 
            {
                if (_balance != value)
                {
                    _balance = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DiagnosisRelatedGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DiagnosisRelatedGroup
        {
            get { return _diagnosisRelatedGroup; }
            set 
            {
                if (_diagnosisRelatedGroup != value)
                {
                    _diagnosisRelatedGroup = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DiagnosisRelatedGroupType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DiagnosisRelatedGroupType
        {
            get { return _diagnosisRelatedGroupType; }
            set 
            {
                if (_diagnosisRelatedGroupType != value)
                {
                    _diagnosisRelatedGroupType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AttendingProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AttendingProvider AttendingProvider
        {
            get { return _attendingProvider; }
            set 
            {
                if (_attendingProvider != value)
                {
                    _attendingProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ConsultingProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ConsultingProvider ConsultingProvider
        {
            get { return _consultingProvider; }
            set 
            {
                if (_consultingProvider != value)
                {
                    _consultingProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ReferringProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ReferringProvider ReferringProvider
        {
            get { return _referringProvider; }
            set 
            {
                if (_referringProvider != value)
                {
                    _referringProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AdmittingProvider", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AdmittingProvider AdmittingProvider
        {
            get { return _admittingProvider; }
            set 
            {
                if (_admittingProvider != value)
                {
                    _admittingProvider = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location
        {
            get { return _location; }
            set 
            {
                if (_location != value)
                {
                    _location = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Guarantor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Guarantor Guarantor
        {
            get { return _guarantor; }
            set 
            {
                if (_guarantor != value)
                {
                    _guarantor = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Insurances", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<InsurancesItem6> Insurances
        {
            get { return _insurances; }
            set 
            {
                if (_insurances != value)
                {
                    _insurances = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Visit5 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Visit5>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ContactsItem2 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private Address _address = new Address();
        private PhoneNumber _phoneNumber = new PhoneNumber();
        private string _relationToPatient;
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<object> _roles = new System.Collections.ObjectModel.ObservableCollection<object>();
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiddleName
        {
            get { return _middleName; }
            set 
            {
                if (_middleName != value)
                {
                    _middleName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("RelationToPatient", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RelationToPatient
        {
            get { return _relationToPatient; }
            set 
            {
                if (_relationToPatient != value)
                {
                    _relationToPatient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Roles", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Roles
        {
            get { return _roles; }
            set 
            {
                if (_roles != value)
                {
                    _roles = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static ContactsItem2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ContactsItem2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AllergiesItem2 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _code;
        private string _codeset;
        private string _name;
        private Type _type = new Type();
        private string _onsetDateTime;
        private System.Collections.ObjectModel.ObservableCollection<ReactionItem> _reaction = new System.Collections.ObjectModel.ObservableCollection<ReactionItem>();
        private Severity _severity = new Severity();
        private string _status;
    
        [Newtonsoft.Json.JsonProperty("Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code
        {
            get { return _code; }
            set 
            {
                if (_code != value)
                {
                    _code = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Codeset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Codeset
        {
            get { return _codeset; }
            set 
            {
                if (_codeset != value)
                {
                    _codeset = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Type Type
        {
            get { return _type; }
            set 
            {
                if (_type != value)
                {
                    _type = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("OnsetDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OnsetDateTime
        {
            get { return _onsetDateTime; }
            set 
            {
                if (_onsetDateTime != value)
                {
                    _onsetDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Reaction", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ReactionItem> Reaction
        {
            get { return _reaction; }
            set 
            {
                if (_reaction != value)
                {
                    _reaction = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Severity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Severity Severity
        {
            get { return _severity; }
            set 
            {
                if (_severity != value)
                {
                    _severity = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status
        {
            get { return _status; }
            set 
            {
                if (_status != value)
                {
                    _status = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static AllergiesItem2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AllergiesItem2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PCP3 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _nPI;
        private string _iD;
        private string _iDType;
        private string _firstName;
        private string _lastName;
        private System.Collections.ObjectModel.ObservableCollection<object> _credentials = new System.Collections.ObjectModel.ObservableCollection<object>();
        private Address _address = new Address();
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private PhoneNumber _phoneNumber = new PhoneNumber();
        private Location _location = new Location();
    
        [Newtonsoft.Json.JsonProperty("NPI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NPI
        {
            get { return _nPI; }
            set 
            {
                if (_nPI != value)
                {
                    _nPI = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ID
        {
            get { return _iD; }
            set 
            {
                if (_iD != value)
                {
                    _iD = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("IDType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IDType
        {
            get { return _iDType; }
            set 
            {
                if (_iDType != value)
                {
                    _iDType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Credentials", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Credentials
        {
            get { return _credentials; }
            set 
            {
                if (_credentials != value)
                {
                    _credentials = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location
        {
            get { return _location; }
            set 
            {
                if (_location != value)
                {
                    _location = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static PCP3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PCP3>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Guarantor2 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _number;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _sSN;
        private string _dOB;
        private string _sex;
        private Spouse _spouse = new Spouse();
        private Address _address = new Address();
        private PhoneNumber _phoneNumber = new PhoneNumber();
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private string _type;
        private string _relationToPatient;
        private Employer _employer = new Employer();
    
        [Newtonsoft.Json.JsonProperty("Number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Number
        {
            get { return _number; }
            set 
            {
                if (_number != value)
                {
                    _number = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiddleName
        {
            get { return _middleName; }
            set 
            {
                if (_middleName != value)
                {
                    _middleName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("SSN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SSN
        {
            get { return _sSN; }
            set 
            {
                if (_sSN != value)
                {
                    _sSN = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DOB", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DOB
        {
            get { return _dOB; }
            set 
            {
                if (_dOB != value)
                {
                    _dOB = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Sex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Sex
        {
            get { return _sex; }
            set 
            {
                if (_sex != value)
                {
                    _sex = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Spouse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Spouse Spouse
        {
            get { return _spouse; }
            set 
            {
                if (_spouse != value)
                {
                    _spouse = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type
        {
            get { return _type; }
            set 
            {
                if (_type != value)
                {
                    _type = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("RelationToPatient", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RelationToPatient
        {
            get { return _relationToPatient; }
            set 
            {
                if (_relationToPatient != value)
                {
                    _relationToPatient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Employer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Employer Employer
        {
            get { return _employer; }
            set 
            {
                if (_employer != value)
                {
                    _employer = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Guarantor2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Guarantor2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InsurancesItem : System.ComponentModel.INotifyPropertyChanged
    {
        private Plan _plan = new Plan();
        private string _memberNumber;
        private Company _company = new Company();
        private string _groupNumber;
        private string _groupName;
        private string _effectiveDate;
        private string _expirationDate;
        private string _policyNumber;
        private string _agreementType;
        private string _coverageType;
        private Insured2 _insured = new Insured2();
    
        [Newtonsoft.Json.JsonProperty("Plan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Plan Plan
        {
            get { return _plan; }
            set 
            {
                if (_plan != value)
                {
                    _plan = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MemberNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MemberNumber
        {
            get { return _memberNumber; }
            set 
            {
                if (_memberNumber != value)
                {
                    _memberNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Company", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Company Company
        {
            get { return _company; }
            set 
            {
                if (_company != value)
                {
                    _company = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("GroupNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupNumber
        {
            get { return _groupNumber; }
            set 
            {
                if (_groupNumber != value)
                {
                    _groupNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("GroupName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupName
        {
            get { return _groupName; }
            set 
            {
                if (_groupName != value)
                {
                    _groupName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EffectiveDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EffectiveDate
        {
            get { return _effectiveDate; }
            set 
            {
                if (_effectiveDate != value)
                {
                    _effectiveDate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ExpirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExpirationDate
        {
            get { return _expirationDate; }
            set 
            {
                if (_expirationDate != value)
                {
                    _expirationDate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PolicyNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PolicyNumber
        {
            get { return _policyNumber; }
            set 
            {
                if (_policyNumber != value)
                {
                    _policyNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AgreementType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AgreementType
        {
            get { return _agreementType; }
            set 
            {
                if (_agreementType != value)
                {
                    _agreementType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("CoverageType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoverageType
        {
            get { return _coverageType; }
            set 
            {
                if (_coverageType != value)
                {
                    _coverageType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Insured", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Insured2 Insured
        {
            get { return _insured; }
            set 
            {
                if (_insured != value)
                {
                    _insured = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static InsurancesItem FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InsurancesItem>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class VisitsItem : System.ComponentModel.INotifyPropertyChanged
    {
        private string _visitNumber;
        private string _visitDateTime;
        private string _patientClass;
        private Location_1 _location = new Location_1();
    
        [Newtonsoft.Json.JsonProperty("VisitNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisitNumber
        {
            get { return _visitNumber; }
            set 
            {
                if (_visitNumber != value)
                {
                    _visitNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("VisitDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisitDateTime
        {
            get { return _visitDateTime; }
            set 
            {
                if (_visitDateTime != value)
                {
                    _visitDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PatientClass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PatientClass
        {
            get { return _patientClass; }
            set 
            {
                if (_patientClass != value)
                {
                    _patientClass = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location_1 Location
        {
            get { return _location; }
            set 
            {
                if (_location != value)
                {
                    _location = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static VisitsItem FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<VisitsItem>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InsurancesItem2 : System.ComponentModel.INotifyPropertyChanged
    {
        private Plan _plan = new Plan();
        private string _memberNumber;
        private Company _company = new Company();
        private string _groupNumber;
        private string _groupName;
        private string _effectiveDate;
        private string _expirationDate;
        private string _policyNumber;
        private string _agreementType;
        private string _coverageType;
        private Insured _insured = new Insured();
    
        [Newtonsoft.Json.JsonProperty("Plan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Plan Plan
        {
            get { return _plan; }
            set 
            {
                if (_plan != value)
                {
                    _plan = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MemberNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MemberNumber
        {
            get { return _memberNumber; }
            set 
            {
                if (_memberNumber != value)
                {
                    _memberNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Company", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Company Company
        {
            get { return _company; }
            set 
            {
                if (_company != value)
                {
                    _company = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("GroupNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupNumber
        {
            get { return _groupNumber; }
            set 
            {
                if (_groupNumber != value)
                {
                    _groupNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("GroupName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupName
        {
            get { return _groupName; }
            set 
            {
                if (_groupName != value)
                {
                    _groupName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EffectiveDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EffectiveDate
        {
            get { return _effectiveDate; }
            set 
            {
                if (_effectiveDate != value)
                {
                    _effectiveDate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ExpirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExpirationDate
        {
            get { return _expirationDate; }
            set 
            {
                if (_expirationDate != value)
                {
                    _expirationDate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PolicyNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PolicyNumber
        {
            get { return _policyNumber; }
            set 
            {
                if (_policyNumber != value)
                {
                    _policyNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AgreementType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AgreementType
        {
            get { return _agreementType; }
            set 
            {
                if (_agreementType != value)
                {
                    _agreementType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("CoverageType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoverageType
        {
            get { return _coverageType; }
            set 
            {
                if (_coverageType != value)
                {
                    _coverageType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Insured", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Insured Insured
        {
            get { return _insured; }
            set 
            {
                if (_insured != value)
                {
                    _insured = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static InsurancesItem2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InsurancesItem2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ContactsItem3 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private Address _address = new Address();
        private PhoneNumber _phoneNumber = new PhoneNumber();
        private string _relationToPatient;
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<object> _roles = new System.Collections.ObjectModel.ObservableCollection<object>();
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiddleName
        {
            get { return _middleName; }
            set 
            {
                if (_middleName != value)
                {
                    _middleName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("RelationToPatient", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RelationToPatient
        {
            get { return _relationToPatient; }
            set 
            {
                if (_relationToPatient != value)
                {
                    _relationToPatient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Roles", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Roles
        {
            get { return _roles; }
            set 
            {
                if (_roles != value)
                {
                    _roles = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static ContactsItem3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ContactsItem3>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AllergiesItem3 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _code;
        private string _codeset;
        private string _name;
        private Type _type = new Type();
        private string _onsetDateTime;
        private System.Collections.ObjectModel.ObservableCollection<ReactionItem> _reaction = new System.Collections.ObjectModel.ObservableCollection<ReactionItem>();
        private Severity _severity = new Severity();
        private string _status;
    
        [Newtonsoft.Json.JsonProperty("Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code
        {
            get { return _code; }
            set 
            {
                if (_code != value)
                {
                    _code = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Codeset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Codeset
        {
            get { return _codeset; }
            set 
            {
                if (_codeset != value)
                {
                    _codeset = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Type Type
        {
            get { return _type; }
            set 
            {
                if (_type != value)
                {
                    _type = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("OnsetDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OnsetDateTime
        {
            get { return _onsetDateTime; }
            set 
            {
                if (_onsetDateTime != value)
                {
                    _onsetDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Reaction", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ReactionItem> Reaction
        {
            get { return _reaction; }
            set 
            {
                if (_reaction != value)
                {
                    _reaction = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Severity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Severity Severity
        {
            get { return _severity; }
            set 
            {
                if (_severity != value)
                {
                    _severity = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status
        {
            get { return _status; }
            set 
            {
                if (_status != value)
                {
                    _status = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static AllergiesItem3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AllergiesItem3>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InsurancesItem3 : System.ComponentModel.INotifyPropertyChanged
    {
        private Plan _plan = new Plan();
        private string _memberNumber;
        private Company _company = new Company();
        private string _groupNumber;
        private string _groupName;
        private string _effectiveDate;
        private string _expirationDate;
        private string _policyNumber;
        private string _agreementType;
        private string _coverageType;
        private Insured _insured = new Insured();
    
        [Newtonsoft.Json.JsonProperty("Plan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Plan Plan
        {
            get { return _plan; }
            set 
            {
                if (_plan != value)
                {
                    _plan = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MemberNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MemberNumber
        {
            get { return _memberNumber; }
            set 
            {
                if (_memberNumber != value)
                {
                    _memberNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Company", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Company Company
        {
            get { return _company; }
            set 
            {
                if (_company != value)
                {
                    _company = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("GroupNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupNumber
        {
            get { return _groupNumber; }
            set 
            {
                if (_groupNumber != value)
                {
                    _groupNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("GroupName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupName
        {
            get { return _groupName; }
            set 
            {
                if (_groupName != value)
                {
                    _groupName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EffectiveDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EffectiveDate
        {
            get { return _effectiveDate; }
            set 
            {
                if (_effectiveDate != value)
                {
                    _effectiveDate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ExpirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExpirationDate
        {
            get { return _expirationDate; }
            set 
            {
                if (_expirationDate != value)
                {
                    _expirationDate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PolicyNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PolicyNumber
        {
            get { return _policyNumber; }
            set 
            {
                if (_policyNumber != value)
                {
                    _policyNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AgreementType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AgreementType
        {
            get { return _agreementType; }
            set 
            {
                if (_agreementType != value)
                {
                    _agreementType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("CoverageType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoverageType
        {
            get { return _coverageType; }
            set 
            {
                if (_coverageType != value)
                {
                    _coverageType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Insured", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Insured Insured
        {
            get { return _insured; }
            set 
            {
                if (_insured != value)
                {
                    _insured = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static InsurancesItem3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InsurancesItem3>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ContactsItem4 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private Address _address = new Address();
        private PhoneNumber _phoneNumber = new PhoneNumber();
        private string _relationToPatient;
        private System.Collections.ObjectModel.ObservableCollection<object> _emailAddresses = new System.Collections.ObjectModel.ObservableCollection<object>();
        private System.Collections.ObjectModel.ObservableCollection<object> _roles = new System.Collections.ObjectModel.ObservableCollection<object>();
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiddleName
        {
            get { return _middleName; }
            set 
            {
                if (_middleName != value)
                {
                    _middleName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("RelationToPatient", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RelationToPatient
        {
            get { return _relationToPatient; }
            set 
            {
                if (_relationToPatient != value)
                {
                    _relationToPatient = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EmailAddresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> EmailAddresses
        {
            get { return _emailAddresses; }
            set 
            {
                if (_emailAddresses != value)
                {
                    _emailAddresses = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Roles", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<object> Roles
        {
            get { return _roles; }
            set 
            {
                if (_roles != value)
                {
                    _roles = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static ContactsItem4 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ContactsItem4>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AllergiesItem4 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _code;
        private string _codeset;
        private string _name;
        private Type _type = new Type();
        private string _onsetDateTime;
        private System.Collections.ObjectModel.ObservableCollection<ReactionItem> _reaction = new System.Collections.ObjectModel.ObservableCollection<ReactionItem>();
        private Severity _severity = new Severity();
        private string _status;
    
        [Newtonsoft.Json.JsonProperty("Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code
        {
            get { return _code; }
            set 
            {
                if (_code != value)
                {
                    _code = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Codeset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Codeset
        {
            get { return _codeset; }
            set 
            {
                if (_codeset != value)
                {
                    _codeset = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name != value)
                {
                    _name = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Type Type
        {
            get { return _type; }
            set 
            {
                if (_type != value)
                {
                    _type = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("OnsetDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OnsetDateTime
        {
            get { return _onsetDateTime; }
            set 
            {
                if (_onsetDateTime != value)
                {
                    _onsetDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Reaction", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ReactionItem> Reaction
        {
            get { return _reaction; }
            set 
            {
                if (_reaction != value)
                {
                    _reaction = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Severity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Severity Severity
        {
            get { return _severity; }
            set 
            {
                if (_severity != value)
                {
                    _severity = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status
        {
            get { return _status; }
            set 
            {
                if (_status != value)
                {
                    _status = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static AllergiesItem4 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AllergiesItem4>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InsurancesItem4 : System.ComponentModel.INotifyPropertyChanged
    {
        private Plan _plan = new Plan();
        private string _memberNumber;
        private Company _company = new Company();
        private string _groupNumber;
        private string _groupName;
        private string _effectiveDate;
        private string _expirationDate;
        private string _policyNumber;
        private string _agreementType;
        private string _coverageType;
        private Insured _insured = new Insured();
    
        [Newtonsoft.Json.JsonProperty("Plan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Plan Plan
        {
            get { return _plan; }
            set 
            {
                if (_plan != value)
                {
                    _plan = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MemberNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MemberNumber
        {
            get { return _memberNumber; }
            set 
            {
                if (_memberNumber != value)
                {
                    _memberNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Company", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Company Company
        {
            get { return _company; }
            set 
            {
                if (_company != value)
                {
                    _company = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("GroupNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupNumber
        {
            get { return _groupNumber; }
            set 
            {
                if (_groupNumber != value)
                {
                    _groupNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("GroupName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupName
        {
            get { return _groupName; }
            set 
            {
                if (_groupName != value)
                {
                    _groupName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EffectiveDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EffectiveDate
        {
            get { return _effectiveDate; }
            set 
            {
                if (_effectiveDate != value)
                {
                    _effectiveDate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ExpirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExpirationDate
        {
            get { return _expirationDate; }
            set 
            {
                if (_expirationDate != value)
                {
                    _expirationDate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PolicyNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PolicyNumber
        {
            get { return _policyNumber; }
            set 
            {
                if (_policyNumber != value)
                {
                    _policyNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AgreementType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AgreementType
        {
            get { return _agreementType; }
            set 
            {
                if (_agreementType != value)
                {
                    _agreementType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("CoverageType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoverageType
        {
            get { return _coverageType; }
            set 
            {
                if (_coverageType != value)
                {
                    _coverageType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Insured", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Insured Insured
        {
            get { return _insured; }
            set 
            {
                if (_insured != value)
                {
                    _insured = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static InsurancesItem4 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InsurancesItem4>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PreviousLocation : System.ComponentModel.INotifyPropertyChanged
    {
        private string _type;
        private string _facility;
        private string _department;
        private string _room;
        private string _bed;
        private Address _address = new Address();
    
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type
        {
            get { return _type; }
            set 
            {
                if (_type != value)
                {
                    _type = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Facility", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Facility
        {
            get { return _facility; }
            set 
            {
                if (_facility != value)
                {
                    _facility = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Department", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Department
        {
            get { return _department; }
            set 
            {
                if (_department != value)
                {
                    _department = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Room", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Room
        {
            get { return _room; }
            set 
            {
                if (_room != value)
                {
                    _room = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Bed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bed
        {
            get { return _bed; }
            set 
            {
                if (_bed != value)
                {
                    _bed = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static PreviousLocation FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PreviousLocation>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InsurancesItem5 : System.ComponentModel.INotifyPropertyChanged
    {
        private Plan _plan = new Plan();
        private string _memberNumber;
        private Company _company = new Company();
        private string _groupNumber;
        private string _groupName;
        private string _effectiveDate;
        private string _expirationDate;
        private string _policyNumber;
        private string _agreementType;
        private string _coverageType;
        private Insured _insured = new Insured();
    
        [Newtonsoft.Json.JsonProperty("Plan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Plan Plan
        {
            get { return _plan; }
            set 
            {
                if (_plan != value)
                {
                    _plan = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MemberNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MemberNumber
        {
            get { return _memberNumber; }
            set 
            {
                if (_memberNumber != value)
                {
                    _memberNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Company", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Company Company
        {
            get { return _company; }
            set 
            {
                if (_company != value)
                {
                    _company = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("GroupNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupNumber
        {
            get { return _groupNumber; }
            set 
            {
                if (_groupNumber != value)
                {
                    _groupNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("GroupName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupName
        {
            get { return _groupName; }
            set 
            {
                if (_groupName != value)
                {
                    _groupName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EffectiveDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EffectiveDate
        {
            get { return _effectiveDate; }
            set 
            {
                if (_effectiveDate != value)
                {
                    _effectiveDate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ExpirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExpirationDate
        {
            get { return _expirationDate; }
            set 
            {
                if (_expirationDate != value)
                {
                    _expirationDate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PolicyNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PolicyNumber
        {
            get { return _policyNumber; }
            set 
            {
                if (_policyNumber != value)
                {
                    _policyNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AgreementType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AgreementType
        {
            get { return _agreementType; }
            set 
            {
                if (_agreementType != value)
                {
                    _agreementType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("CoverageType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoverageType
        {
            get { return _coverageType; }
            set 
            {
                if (_coverageType != value)
                {
                    _coverageType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Insured", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Insured Insured
        {
            get { return _insured; }
            set 
            {
                if (_insured != value)
                {
                    _insured = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static InsurancesItem5 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InsurancesItem5>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class VisitsItem2 : System.ComponentModel.INotifyPropertyChanged
    {
        private string _visitNumber;
        private string _visitDateTime;
        private string _patientClass;
        private Location _location = new Location();
        private string _reason;
        private string _status;
    
        [Newtonsoft.Json.JsonProperty("VisitNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisitNumber
        {
            get { return _visitNumber; }
            set 
            {
                if (_visitNumber != value)
                {
                    _visitNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("VisitDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisitDateTime
        {
            get { return _visitDateTime; }
            set 
            {
                if (_visitDateTime != value)
                {
                    _visitDateTime = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PatientClass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PatientClass
        {
            get { return _patientClass; }
            set 
            {
                if (_patientClass != value)
                {
                    _patientClass = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location
        {
            get { return _location; }
            set 
            {
                if (_location != value)
                {
                    _location = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reason
        {
            get { return _reason; }
            set 
            {
                if (_reason != value)
                {
                    _reason = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status
        {
            get { return _status; }
            set 
            {
                if (_status != value)
                {
                    _status = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static VisitsItem2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<VisitsItem2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InsurancesItem6 : System.ComponentModel.INotifyPropertyChanged
    {
        private Plan _plan = new Plan();
        private string _memberNumber;
        private Company _company = new Company();
        private string _groupNumber;
        private string _groupName;
        private string _effectiveDate;
        private string _expirationDate;
        private string _policyNumber;
        private string _agreementType;
        private string _coverageType;
        private Insured _insured = new Insured();
    
        [Newtonsoft.Json.JsonProperty("Plan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Plan Plan
        {
            get { return _plan; }
            set 
            {
                if (_plan != value)
                {
                    _plan = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MemberNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MemberNumber
        {
            get { return _memberNumber; }
            set 
            {
                if (_memberNumber != value)
                {
                    _memberNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Company", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Company Company
        {
            get { return _company; }
            set 
            {
                if (_company != value)
                {
                    _company = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("GroupNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupNumber
        {
            get { return _groupNumber; }
            set 
            {
                if (_groupNumber != value)
                {
                    _groupNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("GroupName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupName
        {
            get { return _groupName; }
            set 
            {
                if (_groupName != value)
                {
                    _groupName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("EffectiveDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EffectiveDate
        {
            get { return _effectiveDate; }
            set 
            {
                if (_effectiveDate != value)
                {
                    _effectiveDate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("ExpirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExpirationDate
        {
            get { return _expirationDate; }
            set 
            {
                if (_expirationDate != value)
                {
                    _expirationDate = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("PolicyNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PolicyNumber
        {
            get { return _policyNumber; }
            set 
            {
                if (_policyNumber != value)
                {
                    _policyNumber = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("AgreementType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AgreementType
        {
            get { return _agreementType; }
            set 
            {
                if (_agreementType != value)
                {
                    _agreementType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("CoverageType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoverageType
        {
            get { return _coverageType; }
            set 
            {
                if (_coverageType != value)
                {
                    _coverageType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Insured", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Insured Insured
        {
            get { return _insured; }
            set 
            {
                if (_insured != value)
                {
                    _insured = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static InsurancesItem6 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InsurancesItem6>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Insured2 : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> _identifiers = new System.Collections.ObjectModel.ObservableCollection<IdentifiersItem>();
        private string _lastName;
        private string _middleName;
        private string _firstName;
        private string _sSN;
        private string _relationship;
        private string _dOB;
        private string _sex;
        private Address _address = new Address();
    
        [Newtonsoft.Json.JsonProperty("Identifiers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<IdentifiersItem> Identifiers
        {
            get { return _identifiers; }
            set 
            {
                if (_identifiers != value)
                {
                    _identifiers = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (_lastName != value)
                {
                    _lastName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiddleName
        {
            get { return _middleName; }
            set 
            {
                if (_middleName != value)
                {
                    _middleName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("SSN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SSN
        {
            get { return _sSN; }
            set 
            {
                if (_sSN != value)
                {
                    _sSN = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Relationship", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Relationship
        {
            get { return _relationship; }
            set 
            {
                if (_relationship != value)
                {
                    _relationship = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("DOB", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DOB
        {
            get { return _dOB; }
            set 
            {
                if (_dOB != value)
                {
                    _dOB = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Sex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Sex
        {
            get { return _sex; }
            set 
            {
                if (_sex != value)
                {
                    _sex = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set 
            {
                if (_address != value)
                {
                    _address = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Insured2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Insured2>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
}