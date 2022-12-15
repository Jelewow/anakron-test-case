namespace Anakron.Infrastructure.Services
{
    public class Services
    {
        public static Services Container => _instance ??= new Services();

        private static Services _instance;

        public void RegisterSingle<TService>(TService service) where TService : IService
        {
            Implementation<TService>.ServiceInstance = service;
        }

        public TService Single<TService>() where TService : IService
        {
            return Implementation<TService>.ServiceInstance;
        }
        
        private static class Implementation<TService> where TService : IService
        {
            public static TService ServiceInstance;
        }
    }
}