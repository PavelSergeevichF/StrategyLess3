using System;
using UnityEngine;

namespace UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(Vector3Value), menuName = "Strategy Game/" + nameof(Vector3Value), order = 0)]
    public sealed class Vector3Value : SOValue<Vector3>
    { 
        //public Action<Vector3> OnNewValue 
        //{
        //    get => base.BaseAction;
        //    set => base.BaseAction = value;
        //}
    }
}