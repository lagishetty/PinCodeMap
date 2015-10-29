using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PincodeMap
{
    class Class1
    {

public class Pincode
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class OfficeType
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class Deliverystatus
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class Divisionname
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class Regionname
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class Circlename
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class Taluk
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class Districtname
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class Statename
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class Telephone
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class RelatedSuboffice
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class RelatedHeadoffice
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class Longitude
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class Latitude
{
    public string type { get; set; }
    public string size { get; set; }
    public string length { get; set; }
    public bool __invalid_name__not_null { get; set; }
    public string description { get; set; }
}

public class Fields
{
    
    public Pincode pincode { get; set; }
    public OfficeType officeType { get; set; }
    public Deliverystatus Deliverystatus { get; set; }
    public Divisionname divisionname { get; set; }
    public Regionname regionname { get; set; }
    public Circlename circlename { get; set; }
    public Taluk Taluk { get; set; }
    public Districtname Districtname { get; set; }
    public Statename statename { get; set; }
    public Telephone Telephone { get; set; }
    public RelatedSuboffice __invalid_name__Related_Suboffice { get; set; }
    public RelatedHeadoffice __invalid_name__Related_Headoffice { get; set; }
    public Longitude longitude { get; set; }
    public Latitude latitude { get; set; }
}

public class Record
{
    
    public string pincode { get; set; }
    public string officeType { get; set; }
    public string Deliverystatus { get; set; }
    public string divisionname { get; set; }
    public string regionname { get; set; }
    public string circlename { get; set; }
    public string Taluk { get; set; }
    public string Districtname { get; set; }
    public string statename { get; set; }
    public string Telephone { get; set; }
    public string __invalid_name__Related_Suboffice { get; set; }
    public string __invalid_name__Related_Headoffice { get; set; }
    public string longitude { get; set; }
    public string latitude { get; set; }
}

public class RootObject
{
    public string help { get; set; }
    public bool success { get; set; }
    public int count { get; set; }
    public Fields fields { get; set; }
    public List<Record> records { get; set; }
}


    }
}
