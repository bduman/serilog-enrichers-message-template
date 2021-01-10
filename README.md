# Serilog.Enrichers.MessageTemplate

![Nuget Push](https://github.com/bduman/serilog-enrichers-message-template/workflows/Nuget%20Push/badge.svg) [![Nuget](https://img.shields.io/nuget/v/Serilog.Enrichers.MessageTemplate)](https://www.nuget.org/packages/Serilog.Enrichers.MessageTemplate/)

Enriches Serilog events with log event's message template.

To use the enricher, first install the NuGet package:

```
Install-Package Serilog.Enrichers.MessageTemplate
```

Then, apply the enricher to your LoggerConfiguration:

```
Log.Logger = new LoggerConfiguration()
    .Enrich.WithMessageTempate()
    // ...other configuration...
    .CreateLogger();
```

The WithMessageTempate() enricher will add a MessageTemplate property to produced events.

## What's message template ?

When you log any message to your sinks, as below, the message template is given as the first argument.

```
Log.Information("Single log info"); // non-structural
Log.Information("Single log info {@test}", "test"); // or structural
```

## How can i use it ?

Add {MessageTemplate} to your sink's output template.

```
..
.WriteTo.Console(outputTemplate:
        "[{Timestamp:HH:mm:ss} {Level:u3}] {MessageTemplate} {Message:lj}{NewLine}{Exception}")
.CreateLogger();
```