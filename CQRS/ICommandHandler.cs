using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS
{
    public interface ICommandHandler<T> where T : ICommand
    {
        Task<object> Execute(T command);
    }
}
