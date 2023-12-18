/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

using System;

namespace PlatformKit.Hardware.Components
{
    public class DisplayResolutionModel
    {
        public int VerticalResolutionPx { get; set; }
        public int HorizontalResolutionPx { get; set; }

        public int TotalPixelsPx => VerticalResolutionPx * HorizontalResolutionPx;
        
        public double DisplaySizeInches { get; set; }
        
        public bool IsHiDpi { get; set; }

        public double PixelsPerInch => DiagonalResolutionPx / DisplaySizeInches;
        
        public double DiagonalResolutionPx
        {
            get
            {
                try
                {
                    return Math.Sqrt(Convert.ToDouble((VerticalResolutionPx * VerticalResolutionPx) +
                                                      (HorizontalResolutionPx * HorizontalResolutionPx)));
                }
                catch
                {
                    throw new ArgumentNullException();
                }
               
            }
        }

        public double DotPitchMillimeters => (DisplaySizeInches / DiagonalResolutionPx) * (25.4 / DisplaySizeInches);
    }
}