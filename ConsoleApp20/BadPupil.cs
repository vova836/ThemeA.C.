using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    /// <summary>
    /// Создаем класс-потомок Плохой-Ученик абстрактного класса ученик
    /// </summary>
    class BadPupil : Pupil
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public BadPupil()
        {

        }
        /// <summary>
        /// Добавляем конструктор абстрактного класса Ученик
        /// </summary>
        /// <param name="lastName"></param>
        public BadPupil(string lastName) : base(lastName)
        {

        }

        /// <summary>
        /// Метод который выводит информация как учится ученик
        /// </summary>
        public override void Study()
        {
            Console.WriteLine($"{SurName} учится плохо!");
        }

        /// <summary>
        /// Метод который выводит информацию как читает ученик
        /// </summary>
        public override void Read()
        {
            Console.WriteLine($"{SurName} читает очень медленно!");
        }

        /// <summary>
        /// Метод выводит информацию как пишет ученик
        /// </summary>
        public override void Write()
        {
            Console.WriteLine($"{SurName} пишет с большим количеством ошибок!");
        }

        /// <summary>
        /// Метод информации как отыхает ученик
        /// </summary>
        public override void Relax()
        {
            Console.WriteLine($"{SurName} отдыхает, играя в компьютер!");
        }
    }
}
