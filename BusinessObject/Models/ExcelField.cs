using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class ExcelField
    {
        public ExcelField()
        {
            Fields = new HashSet<Field>();
        }

        public int Id { get; set; }
        public string FieldName { get; set; }

        public virtual ICollection<Field> Fields { get; set; }
    }
}
