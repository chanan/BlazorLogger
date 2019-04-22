using System.Threading.Tasks;

namespace BlazorLogger
{
    public interface ILogger
    {
        Task<bool> Clear();
        Task<bool> Count(string label);
        Task<bool> Error(params object[] list);
        Task<bool> Group(params object[] list);
        Task<bool> GroupCollapsed(params object[] list);
        Task<bool> GroupEnd();
        Task<bool> Info(params object[] list);
        Task<bool> Log(params object[] list);
        Task<bool> Table(object obj);
        Task<bool> Table(object obj, string[] columns);
        Task<bool> Time(string label);
        Task<bool> TimeEnd(string label);
        Task<bool> Warn(params object[] list);
    }
}