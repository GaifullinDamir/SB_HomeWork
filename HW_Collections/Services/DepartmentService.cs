using HW_Collections.Services.Interfaces;

namespace HW_Collections.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly Departments _departments;
        public DepartmentService(Departments departments)
        {
            _departments = departments;
        }
        public bool SearchDepartmentByName(string depName)
        {
            return _departments.SearchDepartmentByName(depName);
        }

        public bool AddDepartment(string depName, DateOnly dateOfCreate)
        {
            if (!SearchDepartmentByName(depName))
            {
                _departments.AddDepartment(depName, dateOfCreate);
                return true;
            }
            return false;
        }

        public void ShowDepartments()
        {
            _departments.ShowDepartments();
        }
    }
}
