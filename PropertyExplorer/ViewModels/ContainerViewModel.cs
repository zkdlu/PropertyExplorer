using PropertyExplorer.Models;

namespace PropertyExplorer.ViewModels
{
    class ContainerViewModel : BaseViewModel
    {
        public EntityViewModel EntityViewModel { get; set; }

        public ContainerViewModel()
        {
            EntityViewModel = new EntityViewModel(new Entity());

            Mediator.SelectedEntityViewModel = EntityViewModel;
        }
    }
}
