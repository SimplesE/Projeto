
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
namespace SimplesE.Factory.Common.Provider {

    public static class FactoryProvider {

        static IUnityContainer _container;

        static FactoryProvider() {

            _container = new UnityContainer();

            // Get Unity section.
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");

            // Configure Unity Application Block.
            section.Configure(_container);
        }

        public static IDataFactory GetDataFactory() {

            return _container.Resolve<IDataFactory>(); ;
        }
    }
}
