using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorLogger
{
    public class Logger : ILogger
    {
        private readonly IJSRuntime _jsRuntime;

        public Logger(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public Task<bool> Clear()
        {
            return _jsRuntime.InvokeAsync<bool>("blazorLogger.clear");
        }


        //Currently does not work: https://github.com/aspnet/Blazor/issues/739
        /*public static void Count()
        {
            RegisteredFunction.Invoke<bool>("blazorLogger.count", null);
        }*/

        public Task<bool> Count(string label)
        {
            return _jsRuntime.InvokeAsync<bool>("blazorLogger.count", label);
        }
        public Task<bool> Error(params object[] list)
        {
            var _list = new List<object>(list);
            return _jsRuntime.InvokeAsync<bool>("blazorLogger.error", _list);
        }
        public Task<bool> Group(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            return _jsRuntime.InvokeAsync<bool>("blazorLogger.group", _list);
        }
        public Task<bool> GroupCollapsed(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            return _jsRuntime.InvokeAsync<bool>("blazorLogger.groupCollapsed", _list);
        }
        public Task<bool> GroupEnd()
        {
            return _jsRuntime.InvokeAsync<bool>("blazorLogger.groupEnd");
        }
        public Task<bool> Info(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            return _jsRuntime.InvokeAsync<bool>("blazorLogger.info", _list);
        }
        public Task<bool> Log(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            return _jsRuntime.InvokeAsync<bool>("blazorLogger.log", _list);
        }
        public Task<bool> Table(object obj)
        {
            return _jsRuntime.InvokeAsync<bool>("blazorLogger.table", obj);
        }
        public Task<bool> Table(object obj, string[] columns)
        {
            return _jsRuntime.InvokeAsync<bool>("blazorLogger.tableColumns", obj, columns);
        }
        public Task<bool> Time(string label)
        {
            return _jsRuntime.InvokeAsync<bool>("blazorLogger.time", label);
        }
        public Task<bool> TimeEnd(string label)
        {
            return _jsRuntime.InvokeAsync<bool>("blazorLogger.timeEnd", label);
        }
        public Task<bool> Warn(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            return _jsRuntime.InvokeAsync<bool>("blazorLogger.warn", _list);
        }
    }
}