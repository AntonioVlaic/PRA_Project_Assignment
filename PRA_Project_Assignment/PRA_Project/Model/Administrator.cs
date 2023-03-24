using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Model
{
    public class Administrator : User, IPublisher
    {
        public Administrator(string firstName, string lastName) : base(id, firstName, lastName)
        {
        }

        public Subject CreateSubject(string name)
        {
            return new Subject(name);
        }


        public void DeleteSubject(int id)
        {
            //Dohvati sve nastavnike i kolegije -> nastavnicima koji imaju prop kolegija kojeg se briše se
            //postavlja na null i kolegij se briše



        }

        public void UpdateSubject(int id)
        {

        }

        public void GetSubject(int id)
        {
            //Ispiši podatke o kolegiju i nastavnike vezane na kolegij
        }

        public Lecturer CreateLecturer(string firstName, string lastName) => new(firstName, lastName);
        public void UpdateLecturer(int id)
        {
            //TODO
        }

        public Lecturer GetLecturer(int id) { return new Lecturer("",""); } //TODO

        public Notification CreateNotification()
        {
            throw new NotImplementedException();
        }

        public void UpdateNotification()
        {
            throw new NotImplementedException();
        }

        public Notification GetNotification()
        {
            throw new NotImplementedException();
        }

        public void DeleteNotification()
        {
            throw new NotImplementedException();
        }
    }
}
