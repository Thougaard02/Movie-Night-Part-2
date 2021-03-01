using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night_Part_2
{
    class Actor
    {
        #region Properties

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        #endregion

        #region Constructors
        public Actor()
        {

        }
        public Actor(string _firstName, string _lastName)
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
        }
        public Actor(int _id, string _firstName, string _lastName):this(_firstName, _lastName)
        {
            this.Id = _id;
        }
        //Delete Movie with a id
        public Actor(int _id)
        {
            this.Id = _id;
        }
        #endregion
    }
}
