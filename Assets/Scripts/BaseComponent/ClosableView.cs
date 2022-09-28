using MVP_base.Interface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVP_base.Component
{
    [RequireComponent(typeof(CanvasGroup))]
    public class ClosableView : MonoBehaviour, IClosableView
    {
        CanvasGroup _canvas;
        public virtual void EnableCanvas()
        {
            _canvas.alpha = 1.0f;
            _canvas.blocksRaycasts = true;
            _canvas.interactable = true;
        }

        public virtual void DisableCanvas()
        {
            _canvas.alpha = 0f;
            _canvas.blocksRaycasts = false;
            _canvas.interactable = false;
        }

        private void Awake()
        {
            _canvas = GetComponent<CanvasGroup>();
        }
    }

}