/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

namespace PlatformKit.Hardware.Mac
{
    /// <summary>
    /// The device family that a Mac belongs to.
    /// </summary>
    public enum MacDeviceFamily
    {
        MacBook,
        MacBookAir,
        MacBookPro,
        MacMini,
        MacMiniServer,
        MacStudio,
        MacPro,
        // ReSharper disable once InconsistentNaming
        iMac,
        // ReSharper disable once InconsistentNaming
        iMacPro,
        NotDetected
    }
}