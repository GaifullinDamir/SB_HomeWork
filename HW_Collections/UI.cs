using HW_Collections.Services;
using HW_Collections.Services.Interfaces;

namespace HW_Collections
{
    public class UI
    {
        private readonly Departments _departments;
        private readonly IDepartmentService _departmentService;
        public UI()
        {
            _departments = new Departments();
            _departmentService = new DepartmentService(_departments);
        }
        private void ShowMenu()
        {
            Console.WriteLine("\n" +
                "1. Добавить департамент\n" +
                "2. Добавить сотрудника\n" +
                "3. Удалить департамент\n" +
                "4. Удалить сотрудника\n" +
                "5. Редактировать департамент\n" +
                "6. Редактировать сотрудника\n" +
                "7. Вывести департаменты на экран\n" +
                "8. Вывести сотрудников на экран\n" +
                "9. Выгрузить департаменты в XML\n" +
                "10. Выгрузить сотрудников в JSON\n" +
                "11. Загрузить сотрудников из XML\n" +
                "12. Загрузить сотрудников из JSON\n" +
                "13. Завершить работу.\n");
        }

        public void EnterProgram()
        {
            bool run = true;
            while (run)
            {
                
                ShowMenu();
                int choice;
                Int32.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nВведите название департамента:");
                        var depName1 = Console.ReadLine();
                        Console.WriteLine("\nВведите дату создания департамента (dd.mm.yyyy):");
                        var strDateOfCreate = Console.ReadLine();
                        var dateOfCreate = DateOnly.Parse(strDateOfCreate);
                        if (_departmentService.AddDepartment(depName1, dateOfCreate))
                        {
                            Console.WriteLine($"\nДепартамент {depName1} добавлен.");
                        }
                        else
                        {
                            Console.WriteLine("\nПроизошла ошибка при добавлении.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nВведите название департамента:");
                        var depName3 = Console.ReadLine();
                        if (_departmentService.DeleteDepartment(depName3))
                        {
                            Console.WriteLine($"\nДепартамент {depName3} удалён.");
                        }
                        else
                        {
                            Console.WriteLine("\nТакого департамента нет.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("\nВведите название департамента:");
                        var oldDepName = Console.ReadLine();
                        Console.WriteLine("\nВведитен новое название департамента:");
                        var newDepName = Console.ReadLine();
                        if (_departmentService.EditDepName(oldDepName, newDepName))
                        {
                            Console.WriteLine($"\nИмя департамента изменено с {oldDepName} на {newDepName}.");
                        }
                        else
                        {
                            Console.WriteLine("\nТакого департамента нет.");
                        }
                        break;
                    case 7:
                        _departmentService.ShowDepartments();
                        break;
                    case 13:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет.");
                        break;
                }
            }
        }

    }
}
