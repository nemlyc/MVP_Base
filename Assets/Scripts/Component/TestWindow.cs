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
        PromptDialog dialog, dialog2, dialog3;

        [SerializeField]
        IndexedViewManager indexed;

        private void Awake()
        {
            indexed.AddView(dialog, indexed);
            indexed.AddView(dialog2, indexed);
            indexed.AddView(dialog3, indexed);
        }

        private void Start()
        {
            button.onClick.AddListener(() =>
            {
                indexed.ShowView(0);
            });
        }
    }
}
