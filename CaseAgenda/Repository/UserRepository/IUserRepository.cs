using CaseAgenda.Authentication;

namespace CaseProject.Repository.UserRepository
{
    public interface IUserRepository
    {
        Task <UserAccount> UserBase(UserLogin user);
        void Register(UserAccount registerUser);
    }
}
