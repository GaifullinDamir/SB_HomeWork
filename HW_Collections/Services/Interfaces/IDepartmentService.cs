namespace HW_Collections.Services.Interfaces
{
    public interface IDepartmentService
    {
        public bool SearchDepartmentByName(string depName);

        public bool AddDepartment(string depName, DateOnly dateOfCreate);

        public void ShowDepartments();
    }
}
