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
            set { _name = value; }
        }

        public int BirthDay
        {
            get { return _birthDay; }
            set { _birthDay = value; }
        }
        public int BirthMonth
        {
            get { return _birthMonth; }
            set
            {
                if (value >= 1 && value <= 12)
                    _birthMonth = value;
                else
                    throw new ArgumentException($"You have entered an invalid seasonal month, acceptable values are 1-12. You typed: {value}");
            }
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
        public string Season()
        {
            switch (_birthMonth)
            {
                case 1:
                case 2:
                case 12:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                case 9:
                case 10:
                case 11:
                    return "Autumn";
                default:
                    return $"This month: {BirthMonth} are not in the interval: 1-12";

            }
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(BirthDay)}: {BirthDay}, {nameof(BirthMonth)}: {BirthMonth}, Season: {Season()}";
        }
        #endregion
    }
}
