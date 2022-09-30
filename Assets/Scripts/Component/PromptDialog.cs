using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MVP_base.Component
{
    public class PromptDialog : ClosableView
    {
        [SerializeField]
        Button button1, button2, button3, backbutton;

        [SerializeField]
        GameObject _panel;

        private void OnEnable()
        {
            button1.onClick.AddListener(() =>
            {
                base.Parent.ShowView(0);
            });
            button2.onClick.AddListener(() =>
            {
                base.Parent.ShowView(1);
            });
            button3.onClick.AddListener(() =>
            {
                base.Parent.ShowView(2);
            });
            backbutton.onClick.AddListener(() =>
            {
                base.Parent.BackView();
            });
        }
    }
}
