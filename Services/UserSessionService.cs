using System;

namespace EventEase.Services
{
    public class UserSessionService
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public int? LastRegisteredEventId { get; set; }
        public DateTime? LastRegistrationTime { get; set; }

        public void SetSession(string name, string email, int? eventId)
        {
            UserName = name;
            UserEmail = email;
            LastRegisteredEventId = eventId;
            LastRegistrationTime = DateTime.Now;
        }

        public void ClearSession()
        {
            UserName = null;
            UserEmail = null;
            LastRegisteredEventId = null;
            LastRegistrationTime = null;
        }
    }
}
