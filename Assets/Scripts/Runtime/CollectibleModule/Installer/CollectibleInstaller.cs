using Cysharp.Threading.Tasks;
using Runtime.CollectibleModule.Controller;
using Runtime.CollectibleModule.Factory;
using Zenject;

namespace Runtime.CollectibleModule.Installer
{
    public class CollectibleInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<CollectibleController>().AsSingle().NonLazy();
            
            Container.BindFactory<string, int, int, UniTask<CollectibleItem>, CollectibleItem.Factory>()
                .FromFactory<CollectibleItemFactory>();
        }
    }
}