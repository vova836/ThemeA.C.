using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class TriPupil : Pupil
    {
        /// <summary>
        /// Конструктор без парамметров
        /// </summary>
        public TriPupil()
        {

        }
        /// <summary>
        /// Добавляем конструктор абстрактного класса Ученик
        /// </summary>
        /// <param name="lastName"></param>
        public TriPupil(string lastName) : base(lastName)
        {

        }

        /// <summary>
        /// Метод который выводит информация как учится ученик
        /// </summary>
        public override void Study()
        {
            Console.WriteLine($"{SurName} учится нехорошо!");
        }

        /// <summary>
        /// Метод который выводит информацию как читает ученик
        /// </summary>
        public override void Read()
        {
            Console.WriteLine($"{SurName} читает медленно!");
        }

        /// <summary>
        /// Метод выводит информацию как пишет ученик
        /// </summary>
        public override void Write()
        {
            Console.WriteLine($"{SurName} пишет с ошибками!");
        }

        /// <summary>
        /// Метод информации как отыхает ученик
        /// </summary>
        public override void Relax()
        {
            Console.WriteLine($"{SurName} отдыхает, играя в телефон!");
        }
    }
}
