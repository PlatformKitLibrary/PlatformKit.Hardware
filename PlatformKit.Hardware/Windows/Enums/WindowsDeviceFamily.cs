/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

namespace PlatformKit.Hardware.Windows
{
    /// <summary>
    /// 
    /// </summary>
    public enum WindowsDeviceFamily
    {
        /// <summary>
        /// Windows 10 or 11 [Home,Pro,Education,Enterprise,LTSC,Server]
        /// </summary>
        Desktop,
        /// <summary>
        /// Windows 10 or 11 based Xbox OS.
        /// </summary>
        Xbox,
        HoloLens,
        /// <summary>
        /// Windows 10 or 11 Teams OS.
        /// </summary>
        SurfaceHub,
    }
}