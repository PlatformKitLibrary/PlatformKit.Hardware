/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

using System.Runtime.Versioning;
using PlatformKit.Windows;

namespace PlatformKit.Hardware.Components{

    /// <summary>
    /// A class to store Memory Information.
    /// </summary>
    public class MemoryModel : HardwareComponentModel
    {
        public MemoryModel() : base()
        {
            
        }
        
        public int AvailablePhysicalRamMB { get; set; }
        public int AvailablePhysicalRamGB => AvailablePhysicalRamMB / 1000;

        public int TotalPhysicalRamMB { get; set; }
        public int TotalPhysicalRamGB => TotalPhysicalRamMB / 1000;

        
        public int AvailableVirtualRamMB { get; set; }
        public int AvailableVirtualRamGB => AvailableVirtualRamMB / 1000;

        public int TotalVirtualRamMB { get; set; }
        public int TotalVirtualRamGB => TotalVirtualRamMB / 1000;
        
        public int MemorySpeedMHz { get; set; }

        public int MinVoltageMillivolts { get; set; }
        public int MaxVoltageMillivolts { get; set; }

#if NET5_0_OR_GREATER
        [SupportedOSPlatform("windows")]        
#endif
        protected override void DetectWindows()
        {
            var windowsSystemInfo = WindowsAnalyzer.GetWindowsSystemInformation();
            
            TotalPhysicalRamMB = windowsSystemInfo.TotalPhysicalMemoryMB;
            AvailablePhysicalRamMB = windowsSystemInfo.AvailablePhysicalMemoryMB;
            AvailableVirtualRamMB = windowsSystemInfo.VirtualMemoryAvailableSizeMB;
            TotalVirtualRamMB = windowsSystemInfo.VirtualMemoryMaxSizeMB;
            
            //Get all other MemoryModel values from WMI
            MinVoltageMillivolts = int.Parse(WMISearcher.GetWMIValue("MinVoltage", "Win32_PhysicalMemory"));
            MaxVoltageMillivolts = int.Parse(WMISearcher.GetWMIValue("MaxVoltage", "Win32_PhysicalMemory"));
            MemorySpeedMHz = int.Parse(WMISearcher.GetWMIValue("ConfiguredClockSpeed", "Win32_PhysicalMemory"));
        }
    }
}