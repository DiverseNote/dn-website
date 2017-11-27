using System;
using System.Threading.Tasks;
using DiverseNote.Business.Interfaces;
using DiverseNote.Business.Providers.Interfaces;
using DiverseNote.Objects;
using DiverseNote.Data.EntityRepositories.Interfaces;

namespace DiverseNote.Business.Providers
{
    public class AccountProvider : IAccountProvider
    {
        private readonly IEmailProvider _emailProvider;
        private readonly IAccountRepository _accountRepository;

        private readonly string _confirmationEmailSubject = "Confirm DiverseNote Registration";
        private readonly string _fromEmail = "donotreply@diversenote.com";
        private readonly string _emailBody = "click to confirm your new account";

        public AccountProvider(IEmailProvider emailProvider)
        {
            _emailProvider = emailProvider;
        }

        public async Task<string> RegisterUserAsync(UserAccount userInfo)
        {
            if (ValidateRegistration(userInfo)) throw new ArgumentException();

            userInfo.Activated = false;
            SendConfirmationEmail(userInfo);
            var id = await _accountRepository.InsertOneAsync(userInfo);
            return id; 
        }

        private void SendConfirmationEmail(UserAccount userInfo)
        {
            _emailProvider.Send(_confirmationEmailSubject, userInfo.EmailAddress, _fromEmail, _emailBody);
        }

        private bool ValidateRegistration(UserAccount userInfo)
        {
            return(string.IsNullOrEmpty(userInfo.EmailAddress));
        }
    }
}
