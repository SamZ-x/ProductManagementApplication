/*
 * UnitOfWork implementation.
 * File: IUnitOfWork.cs
 * Author: Sam
 */


namespace ProductManagementApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PMDataContext _pmDataContext;

        public IUserRepository UserRepository { get; private set; }

        public UnitOfWork(PMDataContext pMDataContext)
        {
            _pmDataContext = pMDataContext;
            UserRepository = new UserRepository(pMDataContext);
        }
    }
}
