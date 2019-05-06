using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS
{
    public interface ICommand
    {
        Guid CommandId { get; }
    }

    public abstract class CommandBase : ICommand
    {
        public Guid CommandId { get; private set; }

        public CommandBase()
        {
            CommandId = Guid.NewGuid();
        }
    }
}
