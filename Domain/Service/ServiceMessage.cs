using Domain.Interfaces;
using Domain.Interfaces.InterfaceService;

namespace Domain.Service
{
    public class ServiceMessage : IServiceMessage
    {
        private readonly IMessage _IMessage;

        public ServiceMessage(IMessage IMessage)
        {
            _IMessage = IMessage; 
        }
    }
}
