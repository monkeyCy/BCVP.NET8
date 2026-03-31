using BCVP.NET8.Model;
using BCVP.NET8.Repository;
using Newtonsoft.Json;

namespace BCVP.NET8.Service
{
    public class UserService : IUserService
    {
        public async Task<List<UserVo>> Query()
        {
            //等待一秒
            await Task.Delay(1000);
            var data = new List<UserVo>();
            data.Add(new UserVo() { UserName = "zhangsan" });
            string jsonData = JsonConvert.SerializeObject(data);
            return JsonConvert.DeserializeObject<List<UserVo>>(jsonData) ?? data;

        }
    }
}
