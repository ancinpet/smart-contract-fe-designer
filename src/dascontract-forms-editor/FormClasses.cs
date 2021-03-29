using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;
using System;
using System.ComponentModel;

namespace dascontract_forms_editor {
    [XmlRootAttribute("Form")]
    public class Form {
        public string Name { get; set; } = "";

        [XmlElement("FieldGroup")]
        public List<FieldGroup> FieldGroups { get; set; } = new List<FieldGroup>();
    }

    public class FieldGroup {
        public string Id { get; set; }
        public string Label { get; set; } = "";
        public bool Vertical { get; set; } = true;
        public bool Displayed { get; set; } = true;

        [XmlElement("DateField", typeof(DateField))]
        [XmlElement("AddressField", typeof(AddressField))]
        [XmlElement("SingleLineField", typeof(SingleLineField))]
        [XmlElement("MultiLineField", typeof(MultiLineField))]
        [XmlElement("IntField", typeof(IntField))]
        [XmlElement("DecimalField", typeof(DecimalField))]
        [XmlElement("BoolField", typeof(BoolField))]
        [XmlElement("EnumField", typeof(EnumField))]
        [XmlElement("DropdownField", typeof(DropdownField))]
        public List<Field> Fields { get; set; } = new List<Field>();
    }

    public class Field {
        public string Id { get; set; }
        public string Name { get; set; } = "";
        public string Label { get; set; }
        public string Description { get; set; } = "";
        public bool ReadOnly { get; set; } = false;
    }

    public class DateField : Field {
        public DateTime Data { get; set; }
    }

    public class AddressField : Field {
        public string Data { get; set; }
    }

    public class SingleLineField : Field {
        public string Data { get; set; }
    }

    public class MultiLineField : Field {
        public string Data { get; set; }
    }

    public class IntField : Field {
        public long Data { get; set; }
    }

    public class DecimalField : Field {
        public decimal Data { get; set; }
    }

    public class BoolField : Field {
        public bool Data { get; set; }
    }

    public class EnumField : Field {
        [XmlElement("Data")]
        public List<string> Data { get; set; } = new List<string>();
    }

    public class DropdownField : Field {
        [XmlElement("Data")]
        public List<string> Data { get; set; } = new List<string>();
    }
}
