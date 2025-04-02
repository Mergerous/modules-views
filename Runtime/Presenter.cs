using Modules.UI.Views;
using R3;

namespace Modules.Views
{
    public abstract class Presenter
    {
        protected readonly CompositeDisposable disposables = new CompositeDisposable();

        public virtual void Subscribe()
        {
            
        }

        public virtual void Unsubscribe()
        {
            disposables.Dispose();
        }
    }
}