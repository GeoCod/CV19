using CV19.Infrastructure.Commands.Base;
using System.Windows;

namespace CV19.Infrastructure.Commands
{
    internal class CloseApplicationCommnd : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
