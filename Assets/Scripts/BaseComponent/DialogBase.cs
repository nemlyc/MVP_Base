using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MVP_base.Interface;

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


        }
    }
}
