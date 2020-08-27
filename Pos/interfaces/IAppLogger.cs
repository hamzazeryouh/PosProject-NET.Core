using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pos.interfaces
{
    public interface IAppLogger<T>
    {
        void LogWarning(string message, params object[] args);
        void LogInformation(string message, params object[] args);
        void LogError(string message, params object[] args);
    }
}
