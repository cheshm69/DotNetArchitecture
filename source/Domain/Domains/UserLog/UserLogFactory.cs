using System;
using Solution.Model.Entities;
using Solution.Model.Enums;

namespace Solution.Domain.Domains
{
    public class UserLogFactory : IUserLogFactory
    {
        public UserLogEntity Create(long userId, LogType logType)
        {
            return new UserLogEntity
            {
                UserId = userId,
                LogType = logType,
                DateTime = DateTime.UtcNow
            };
        }
    }
}
