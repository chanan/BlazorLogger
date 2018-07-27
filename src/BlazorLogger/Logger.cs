using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorLogger
{
    public class Logger
    {
        public static Task<bool> Clear()
        {
            return JSRuntime.Current.InvokeAsync<bool>("blazorLogger.clear");
        }


        //Currently does not work: https://github.com/aspnet/Blazor/issues/739
        /*public static void Count()
        {
            RegisteredFunction.Invoke<bool>("blazorLogger.count", null);
        }*/

        public static Task<bool> Count(string label)
        {
            return JSRuntime.Current.InvokeAsync<bool>("blazorLogger.count", label);
        }
        public static Task<bool> Error(params object[] list)
        {
            var _list = new List<object>(list);
            return JSRuntime.Current.InvokeAsync<bool>("blazorLogger.error", _list);
        }
        public static Task<bool> Group(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            return JSRuntime.Current.InvokeAsync<bool>("blazorLogger.group", _list);
        }
        public static Task<bool> GroupCollapsed(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            return JSRuntime.Current.InvokeAsync<bool>("blazorLogger.groupCollapsed", _list);
        }
        public static Task<bool> GroupEnd()
        {
            return JSRuntime.Current.InvokeAsync<bool>("blazorLogger.groupEnd");
        }
        public static Task<bool> Info(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            return JSRuntime.Current.InvokeAsync<bool>("blazorLogger.info", _list);
        }
        public static Task<bool> Log(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            return JSRuntime.Current.InvokeAsync<bool>("blazorLogger.log", _list);
        }
        public static Task<bool> Table(object obj)
        {
            return JSRuntime.Current.InvokeAsync<bool>("blazorLogger.table", obj);
        }
        public static Task<bool> Table(object obj, string[] columns)
        {
            return JSRuntime.Current.InvokeAsync<bool>("blazorLogger.tableColumns", obj, columns);
        }
        public static Task<bool> Time(string label)
        {
            return JSRuntime.Current.InvokeAsync<bool>("blazorLogger.time", label);
        }
        public static Task<bool> TimeEnd(string label)
        {
            return JSRuntime.Current.InvokeAsync<bool>("blazorLogger.timeEnd", label);
        }
        public static Task<bool> Warn(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            return JSRuntime.Current.InvokeAsync<bool>("blazorLogger.warn", _list);
        }
    }
}