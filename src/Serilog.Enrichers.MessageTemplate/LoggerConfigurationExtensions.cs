﻿using System;
using Serilog.Enrichers.MessageTemplate;

namespace Serilog.Configuration
{
    public static class MessageTemplateLoggerConfigurationExtensions
    {
        public static LoggerConfiguration WithMessageTemplate(this LoggerEnrichmentConfiguration enrichmentConfiguration)
        {
            if (enrichmentConfiguration == null)
            {
                throw new ArgumentNullException(nameof(enrichmentConfiguration));
            }

            return enrichmentConfiguration.With<MessageTemplateEnricher>();
        }
    }
}