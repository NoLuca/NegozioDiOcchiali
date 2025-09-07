using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class User
{
    public string UserId;
    public string UserName;
    public string Email;
    public List<string> Favorites = new();
    public List<Order> Orders = new();
}
