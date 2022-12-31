using HW_Collections.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Collections
{
    public class UI
    {
        private readonly IDepartmentService _departmentService;
        public UI(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
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
                int change;
                Int32.TryParse(Console.ReadLine(), out change);
                switch (change)
                {
                    case 1:
                        _departmentService.AddDepartment();
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
