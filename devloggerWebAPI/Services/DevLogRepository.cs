using devloggerWebAPI.Data;
using devloggerWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devloggerWebAPI.Services
{
    public class DevLogRepository : IDevLogService
    {
        private DevLogDbContext _context;

        public DevLogRepository(DevLogDbContext context)
        {
            _context = context;
        }

        public void AddDevLog(DevLog devLog)
        {
            throw new NotImplementedException();
        }
        

        public void DeleteDevLog(int id)
        {
            throw new NotImplementedException();
        }

        public DevLog GetDevLog(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DevLog> GetDevLogs()
        {
            return _context.DevLogs;
        }

        public void UpdateDevLog(DevLog devLog)
        {
            throw new NotImplementedException();
        }
    }
}
