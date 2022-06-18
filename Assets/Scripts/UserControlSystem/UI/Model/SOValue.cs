using System;
using UnityEngine;

public class SOValue<T> : ScriptableObject
{
    public T CurrentValue { get; private set; }
    public Action<T> BaseAction;

    public void SetValue(T value)
    {
        CurrentValue = value;
        BaseAction?.Invoke(value);
    }
}
