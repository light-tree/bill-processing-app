using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class Field
    {
        public int Id { get; set; }
        public int? AccountingSoftwareId { get; set; }
        public int? ExcelFiledId { get; set; }
        public string FieldName { get; set; }

        public virtual AccountingSoftware AccountingSoftware { get; set; }
        public virtual ExcelField ExcelFiled { get; set; }
    }
}
