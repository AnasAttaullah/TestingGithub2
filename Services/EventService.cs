using System;
using System.Collections.Generic;
using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        private readonly List<Event> _events = new List<Event>
        {
            new Event { Id = 1, Name = "Corporate Gala", Date = DateTime.Now.AddDays(10), Location = "Grand Hall", Description = "A grand corporate gathering." },
            new Event { Id = 2, Name = "Tech Conference", Date = DateTime.Now.AddDays(20), Location = "Tech Park", Description = "Annual technology conference." },
            new Event { Id = 3, Name = "Charity Ball", Date = DateTime.Now.AddDays(30), Location = "City Center", Description = "Fundraising event for charity." }
        };

        public List<Event> GetEvents()
        {
            return _events;
        }

        public void AddEvent(Event newEvent)
        {
            // Assign a new Id
            newEvent.Id = _events.Count > 0 ? _events[^1].Id + 1 : 1;
            _events.Add(newEvent);
        }
    }
}
