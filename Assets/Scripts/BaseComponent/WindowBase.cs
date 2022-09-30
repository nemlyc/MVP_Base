using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVP_base.Interface;

namespace MVP_base.Component
{
    [RequireComponent(typeof(CanvasGroup))]
    public class WindowBase : ClosableView, IWindow
    {

    }
}