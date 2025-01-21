using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionAppServiceBusQueueTrigger
{
    public class Function1
    {
        // The function is triggered by new messages arriving in the Service Bus queue named "mynewqueue"
        //When a new message is added to the queue, the function is invoked
        [FunctionName("Function1")]
        public void Run([ServiceBusTrigger("mynewqueue", Connection = "ServiceBusConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
