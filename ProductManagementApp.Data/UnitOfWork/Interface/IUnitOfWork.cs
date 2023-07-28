/*
 * IUnitOfWork: 
 * File: IUnitOfWork.cs
 * Author: Sam
 */

namespace ProductManagementApp.Data
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
    }
}
