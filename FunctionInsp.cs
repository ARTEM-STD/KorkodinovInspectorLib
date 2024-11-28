using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public class FunctionInsp
    {// задаём название и имя главного инспектора
        private string NameID = "Автоинспекция г. Чита";
        private string GGInspector = "Васильев Василий Иванович";

        // Список всех сотрудников
        private List<string> FIOST = new List<string>()
        { "Иванов И.И.","Зиронов Т.А.","Миронов А.В.","Васильев В.И."};

        // Создаём метод GetInspector крирпый будет выводить как зовут главного инспектора
        public string GetInspector()
        {
            return GGInspector;
        }

        // Создаём метод GetCarInspection который будет выводить как зовут главного инспектора
        public string GetCarInspection()
        {
            return NameID;
        }
        // Создаём метод SetInspector который рандомно выбирает имя сотрудников 
        public bool SetInspector()
        {
            string[] workersForChief = { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В." };

            if (workersForChief.Length > 0)
            {// Рандомайзер
                Random rando = new Random();
                int index = rando.Next(workersForChief.Length);
                // Теперь имя главного инспектора изменено
                GGInspector = workersForChief[index];
                return true;
            }
            return false;
           
        }

        // Создаём метод GenerateNumber который рандомно генерирует госномер
        // в примере сказано что госномер должен примерно выглядеть "А456_75"
        // но это не правельный вариант на мой взгляд и я изменил на стандартный вид "А456ВВ_75"
        public string GenerateNumber()
        {
            // Выбирает рандомно буквы для госномера (общепринятые)
            Random random = new Random();
            char[] GosName = { 'A', 'B', 'M', 'X' };
            int number = random.Next(1000); //Генерирует число от 0 до 999
            char GosNam1 = GosName[random.Next(GosName.Length)]; // каждый shar рандомно выбирает для себя букву из GosName
            char GosNam2 = GosName[random.Next(GosName.Length)];
            char GosNam3 = GosName[random.Next(GosName.Length)];
            return $"{GosNam1}{number:D3}{GosNam2}{GosNam3}_75"; // D3 форматирует число с тремя цифрами

        }
        // создаём метод для возврашения списка сотрудников
        public List<string> GetWorker()
        {
            return FIOST;
        }
        // Создаём метод который будет добовлять нового сотрудника
        public bool AddWorker(string fullname)
        {// делаем через условие if на тот случай если не получится добавить
            // "!" нужно для того чтобы изменяло переменную FIOST
            if (!FIOST.Contains(fullname))
            {
                FIOST.Add(fullname);
                return true;
            }
            return false;
        }

    }
}
