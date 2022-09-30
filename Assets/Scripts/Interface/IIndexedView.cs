using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVP_base.Interface
{
    public interface IIndexedViewManager
    {
        public void AddView(IClosableView view, IIndexedViewManager parentIndexedView);
        public void RemoveView(IClosableView view);
        public void NextView();
        public void PreviousView();
        public void BackView();
        public int GetCurrentView();
        public void ShowView(int index);
    }
}