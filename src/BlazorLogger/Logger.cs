using Microsoft.AspNetCore.Blazor.Browser.Interop;
using System.Collections.Generic;

namespace BlazorLogger
{
    public class Logger
    {
        public static void Clear()
        {
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.Clear");
        }


        //Currently does not work: https://github.com/aspnet/Blazor/issues/739
        /*public static void Count()
        {
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.Count", null);
        }*/

        public static void Count(string label)
        {
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.Count", label);
        }
        public static void Error(params object[] list)
        {
            var _list = new List<object>(list);
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.Error", _list);
        }
        public static void Group(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.Group", _list);
        }
        public static void GroupCollapsed(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.GroupCollapsed", _list);
        }
        public static void GroupEnd()
        {
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.GroupEnd");
        }
        public static void Info(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.Info", _list);
        }
        public static void Log(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.Log", _list);
        }
        public static void Table(object obj)
        {
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.Table", obj);
        }
        public static void Table(object obj, string[] columns)
        {
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.TableColumns", obj, columns);
        }
        public static void Time(string label)
        {
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.Time", label);
        }
        public static void TimeEnd(string label)
        {
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.TimeEnd", label);
        }
        public static void Warn(params object[] list)
        {
            var _list = new List<object>(list); //This line is needed see: https://github.com/aspnet/Blazor/issues/740
            RegisteredFunction.Invoke<bool>("BlazorLogger.Logger.Warn", _list);
        }
    }
}
