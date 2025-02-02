﻿using Ahsan.Domain.Entities;
using Ahsan.Service.DTOs.Users;
using System.Linq.Expressions;

namespace Ahsan.Service.Interfaces
{
    public interface IUserService
    {
        ValueTask<UserForResultDto> CreateAsync(UserForCreationDto dto);
        ValueTask<UserForResultDto> UpdateAsync(long id, UserForUpdateDto dto);
        ValueTask<UserForResultDto> GetAsync(Expression<Func<User, bool>> expression);
        ValueTask<IEnumerable<UserForResultDto>> GetAllAsync(Expression<Func<User, bool>> expression = null, string search = null);
        ValueTask<bool> DeleteAsync(Expression<Func<User, bool>> expression);
        ValueTask<UserForResultDto> ChangePasswordAsync(UserForChangePassword dto);
    }
}
