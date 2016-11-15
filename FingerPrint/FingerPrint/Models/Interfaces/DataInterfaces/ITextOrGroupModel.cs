﻿using FingerPrint.Models.Interfaces.FeatureInterfaces;
using FingerPrint.Models.Interfaces.TypeInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerPrint.Models.Interfaces
{
    /// <summary>
    /// Interface to be implemented by a text or group.
    /// </summary>
    public interface ITextOrGroupModel : ITextOrGroupViewModel
    {
        /// <summary>
        /// Sets the text or groups name.
        /// </summary>
        /// <param name="name">The text or group's new name.</param>
        void SetName(string name);
    }
}
