using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS
{
    public interface IEventPublisher
    {
        void Publish(IEvent @event);
    }
}
