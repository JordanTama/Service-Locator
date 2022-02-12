namespace JordanTama.ServiceLocator
{
    public interface IService
    {
        void OnServiceRegistered();
        void OnServiceUnregistered();
    }

    public delegate void ServiceDelegate<in T>(T service) where T : IService;
}