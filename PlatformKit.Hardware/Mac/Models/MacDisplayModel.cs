/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

using PlatformKit.Hardware.Components;

namespace PlatformKit.Hardware.Mac
{
    /// <summary>
    /// 
    /// </summary>
    public class MacDisplayModel : DisplayModel
    {
        public MacDisplayType MacDisplayType { get; set; }
    }
}