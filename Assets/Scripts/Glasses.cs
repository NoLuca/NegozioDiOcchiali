using System;
using System.Collections.Generic;
using UnityEngine;

public enum FrameShape
{
    Round,
    Square,
    Aviator,
    CatEye,
    Rectangular
}

[Serializable]
public class Glasses
{
    public string Id;
    public string Brand;
    public FrameShape Shape;
    public string Color;
    public float Price;
    public int Popularity;
}
