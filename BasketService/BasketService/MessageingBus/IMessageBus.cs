using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketService.MessageingBus
{
    public interface IMessageBus
    {
        void SendMessage(BaseMessage message, string QueueName);
    }
}
