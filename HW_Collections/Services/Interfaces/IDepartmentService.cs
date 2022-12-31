namespace HW_Collections.Services.Interfaces
{
    public interface IDepartmentService
    {
        public bool SearchDepartmentByName(string depName);

        public bool AddDepartment(string depName, DateOnly dateOfCreate);

        public bool DeleteDepartment(string depName);

        public bool EditDepName(string oldName, string newName);

        public void ShowDepartments();
    }
}
