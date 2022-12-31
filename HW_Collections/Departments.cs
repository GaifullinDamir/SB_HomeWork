namespace HW_Collections
{
    public class Departments
    {
        private List<Department> _departments;
        public Departments()
        {
            _departments = new List<Department>();
        }
        public bool SearchDepartmentByName(string depName)
        {
            foreach (var department in _departments)
            {
                if (department.DepName == depName)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddDepartment(string depName, DateOnly dateOfCreate)
        {
            var department = new Department()
            {
                DepName = depName,
                DateOfCreate = dateOfCreate
            };
            _departments.Add(department);
        }
        public void ShowDepartments()
        {
            Console.WriteLine("\nДепартамент:\tДата создания:\t");
            foreach (var department in _departments)
            {
                Console.WriteLine($"{department.DepName}\t{department.DateOfCreate}");
            }
        }
    }
}
