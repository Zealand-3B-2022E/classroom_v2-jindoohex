using ClassRoomNet60.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60.Data
{
    public class MockData
    {
        public static List<Student> StudentList()
        {
           List<Student> StudentList = new List<Student>()
            {
                new Student("Alex", 1, 7),
                new Student("Bjarne", 1, 7),
                new Student("Matilde", 19, 12),
                new Student("Ulrikke", 12, 1),
                new Student("Bent", 22, 6),
                new Student("Patrick", 1, 5),
                new Student("Jens", 1, 5),
                new Student("Ingolf", 1, 2),
                new Student("Cirkeline", 1, 3),
                new Student("Mads", 1, 4),
                new Student("Bumbum", 1, 11),
                new Student("Alberte", 1, 8),
                new Student("Michael", 1, 8),
                new Student("Alfred", 1, 4),
                new Student("Mike", 1, 7)
            };
            return StudentList;
        }
    }
}
