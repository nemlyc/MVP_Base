using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVP_base.Interface
{
    public interface IClosableView
    {
        void Open();
        void Close();
        void SetParent(IIndexedViewManager viewManager);
    }
}