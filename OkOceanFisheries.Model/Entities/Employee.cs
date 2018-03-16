using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkOceanFisheries.Model.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }

        [Column(TypeName = "Money")]
        public decimal? HourlyWage { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
