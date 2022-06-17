using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MVP_base.Interface;
using System.Threading.Tasks;

namespace MVP_base.Component
{
    public class DialogBase : MonoBehaviour, IDialog
    {
        [SerializeField]
        Button m_submitButton, m_cancelButton;
        [SerializeField]
        GameObject body;

        IWindow parent;

        public virtual void Open(IWindow parent)
        {
            this.parent = parent;

            body.SetActive(true);

            m_submitButton.onClick.AddListener(() =>
            {
                Submit();
            });
            m_cancelButton.onClick.AddListener(Close());
        }

        public virtual Task<bool> Close()
        {
            body.SetActive(false);

            return Task.FromResult(false);
        }

        public virtual Task<bool> Submit()
        {
            Close();

            return Task.FromResult(true);
        }
    }
}
