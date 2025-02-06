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
    /// A class to store Processor Information.
    /// </summary>
    public class ProcessorModel : HardwareComponentModel{

        public ProcessorModel() : base()
        {
        }
        
        public string ProcessorName { get; set; }

        public string Stepping { get; set; }
        public string CPUFamily { get; set; }
        public string Revision { get; set; }

        public bool SupportsVirtualization { get; set; }
        
        public double ThermalDesignPowerWatts { get; set; }
        
        public string Socket { get; set; }
        public string ProcessorFamilyDescription { get; set; }
        
        public string NominalClockSpeed { get; set; }
        public string NominalVoltage { get; set; }
        
        public int L3CacheSizeMB { get; set; }
        public int L2CacheSizeKB { get; set; }
        
        public string FabricationProcess { get; set; }
        public string ArchitectureName { get; set; }
        
        public int BaseClockSpeedMHz { get; set; }
        public int BoostClockSpeedMHz { get; set; }
        
        public int CoreCount { get; set; }
        public int ThreadCount { get; set; }
        
#if NET5_0_OR_GREATER
        [SupportedOSPlatform("windows")]        
#endif
        protected override void DetectWindows()
        {
            ProcessorName = WMISearcher.GetWMIValue("Name", "Win32_Processor");
            CoreCount = int.Parse(WMISearcher.GetWMIValue("NumberOfCores", "Win32_Processor"));
            ThreadCount = int.Parse(WMISearcher.GetWMIValue("ThreadCount", "Win32_Processor"));
            //processorModel Nominal clockspeed

            BoostClockSpeedMHz = int.Parse(WMISearcher.GetWMIValue("MaxClockSpeed", "Win32_Processor"));

            ArchitectureName = WMISearcher.GetWMIValue("Architecture", "Win32_Processor");
            CPUFamily = WMISearcher.GetWMIValue("Family", "Win32_Processor");
            ProcessorFamilyDescription = WMISearcher.GetWMIValue("OtherFamilyDescription", "Win32_Processor");

            L2CacheSizeKB = int.Parse(WMISearcher.GetWMIValue("L2CacheSize", "Win32_Processor"));
            L3CacheSizeMB = int.Parse(WMISearcher.GetWMIValue("L3CacheSize", "Win32_Processor")) / 1024;

            Socket = WMISearcher.GetWMIValue("SocketDesignation", "Win32_Processor");
            Revision = WMISearcher.GetWMIValue("Revision", "Win32_Processor");

            SupportsVirtualization =
                bool.Parse(WMISearcher.GetWMIValue("VirtualizationFirmwareEnabled", "Win32_Processor"));

        }
    }
}