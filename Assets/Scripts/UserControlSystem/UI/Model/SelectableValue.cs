using System;
using Abstractions;
using UnityEngine;

namespace UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(SelectableValue), order = 0)]
    public class SelectableValue : SOValue<ISelectable>
    {
        //public Action<ISelectable> OnSelected
        //{
        //    get => base.BaseAction;
        //    set => base.BaseAction = value;
        //}
    }
}