using BookStore.BasicProject.Application.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BasicProject.Application.Users
{
    public class UserAppService : IUserAppService
    {
        public async Task<UserDto> GetUserAsync(int id)
        {
            await Task.CompletedTask;
            return new UserDto()
            {
                Id=1,
                UserName="amy",
                Password="111111",
                Email="123456789@qq.com"
            };
        }

        public async Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            await Task.CompletedTask;
            return new List<UserDto>()
            {
                new UserDto(){
                Id=1,
                UserName="amy",
                Password="111111",
                Email="123456789@qq.com"
                }
            };
        }
    }
}
