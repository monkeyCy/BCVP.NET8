using BCVP.NET8.Model;
using Newtonsoft.Json;

namespace BCVP.NET8.Repository
{
    internal class UserRepository : IUserRepository
    {
        public async Task<List<User>> Query()
        {
            //等待一秒
            await Task.Delay(1000);
            var data = new List<User>();
            data.Add(new User() { Id = 1, Name = "zhangsan"});
            string jsonData = JsonConvert.SerializeObject(data);
            return JsonConvert.DeserializeObject<List<User>>(jsonData) ?? data;

        }
    }
}
