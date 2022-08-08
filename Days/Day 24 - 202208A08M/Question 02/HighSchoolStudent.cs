using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDay06082022
{
    class HighSchoolStudent:SchoolStudent
    {
        protected int scienceMark;
        protected int socialScienceMark;
        protected int mathematicsMark;

        public HighSchoolStudent(string p_studentName,
            int p_firstLanguageMark,
            int p_secondLanguageMark,
            int p_scienceMark, 
            int p_socialScienceMark, 
            int p_mathematicsMark) :
            base(p_studentName, p_firstLanguageMark,
                p_secondLanguageMark)
        {
            this.scienceMark = p_scienceMark;
            this.socialScienceMark = p_socialScienceMark;
            this.mathematicsMark = p_mathematicsMark;
        }
        public new void Read()
        {
            base.Read();
            Console.Write("Enter Science mark:");
            this.scienceMark = int.Parse(Console.ReadLine());
            Console.Write("Enter Social Science mark:");
            this.socialScienceMark = int.Parse(Console.ReadLine());
            Console.Write("Enter Mathematics mark:");
            this.mathematicsMark = int.Parse(Console.ReadLine());
        }
        public new void Calculate()
        {
            base.total =
                    base.firstLanguageMark + base.secondLanguageMark +
                    this.scienceMark + this.socialScienceMark + this.mathematicsMark;
            base.average = ((float)base.total / 5.0f);
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine($"Science Mark: {this.scienceMark}");
            Console.WriteLine($"Social Science Mark: {this.socialScienceMark}");
            Console.WriteLine($"Mathematics Mark: {this.mathematicsMark}");
            base.DisplayTotalAverage();
        }

    }
}
