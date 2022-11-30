﻿namespace LOCMI.Core.Microcontrollers.Utils;

public struct Identification
{
    public Identification(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public string Brand { get; set; }

    public string Model { get; set; }
}