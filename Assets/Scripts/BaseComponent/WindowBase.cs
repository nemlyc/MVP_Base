using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVP_base.Interface;

namespace MVP_base.Component
{
    public class WindowBase : MonoBehaviour, IWindow
    {
        [SerializeField]
        UnityEngine.UI.Button button;

        [SerializeField]
        DialogBase dialog;

        private void Start()
        {
            button.onClick.AddListener(async () =>
            {
                dialog.Open(this);

                var ans = await dialog.Submit();
            });
        }

    }

}