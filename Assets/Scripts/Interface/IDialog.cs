using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace MVP_base.Interface
{
    public interface IDialog
    {
        /// <summary>
        /// Open various dialog
        /// </summary>
        /// <param name="content">Result text</param>
        /// <returns>Response, means "OK" or "No".</returns>
        public void Open(Action submitAction, Action cancelAction = null);
        public void Close();
    }
}
