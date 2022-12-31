namespace HW_Collections.Services.Interfaces
{
    public interface IDepartmentService
    {
        public bool SearchDepartmentByName(string depName);

        public void AddDepartment(string depName, DateOnly dateOfCreate);
    }
}
