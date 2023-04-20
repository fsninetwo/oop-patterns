using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Common.Domain.Interfaces;

namespace OOP_Patterns.API.Mediators.Interfaces
{
    public interface IMessageMediator : IMediator
    {
        public Task<string> HandleAsync(string message);
    }
}
