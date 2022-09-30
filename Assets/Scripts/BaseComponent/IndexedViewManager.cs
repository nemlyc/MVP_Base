using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVP_base.Interface;

namespace MVP_base.Component
{
    [RequireComponent(typeof(CanvasGroup))]
    public class IndexedViewManager : ClosableView, IIndexedViewManager
    {
        List<IClosableView> _view;
        int _localIndex = 0;
        int _lastIndex = 0;

        private void Awake()
        {
            _view = new List<IClosableView>();
        }

        public void AddView(IClosableView view, IIndexedViewManager parentIndexedView)
        {
            view.SetParent(parentIndexedView);
            _view.Add(view);
        }

        public void RemoveView(IClosableView view)
        {
            _view.Remove(view);
        }

        public int GetCurrentView()
        {
            return _localIndex;
        }

        public void ShowView(int index)
        {
            _view[_localIndex].Close();

            _lastIndex = _localIndex;
            _localIndex = index;

            _view[_localIndex].Open();
        }

        public void NextView()
        {
            _localIndex += 1;
            if (_view.Count <= _localIndex)
            {
                _localIndex = 0;
            }
            ShowView(_localIndex);
        }

        public void PreviousView()
        {
            _localIndex -= 1;

            if (_localIndex < 0)
            {
                _localIndex = _view.Count - 1;
            }

            ShowView(_localIndex);
        }

        public void BackView()
        {
            ShowView(_lastIndex);
        }
    }
}
