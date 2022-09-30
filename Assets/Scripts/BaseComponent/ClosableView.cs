using MVP_base.Interface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVP_base.Component
{
    [RequireComponent(typeof(CanvasGroup))]
    public class ClosableView : MonoBehaviour, IClosableView
    {
        public IIndexedViewManager Parent { get; private set; }

        [SerializeField]
        bool OnStartVisible = false;

        CanvasGroup _canvas;
        public virtual void Open()
        {
            EnableCanvas();
        }

        public virtual void Close()
        {
            DisableCanvas();
        }

        public void SetParent(IIndexedViewManager viewManager)
        {
            Parent = viewManager;
        }

        void EnableCanvas()
        {
            Validate();

            _canvas.alpha = 1.0f;
            _canvas.blocksRaycasts = true;
            _canvas.interactable = true;
        }

        void DisableCanvas()
        {
            Validate();

            _canvas.alpha = 0f;
            _canvas.blocksRaycasts = false;
            _canvas.interactable = false;
        }

        private void Awake()
        {
            _canvas = GetComponent<CanvasGroup>();

            if (!OnStartVisible)
            {
                DisableCanvas();
            }
            else
            {
                EnableCanvas();
            }
        }

        void Validate()
        {
            _canvas = GetComponent<CanvasGroup>();
        }
    }
}