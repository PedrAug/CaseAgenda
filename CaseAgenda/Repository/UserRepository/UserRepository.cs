using CaseAgenda.Authentication;
using Dapper;
using System.Data;
using System.Text;

namespace CaseProject.Repository.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task <UserAccount> UserBase(UserLogin user)
        {
            var query = @"SELECT * FROM userbase where username = :username AND password = :password";
            var param = new DynamicParameters();
            param.Add(name: "username", value: user.Username, direction: ParameterDirection.Input);
            param.Add(name: "password", value: user.Password, direction: ParameterDirection.Input);
            var userBase = await _context.Connection.QueryAsync<UserAccount>(query, param);
            return userBase?.FirstOrDefault() ?? new UserAccount();
        }

        public void Register(UserAccount registerUser)
        {
            var query = new StringBuilder();
            query.Append("INSERT INTO userbase(username, password, email, role) ");
            query.Append("VALUES(:username, :password, :email, :role) ");

            var param = new DynamicParameters();
            param.Add(name: "username", value: registerUser.Username, direction: ParameterDirection.Input);
            param.Add(name: "password", value: registerUser.Password, direction: ParameterDirection.Input);
            param.Add(name: "email", value: registerUser.Email, direction: ParameterDirection.Input);
            param.Add(name: "role", value: registerUser.Role, direction: ParameterDirection.Input);

            _context.Connection.Execute(query.ToString(), param);
        }
    }
}
