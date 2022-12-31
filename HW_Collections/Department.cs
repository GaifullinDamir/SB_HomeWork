namespace HW_Collections
{
    public class Department
    {
        public string DepName { get; set; }
        public DateOnly DateOfCreate { get; set; }

        private int employeesCount;

        public int EmployeesCount
        {
            get { return employeesCount; }
            set 
            { 
                if (value <= 1000000)
                {
                    employeesCount = value;
                }
                else
                {
                    Console.WriteLine($"В филиале {DepName} не может быть более 1 000 000 сотрудников\n" +
                        $"будет занесено число 1 000 000") ;
                    employeesCount = 1000000;
                }
                
            }
        }

    }
}
