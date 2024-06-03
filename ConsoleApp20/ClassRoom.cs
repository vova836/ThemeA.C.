using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    /// <summary>
    /// Создаем класс Классная-Комната
    /// </summary>
    class ClassRoom
    {
        /// <summary>
        /// Создаем конструктор без парамметров
        /// </summary>
        public ClassRoom()
        {

        }

        /// <summary>
        /// Конструктор с парамметрамии
        /// </summary>
        /// <param name="pupil"></param>
        public ClassRoom(Pupil pupil)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pupil"></param>
        /// <param name="pupil1"></param>
        /// <param name="pupil2"></param>
        /// <param name="pupil3"></param>
        public ClassRoom(Pupil pupil, Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {

        }

        public void Print(Pupil pupil)
        {
            Console.WriteLine($"Ученик {pupil.SurName}");
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            pupil.Study();
        }
    }
}
