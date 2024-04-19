using CaseProject.Repository.UserRepository;
using System.Text;

namespace CaseAgenda.Authentication
{
    public class UserAccountService
    {
        private readonly IUserRepository _userRepository;

        public UserAccountService(IUserRepository userRepository)
        {
            _userRepository = userRepository;

        }

        public async Task<UserAccount> GetByUserName(UserLogin model) 
        {
            model.Password = EncryptPassword(model.Password);
            return await _userRepository.UserBase(model);
        }

        public async void ReigsterUser(UserAccount model) 
        {
            model.Password = EncryptPassword(model.Password);
            _userRepository.Register(model);
        }

        private string EncryptPassword(string pass)
        {
            if (string.IsNullOrEmpty(pass)) return "";

            var password = pass;
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (var t in data)
                sbString.Append(t.ToString("x2"));

            return sbString.ToString();
        }
    }
}
