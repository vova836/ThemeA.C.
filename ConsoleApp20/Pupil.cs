using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    /// <summary>
    /// Создаем абстрактный класс Ученик
    /// </summary>
    abstract class Pupil
    {
        /// <summary>
        /// Добавляем свойство Фамилии ученика
        /// </summary>
        public string SurName { get; set; }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Pupil()
        {

        }

        /// <summary>
        /// Конструктор с параметрамми Фамилия
        /// </summary>
        /// <param name="surname"></param>
        public Pupil(string surname)
        {
            SurName = surname;
        }

        /// <summary>
        /// Создаем абстрактные методы
        /// </summary>
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();

    }
}
