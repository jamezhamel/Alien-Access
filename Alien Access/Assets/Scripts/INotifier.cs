using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INotifier 
{
    void Notify(string title, string message, float timer = 0);
}
