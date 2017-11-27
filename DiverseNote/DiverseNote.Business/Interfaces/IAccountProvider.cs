using System.Threading.Tasks;
using DiverseNote.Objects;

namespace DiverseNote.Business.Interfaces
{
    public interface IAccountProvider
    {
        Task<string> RegisterUserAsync(UserAccount userInfo);
    }
}