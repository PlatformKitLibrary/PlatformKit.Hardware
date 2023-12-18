/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

// ReSharper disable once CheckNamespace
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

        protected override void DetectWindows()
        {
            DisplayResolution.VerticalResolutionPx = int.Parse(_windowsAnalyzer.GetWMIValue("CurrentVerticalResolution", "Win32_VideoController"));
            DisplayResolution.HorizontalResolutionPx = int.Parse(_windowsAnalyzer.GetWMIValue("CurrentHorizontalResolution", "Win32_VideoController"));
            DisplayResolution.IsHiDpi = DisplayResolution.PixelsPerInch >= 200;
            
            MaximumRefreshRateHz = int.Parse(_windowsAnalyzer.GetWMIValue("MaxRefreshRate", "Win32_VideoController"));
            MinimumRefreshRateHz = int.Parse(_windowsAnalyzer.GetWMIValue("MinRefreshRate", "Win32_VideoController"));
            CurrentRefreshRateHz = int.Parse(_windowsAnalyzer.GetWMIValue("CurrentRefreshRate", "Win32_VideoController"));
        }
    }
}