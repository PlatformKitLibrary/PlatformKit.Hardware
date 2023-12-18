/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

namespace PlatformKit.Hardware.Components{
    /// <summary>
    /// A class to store gpu information.
    /// </summary>
    public class GraphicsProcessorModel : HardwareComponentModel{
        public int NumberOfStreamProcessors { get; set; }
        public int NumberOfTextureMappingUnits { get; set; }
        public int NumberOfRasterOperatingUnits { get; set; }
        
        public int NumberOfComputeUnits { get; set; }
        
        //public GraphicsApiSupport GraphicsApiSupport { get; set; }
        
        public string ArchitectureName { get; set; }
        
        // ReSharper disable once InconsistentNaming
        public int L2CacheSizeMB { get; set; }
        // ReSharper disable once InconsistentNaming
        public int L1CacheSizeKB { get; set; }

        public string GraphicsProcessorModelName { get; set; }
        
        public SoftwareComponentModel Driver { get; set; }
        
        public string MaxRefreshRate { get; set; }
        public string MinRefreshRate { get; set; }

        public MemoryModel VideoMemory { get; set; }
        
        public string VideoModeDescription { get; set; }
        
        public string VideoMode { get; set; }
        public string VideoArchitecture { get; set; }
        
        public int BaseClockSpeedMHz { get; set; }
        public int BoostClockSpeedMHz { get; set; }
        
        public string FabricationProcess { get; set; }
    }
}