namespace NServiceBus.RavenDB
{
    using Persistence.SagaPersister;

    public static class ConfigureRavenSagaPersister
    {
        public static Configure UseRavenDBSagaStorage(this Configure config)
        {
           config.ThrowIfStoreNotConfigured();

            config.Configurer.ConfigureComponent<RavenSagaPersister>(DependencyLifecycle.InstancePerCall);

            return config;
        }
    }
}