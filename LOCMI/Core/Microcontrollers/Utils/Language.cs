﻿namespace LOCMI.Core.Microcontrollers.Utils;

public struct Language
{
    public Language(string name, string version)
    {
        Name = name;
        Version = version;
    }

    public string Name { get; set; }

    public string Version { get; set; }
}