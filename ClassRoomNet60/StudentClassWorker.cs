using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ClassRoomNet60.Data;
using ClassRoomNet60.model;

namespace ClassRoomNet60
{
    public class StudentClassWorker
    {
        #region Instance Fields
        public List<Student> StudentList = MockData.StudentList();
        #endregion

        #region Methods
        public void Start()
        {
            ClassRoom theClassRoom = new ClassRoom("Zealand-3B", new DateTime(2022, 9, 1));
            Console.WriteLine(theClassRoom.ToString());
            foreach (var Student in theClassRoom.StudentList)
            {
                Console.WriteLine(Student.ToString());
            }

            //var classRoom = new ClassRoom();
            //classRoom.ClassName = "Zealand-3B";
            //classRoom.SemesterStart = new DateTime(2022, 9, 1);

            Console.WriteLine();
            theClassRoom.FindSeasonalBirth();

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        #endregion
    }
}
