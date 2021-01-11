using Serilog.Configuration;
using Serilog.Events;
using Xunit;

namespace Serilog.Enrichers.MessageTemplate.Tests
{
    public class MessageTemplateEnricherTests
    {
        [Fact]
        public void MessageTemplateEnricherIsApplied()
        {
            LogEvent evt = null;
            var log = new LoggerConfiguration()
                .Enrich.WithMessageTemplate()
                .WriteTo.Sink(new DelegatingSink(e => evt = e))
                .CreateLogger();

            log.Information("Single log info {@test}", "test");

            Assert.NotNull(evt);
            var messageTemplate = (string)evt.Properties["MessageTemplate"].LiteralValue();
            Assert.NotEmpty(messageTemplate);
            Assert.Equal(evt.MessageTemplate.Text, messageTemplate);
        }
    }
}
