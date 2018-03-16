namespace OkOceanFisheries.Model.Entities
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}