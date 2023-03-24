namespace PRA_Project.Model
{
    public class Lecturer : User, IPublisher
    {
        public Lecturer(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Subject Subject { get; set; }

        public Notification CreateNotification()
        {
            throw new NotImplementedException();
        }

        public void DeleteNotification()
        {
            throw new NotImplementedException();
        }

        public Notification GetNotification()
        {
            throw new NotImplementedException();
        }

        public void UpdateNotification()
        {
            throw new NotImplementedException();
        }
    }
}