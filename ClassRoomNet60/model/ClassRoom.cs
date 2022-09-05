using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassRoomNet60.Data;

namespace ClassRoomNet60.model
{
    public class ClassRoom
    {
        #region Instance Fields
        private string _className;
        private List<Student> _studentList;
        private DateTime _semesterStart;
        #endregion

        #region Properties
        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }
        public List<Student> StudentList
        {
            get { return _studentList; }
            set { _studentList = value; }
        }

        public DateTime SemesterStart
        {
            get { return _semesterStart; }
            set { _semesterStart = value; }
        }
        #endregion

        #region Constructors
        public ClassRoom(string className, DateTime semesterStart)
        {
            _className = className;
            _studentList = MockData.StudentList();
            _semesterStart = semesterStart;
        }

        public ClassRoom()
        {
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{nameof(ClassName)}: {ClassName}, {nameof(SemesterStart)}: {SemesterStart.Day}/{SemesterStart.Month}-{SemesterStart.Year}";
        }
        #endregion
    }
}
