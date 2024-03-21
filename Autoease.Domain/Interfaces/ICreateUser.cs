using System;
using Autoease.Domain.Entities;

namespace Autoease.Domain.Interfaces;
public interface ICreateUser
{
    public User Create(User user);
    List<User> GetAllUsers();
}