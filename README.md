# BlazorLogger

A Javascript interop for console operations in Blazor framework

Temporary library till Blazor Supprts console operations directly: "The Mono team is working on a library that exposes standard browser APIs to .NET."

## Install

### Package Manager

[![NuGet Pre Release](https://img.shields.io/nuget/vpre/BlazorLogger.svg)](https://www.nuget.org/packages/BlazorLogger/)

## Docs

In your `Startup.cs` add the registration to `ConfigureServices` like so:

```
public void ConfigureServices(IServiceCollection services)
{
    services.AddJavascriptLogger();
}
```

Then inject `ILogger` into your class or page, for example:

```
@using BlazorLogger
@inject ILogger Logger
```

The api follows the same syntax as javascript "console" found here: https://developer.mozilla.org/en-US/docs/Web/API/Console with some minor exceptions:

* Non standard operations havent been ported (please let me know if you want to use any or submit a PR): dir, dirxml, profile, profileEnd, timeStamp
* trace did not seem useful coming from the Blazor code

To see these operations in action, you may download the sample project or view online: [Index.cshtml](https://github.com/chanan/BlazorLogger/blob/master/src/Sample/Pages/Index.cshtml)

### Supported calls

* Logger.Clear() - Clears the console
* Logger.Count(label) - Counts the number of times a line has been reached
* Logger.Error(params) - Writes an error to the console
* Logger.Group(params) - Begins a group
* Logger.GroupCollapsed(params) - Begins a collapsed group
* Logger.GroupEnd() - Ends the last opened group
* Logger.Info(params) - Writes an info level message to the console
* Logger.Log(params) - Logs a message to the console
* Logger.Table(object) - Displays a table on the console
* Logger.Table(object, columns) - Displays some columns of an object in table format
* Logger.Time(label) - Starts a timer
* Logger.TimeEnd(label) - End a timer
* Logger.Warn(params)

### Params

In the above API, params are used for `Error`, `Info`, `Log`, `Warn`, `Group`, and `GroupCollapsed`. Params are of type `params object[] list` so usage is similiar to how it used in JavaScript. For example, `Logger.Log("My object %O and My Number: %d", myObject, myNumber);`

For more examples please see the same project.

### Table Object

For `Logger.Table` an object is passed containing the table output. Please see the api for console or the attached sample project for examples.

## Styling Console Output

From [the api docs](https://developer.mozilla.org/en-US/docs/Web/API/console#Outputting_text_to_the_console):

You can use the %c directive to apply a CSS style to console output:

```
console.log("This is %cMy stylish message", "color: yellow; font-style: italic; background-color: blue;padding: 2px");
```



