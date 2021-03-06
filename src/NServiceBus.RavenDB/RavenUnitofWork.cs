namespace NServiceBus.RavenDB.Persistence
{
    using System;
    using UnitOfWork;

    class RavenUnitOfWork : IManageUnitsOfWork
    {
        RavenSessionFactory sessionFactory;

        public RavenUnitOfWork(RavenSessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        public void Begin()
        {
        }

        public void End(Exception ex)
        {
            try
            {
                if (ex == null)
                {
                    sessionFactory.SaveChanges();
                }
            }
            finally
            {
                sessionFactory.ReleaseSession();
            }
        }
    }
}