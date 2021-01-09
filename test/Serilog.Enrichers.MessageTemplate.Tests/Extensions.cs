using Serilog.Events;

namespace Serilog.Enrichers.MessageTemplate.Tests
{
    public static class Extensions
    {
        public static object LiteralValue(this LogEventPropertyValue @this)
        {
            return ((ScalarValue)@this).Value;
        }
    }
}
