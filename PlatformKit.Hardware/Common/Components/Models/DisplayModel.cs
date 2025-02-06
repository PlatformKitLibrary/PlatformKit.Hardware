/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */


using PlatformKit.Windows;
// ReSharper disable once CheckNamespace
using System.Runtime.Versioning;

namespace PlatformKit.Hardware.Components{

    /// <summary>
    /// A class to help store Display Information.
    /// </summary>
    public class DisplayModel : HardwareComponentModel
    {

        public DisplayModel() : base()
        {
        }
        
        public int CurrentRefreshRateHz { get; set; }
        
        public int MaximumRefreshRateHz { get; set; }
        public int MinimumRefreshRateHz { get; set; }

        public DisplayResolutionModel DisplayResolution { get; set; }

        public bool SupportsVariableRefreshRate { get; set; }

#if NET5_0_OR_GREATER
        [SupportedOSPlatform("windows")]        
#endif
        protected override void DetectWindows()
        {
            DisplayResolution.VerticalResolutionPx = int.Parse(WMISearcher.GetWMIValue("CurrentVerticalResolution", "Win32_VideoController"));
            DisplayResolution.HorizontalResolutionPx = int.Parse(WMISearcher.GetWMIValue("CurrentHorizontalResolution", "Win32_VideoController"));
            DisplayResolution.IsHiDpi = DisplayResolution.PixelsPerInch >= 200;
            
            MaximumRefreshRateHz = int.Parse(WMISearcher.GetWMIValue("MaxRefreshRate", "Win32_VideoController"));
            MinimumRefreshRateHz = int.Parse(WMISearcher.GetWMIValue("MinRefreshRate", "Win32_VideoController"));
            CurrentRefreshRateHz = int.Parse(WMISearcher.GetWMIValue("CurrentRefreshRate", "Win32_VideoController"));
        }
    }
}