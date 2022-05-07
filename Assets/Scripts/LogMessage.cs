using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMessage
{
    public LogType Type { get; set; }
    public DateTime Time { get; set; }
    public string Message { get; set; }

    public LogMessage(LogType type,string message)
    {
        Type = type;
        Message = message;
        Time = DateTime.UtcNow;
    }
}
