using System.Threading.Tasks;

namespace EltradeCloud.Common.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
         Task HandleAsync(T command);
    }
}