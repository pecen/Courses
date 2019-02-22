using Prism.Ioc;
using Prism.Modularity;
using Colloseum.UI.Module.Views;
using Colloseum.UI.Module.ViewModels;

namespace Colloseum.UI.Module {
  public class ModuleModule : IModule {
    public void OnInitialized(IContainerProvider containerProvider) {

    }

    public void RegisterTypes(IContainerRegistry containerRegistry) {
      containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
    }
  }
}
