/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

using System.Runtime.Versioning;

using PlatformKit.Mac;

namespace PlatformKit.Hardware.Mac
{
    public class MacHardwareModel
    {
        public string MacDescription { get; set; }

        public string SerialNumber { get; set; }
    
        public string ProcessorDescription { get; set; }
    
        public string MemoryDescription { get; set; }
    
        public string StartupDiskDescription { get; set; }
    
        public string GraphicsProcessorDescription { get; set; }
    
        public MacDisplayModel MacDisplayModel { get; set; }

        /// <summary>
        /// Detects the MacHardwareModel information from macOS System Profiler
        /// </summary>
#if NET5_0_OR_GREATER
    [SupportedOSPlatform("macos")]        
#endif
        public void Detect()
        {
            MacOsAnalyzer macOsAnalyzer = new MacOsAnalyzer();

            MacDescription =
                MacOsAnalyzer.GetMacSystemProfilerInformation(MacSystemProfilerDataType.HardwareDataType, "Model Name");
            ProcessorDescription =
                MacOsAnalyzer.GetMacSystemProfilerInformation(MacSystemProfilerDataType.HardwareDataType, "Processor Name");
            SerialNumber =
                MacOsAnalyzer.GetMacSystemProfilerInformation(MacSystemProfilerDataType.HardwareDataType,
                    "Serial Number (system)");
            //GraphicsProcessorDescription = 
            //StartupDiskDescription = 
            //MacDisplayModel = 
        }
    }
}