using System;
using JetBrains.Annotations;
using Object = UnityEngine.Object;

namespace Modules.Views
{
    [UsedImplicitly]
    public sealed class ViewManager
    {
        private readonly ViewsContainer viewsContainer;
        private readonly ViewsSettings viewsSettings;

        public ViewManager(ViewsSettings viewsSettings, ViewsContainer viewsContainer)
        {
            this.viewsSettings = viewsSettings;
        }

        public View CreateView(string key)
        {
            if (viewsSettings.ViewPrefabs.TryGetValue(key, out View prefab))
            {
               return Object.Instantiate(prefab, viewsContainer.Parent);
            }

            throw new ArgumentOutOfRangeException();
        }
        
        public void DestroyView(View view)
        {
            Object.Destroy(view.gameObject);
        }
    }
}
