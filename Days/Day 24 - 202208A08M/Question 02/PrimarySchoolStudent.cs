using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDay06082022
{

    class PrimarySchoolStudent : SchoolStudent
    {
        protected int evsMark;
        protected int mathematicsMark;

        public PrimarySchoolStudent(string p_studentName,
            int p_firstLanguageMark,
            int p_secondLanguageMark,
            int p_evsMark, int p_mathematicsMark) :
            base(p_studentName, p_firstLanguageMark,
                p_secondLanguageMark)
        {
            this.evsMark = p_evsMark;
            this.mathematicsMark = p_mathematicsMark;
        }
        public new void Read()
        {
            base.Read();
            Console.Write("Enter EVS mark:");
            this.evsMark = int.Parse(Console.ReadLine());
            Console.Write("Enter Mathematics mark:");
            this.mathematicsMark = int.Parse(Console.ReadLine());
        }
        public new void Calculate()
        {
            base.total =
                    base.firstLanguageMark + base.secondLanguageMark +
                    this.evsMark + this.mathematicsMark;
            base.average = ((float)base.total / 4.0f);
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine($"EVS Mark: {this.evsMark}");
            Console.WriteLine($"Mathematics Mark: {this.mathematicsMark}");
            base.DisplayTotalAverage();
        }
    }
}
    

