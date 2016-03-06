using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace DiverseNote.IndexService
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>                                 
            {
                x.Service<IndexService>(s =>                        
                {
                    s.ConstructUsing(name => new IndexService());   
                    s.WhenStarted(tc => tc.Start());             
                    s.WhenStopped(tc => tc.Stop());            
                });
                x.RunAsLocalSystem();                          

                x.SetDescription("Uploads records to search index");       
                x.SetDisplayName("DivNote Search Index");                    
                x.SetServiceName("SearchIndexService");                
            });
        }
    }
}
