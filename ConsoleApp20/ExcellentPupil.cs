using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    /// <summary>
    /// Создаем класс-потомок Идеальный-Ученик абстрактного класса ученик
    /// </summary>
    class ExcellentPupil : Pupil
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public ExcellentPupil()
        {

        }

        /// <summary>
        /// Добавляем конструктор абстрактного класса Ученик
        /// </summary>
        /// <param name="lastName"></param>
        public ExcellentPupil(string surName) : base(surName) 
        { 

        }

        /// <summary>
        /// Метод который выводит информация как учится ученик
        /// </summary>
        public override void Study()
        {
            Console.WriteLine($"{SurName} учится отлично!");
        }

        /// <summary>
        /// Метод который выводит информацию как читает ученик
        /// </summary>
        public override void Read()
        {
            Console.WriteLine($"{SurName} читает очень быстро!");
        }

        /// <summary>
        /// Метод выводит информацию как пишет ученик
        /// </summary>
        public override void Write()
        {
            Console.WriteLine($"{SurName} пишет без ошибок!");
        }

        /// <summary>
        /// Метод информации как отыхает ученик
        /// </summary>
        public override void Relax()
        {
            Console.WriteLine($"{SurName} отдыхает, играя шахматы!");
        }
    }
}
