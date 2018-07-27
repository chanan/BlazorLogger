window.blazorLogger = {
    clear: function() {
        console.clear();
        return true;
    },
    count: function(label) {
        if (label !== null) console.count(label);
        else console.count();
        return true;
    },
    error: function(args) {
        if (Array.isArray(args)) {
            console["error"].apply(this, args)
        } else {
            console.error(args);
        }
        return true;
    },
    group: function(args) {
        if (Array.isArray(args)) {
            console["group"].apply(this, args)
        } else {
            console.group(args);
        }
        return true;
    },
    groupCollapsed: function(args) {
        if (Array.isArray(args)) {
            console["groupCollapsed"].apply(this, args)
        } else {
            console.groupCollapsed(args);
        }
        return true;
    },
    groupEnd: function() {
        console.groupEnd();
        return true;
    },
    info: function(args) {
        if (Array.isArray(args)) {
            console["info"].apply(this, args)
        } else {
            console.info(args);
        }
        return true;
    },
    log: function(args) {
        if (Array.isArray(args)) {
            console["log"].apply(this, args)
        } else {
            console.log(args);
        }
        return true;
    },
    table: function(obj) {
        console.table(obj);
        return true;
    },
    tableColumns: function(obj, columns) {
        console.table(obj, columns);
        return true;
    },
    time: function(label) {
        console.time(label);
        return true;
    },
    timeEnd: function(label) {
        console.timeEnd(label);
        return true;
    },
    warn: function(args) {
        if (Array.isArray(args)) {
            console["warn"].apply(this, args)
        } else {
            console.warn(args);
        }
        return true;
    }
};