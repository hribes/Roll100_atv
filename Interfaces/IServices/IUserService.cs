using Roll100.DTO;
using Roll100.Entities;

namespace Roll100.Interfaces.IServices
{
    public interface IUserService
    {
        public void Create(CreateUserDTO user);
        public User GetUserByNick(string nick);
        public List<User> GetUsers();
        public User GetUserById(int id);
    }
}
