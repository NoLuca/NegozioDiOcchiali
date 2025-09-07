using System;
using System.Collections.Generic;
using UnityEngine;

public class UserService
{
    public User Current { get; private set; }

    public void Login(String email, string name)
    {
        Current = new User
        {
            UserId = Guid.NewGuid().ToString(),
            UserName = name,
            Email = email
        };
    }
}
