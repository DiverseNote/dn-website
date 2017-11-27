using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiverseNote.Business.Providers.Interfaces;

namespace DiverseNote.Business.Providers.EmailProviders
{
    public class FakeEmailProvider : IEmailProvider
    {
        public void Send(string subject, string toAddress, string fromAddress, string body)
        {
            return;
        }
    }
}
