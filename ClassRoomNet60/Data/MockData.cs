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
                new Student("Bjarne", 1, 7)
            };
            return StudentList;
        }
    }
}
