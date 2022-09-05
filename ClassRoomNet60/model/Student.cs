using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60.model
{
    public class Student
    {
        #region Instance Fields
        private string _name;
		private int _birthDay;
		private int _birthMonth;
        #endregion

        #region Properties
        public string Name
		{
			get { return _name; }
			private set { _name = value; }
		}

        public int BirthDay
        {
            get { return _birthDay; }
            private set { _birthDay = value; }
        }
        public int BirthMonth
        {
            get { return _birthMonth; }
            private set { _birthMonth = value; }
        }
        #endregion

        #region Constructors
        public Student(string name, int birthDay, int birthMonth)
        {
            _name = name;
            _birthDay = birthDay;
            _birthMonth = birthMonth;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(BirthDay)}: {BirthDay}, {nameof(BirthMonth)}: {BirthMonth}";
        }
        #endregion
    }
}
