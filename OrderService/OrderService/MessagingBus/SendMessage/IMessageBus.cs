using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.MessagingBus.SendMessage
{
    public interface IMessageBus
    {
        void SendMessage(BaseMessage message, string QueueName);
    }
}
