using System.Collections;
using System.Collections.Generic;
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
        public void Open(IWindow parent);
    }
}
