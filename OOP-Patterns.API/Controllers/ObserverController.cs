using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class ObserverController : BaseController
    {
        private readonly IMessageObserverService _messageObserverService;

        public ObserverController(IMessageObserverService messageObserverService)
        {
            _messageObserverService = messageObserverService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSubjects()
        {
            return Ok(await _messageObserverService.GetSubjectsAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddSubject(string message)
        {
            return Ok(await _messageObserverService.AddSubjectAsync(message));
        }

        [HttpPost]
        public async Task<IActionResult> AddSubscriber(string message, string username)
        {
            return Ok(await _messageObserverService.AddSubscriberAsync(message, username));
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveSubscriber(string message, string username)
        {
            return Ok(await _messageObserverService.RemoveSubscriberAsync(message, username));
        }

        [HttpPut]
        public async Task<IActionResult> NotifyObservers(string message)
        {
            return Ok(await _messageObserverService.NotifyObserversAsync(message));
        }
    }
}
