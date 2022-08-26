using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using ApplicationDbContext;

namespace DbContextDIFunction
{
    public class Function1
    {
        private ApplicationContext applicationContext;
        public Function1(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
