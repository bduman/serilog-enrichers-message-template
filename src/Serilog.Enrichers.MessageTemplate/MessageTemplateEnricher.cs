using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers.MessageTemplate
{
    public class MessageTemplateEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            logEvent.AddOrUpdateProperty(
                propertyFactory.CreateProperty("MessageTemplate", logEvent.MessageTemplate.Text)
            );
        }
    }
}
