Blazor.registerFunction('BlazorLogger.Logger.Clear', function () {
    console.clear();
    return true;
});

Blazor.registerFunction('BlazorLogger.Logger.Count', function (label) {
    if (label !== null) console.count(label);
    else console.count();
    return true;
});

Blazor.registerFunction('BlazorLogger.Logger.Error', function (args) {
    if (Array.isArray(args)) {
        console["error"].apply(this, args)
    } else {
        console.error(args);
    }
    return true;
});

Blazor.registerFunction('BlazorLogger.Logger.Group', function (args) {
    if (Array.isArray(args)) {
        console["group"].apply(this, args)
    } else {
        console.group(args);
    }
    return true;
});

Blazor.registerFunction('BlazorLogger.Logger.GroupCollapsed', function (args) {
    if (Array.isArray(args)) {
        console["groupCollapsed"].apply(this, args)
    } else {
        console.groupCollapsed(args);
    }
    return true;
});

Blazor.registerFunction('BlazorLogger.Logger.GroupEnd', function () {
    console.groupEnd();
    return true;
});

Blazor.registerFunction('BlazorLogger.Logger.Info', function (args) {
    if (Array.isArray(args)) {
        console["info"].apply(this, args)
    } else {
        console.info(args);
    }
    return true;
});

Blazor.registerFunction('BlazorLogger.Logger.Log', function (args) {
    if (Array.isArray(args)) {
        console["log"].apply(this, args)
    } else {
        console.log(args);
    }
    return true;
});

Blazor.registerFunction('BlazorLogger.Logger.Table', function (obj) {
    console.table(obj);
    return true;
});

Blazor.registerFunction('BlazorLogger.Logger.TableColumns', function (obj, columns) {
    console.table(obj, columns);
    return true;
});

Blazor.registerFunction('BlazorLogger.Logger.Time', function (label) {
    console.time(label);
    return true;
});

Blazor.registerFunction('BlazorLogger.Logger.TimeEnd', function (label) {
    console.timeEnd(label);
    return true;
});

Blazor.registerFunction('BlazorLogger.Logger.Warn', function (args) {
    if (Array.isArray(args)) {
        console["warn"].apply(this, args)
    } else {
        console.warn(args);
    }
    return true;
});