/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

namespace PlatformKit.Hardware.Components
{
    public class ColorGamutModel
    {
        
        // ReSharper disable once InconsistentNaming
        public int PercentageOf_sRGB_Support { get; set; }
        public int PercentageOfAdobeRgbSupport { get; set; }
        public int PercentageOfDciP3Support { get; set; }
        
        public bool SupportsHdr { get; set; }
    }
}