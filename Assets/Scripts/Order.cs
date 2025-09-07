using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Order
{
    public string OrderId;
    public DateTime Date;
    public List<CartItem> Items = new();
    public float Total;
}
