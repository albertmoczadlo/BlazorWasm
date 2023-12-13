namespace BlazorWasm.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public bool IsNew { get; set; }
        public decimal Salary { get; set; }
        public int PositionId { get; set; }
    }
}
