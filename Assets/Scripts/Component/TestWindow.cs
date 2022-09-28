using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVP_base.Component
{
    public class TestWindow : WindowBase
    {
        [SerializeField]
        UnityEngine.UI.Button button;

        [SerializeField]
        DialogBase dialog;

        private void Start()
        {
            button.onClick.AddListener(() =>
            {
                dialog.Open(() =>
                {
                    Debug.Log("Close");
                });
            });
        }
    }
}
