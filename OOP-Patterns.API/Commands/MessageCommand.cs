using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Common.Domain.Interfaces;

namespace OOP_Patterns.API.Commands
{
    public class MessageCommand : ICommand
    {
        public string Message { get; set; }

        public MessageCommand(string message) 
        { 
            Message = message;
        }
    }
}
