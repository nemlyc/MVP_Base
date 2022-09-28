using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MVP_base.Interface;
using System;
using UnityEngine.EventSystems;

namespace MVP_base.Component
{
    [RequireComponent(typeof(CanvasGroup))]
    public class DialogBase : ClosableView, IDialog
    {
        [SerializeField]
        Button m_submitButton, m_cancelButton;
        [SerializeField]
        bool OnStartVisible = false;
        [SerializeField]
        GameObject _panel;

        public virtual void Open(Action submitAction, Action cancelAction = null)
        {
            base.EnableCanvas();

            m_submitButton.onClick.AddListener(() =>
            {
                submitAction.Invoke();
            });
            m_cancelButton.onClick.AddListener(() =>
            {
                if (cancelAction != null)
                {
                    cancelAction.Invoke();
                }
                Close();
            });
        }

        public virtual void Close()
        {
            base.DisableCanvas();
        }

        private void Start()
        {
            if (!OnStartVisible)
            {
                base.DisableCanvas();
            }
            else
            {
                base.EnableCanvas();
            }
        }
    }
}
