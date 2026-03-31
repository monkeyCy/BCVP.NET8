using BCVP.NET8.Model;

namespace BCVP.NET8.Service
{
    public interface IUserService
    {
        Task<List<UserVo>> Query();
    }
}
