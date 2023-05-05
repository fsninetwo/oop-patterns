using OOP_Patterns.Data.Models.UDM;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Observers.Subjects;
using OOP_Patterns.Services.Observers.Subjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Observer
{
    public class MessageObserverService : IMessageObserverService
    {
        private List<MessageSubject> subjects = new();

        public MessageObserverService() { }

        public Task<string> AddSubjectAsync(string message)
        {
            if(subjects.Where(x => x.Message == message).Count() > 1)
            {
                return Task.FromResult($"Subject with the same message: {message} already exists");
            }

            var subject = new MessageSubject(message);
            subjects.Add(subject);

            return Task.FromResult(subject.Message);
        }

        public async Task<string> AddSubscriberAsync(string message, string username)
        {
            var subject = subjects.FirstOrDefault(x => x.Message == message);

            subject ??= AddNewSubject(message);

            var observer = new Observers.Observer(username);
            subject.RegisterObserver(observer);

            return await Task.FromResult($"{subject.Message}, {observer.Username}");
        }

        public Task<string> RemoveSubscriberAsync(string message, string username)
        {
            var subject = subjects.FirstOrDefault(x => x.Message == message);

            if(subject is null)
            {
                return Task.FromResult($"Subject with the same message: {message} doesn't exist");
            }

            var observer = new Observers.Observer(username);
            subject.RemoveObserver(observer);

            return Task.FromResult($"{subject.Message}, {observer.Username}");
        }

        public Task<string> NotifyObserversAsync(string message)
        {
            var subject = subjects.FirstOrDefault(x => x.Message == message);

            if(subject is null)
            {
                return Task.FromResult($"Subject with the same message: {message} doesn't exist");
            }

            subject.NotifyObservers();

            return Task.FromResult($"Observers for subject with message: {message} are noted");
        }

        public Task<List<string>> GetSubjectsAsync()
        {
            var subjectMessages = subjects.Select(x => x.Message).ToList();

            return Task.FromResult(subjectMessages);
        }

        private MessageSubject AddNewSubject(string message)
        {
            var subject = new MessageSubject(message);
            subjects.Add(subject);

            return subject;
        }
    }
}
