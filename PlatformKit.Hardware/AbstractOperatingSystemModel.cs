/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

namespace PlatformKit.Hardware{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractOperatingSystemModel : SoftwareComponentModel{

        public string EncryptionLevel { get; set; }
        public string Locale { get; set; }
        public string InstallDate { get; set; }
        
        public bool IsPaeEnabled { get; set; }
        
        public string SystemDrive { get; set; }
        public string SystemDirectory { get; set; }
        
        public System.Version OsKernelVersion { get; set; }

        public object Owner { get; set; }
        public string BootDevice { get; set; }
        
        public string CountryCode { get; set; }
        public string CurrentTimeZone { get; set; }

        public KernelSupportType OsKernelSupportType { get; set; }
        
        public System.Version OsVersion { get; set; }
    }
}