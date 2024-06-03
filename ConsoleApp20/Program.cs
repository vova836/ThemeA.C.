using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcellentPupil excellentPupil = new ExcellentPupil("Петров");
            GoodPupil goodPupil = new GoodPupil("Иванов");
            TriPupil triPupil = new TriPupil("Козлов");
            BadPupil badPupil = new BadPupil("Сидоров");

            ClassRoom classRoom = new ClassRoom(excellentPupil, goodPupil, triPupil, badPupil);
            ClassRoom classRoom1 = (Pupil.excellentPupil);
        }
    }
}
