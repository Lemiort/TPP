using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharePointProject2.Model
{
    [Table("Equipment", Schema = "TechProcProd")]
    public class Equipment
    {
        public Equipment()
        {
            Operations = new List<Operation>();
        }
        public int EquipmentId { get; set; }

        public int DetailNumber { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Department { get; set; }

        public ICollection<Operation> Operations { get; set; }  

    }
}
