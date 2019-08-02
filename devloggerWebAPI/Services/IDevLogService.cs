using devloggerWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devloggerWebAPI.Services
{
    public interface IDevLogService
    {
        IQueryable<DevLog> GetDevLogs();
        DevLog GetDevLog(int id);
        void AddDevLog(DevLog devLog);
        void UpdateDevLog(DevLog devLog);
        void DeleteDevLog(int id);
    }
    
}
