/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

using PlatformKit.Mac;

namespace PlatformKit.Hardware.Mac;

/// <summary>
/// A class to represent Mac models
/// </summary>
public class MacModel
{
    
    public MacHardwareModel HardwareModel { get; set; }
    
    public ReleaseYearTimeframe ReleaseTimeFrame { get; set; }
    public ReleaseYearModel ReleaseYear { get; }

    public MacDeviceFamily DeviceFamily
    {
        get
        {
            MacDeviceFamily macDeviceFamily;
            
            var hardware = new MacHardwareModel();
            hardware.Detect();

            switch (hardware.MacDescription.ToLower().Replace(" ", String.Empty))
            {
                case "macbookair":
                    macDeviceFamily = MacDeviceFamily.MacBookAir;
                    break;
                case "macbookpro":
                    macDeviceFamily = MacDeviceFamily.MacBookPro;
                    break;
                case "macbook":
                    macDeviceFamily = MacDeviceFamily.MacBook;
                    break;
                case "macmini":
                    macDeviceFamily = MacDeviceFamily.MacMini;
                    break;
                case "macstudio":
                    macDeviceFamily = MacDeviceFamily.MacStudio;
                    break;
                case "macpro":
                    macDeviceFamily = MacDeviceFamily.MacPro;
                    break;
                case "imacpro":
                    macDeviceFamily = MacDeviceFamily.iMacPro;
                    break;
                case "imac":
                    macDeviceFamily = MacDeviceFamily.iMac;
                    break;
                case "macminiserver":
                    macDeviceFamily = MacDeviceFamily.MacMiniServer;
                    break;
                default:
                    macDeviceFamily = MacDeviceFamily.NotDetected;
                    break;
            }

            return macDeviceFamily;
        }
    }

    public string MacIdentifier 
    {
        get
        {
            return macOsAnalyzer.GetMacSystemProfilerInformation(MacSystemProfilerDataType.HardwareDataType, "Model Identifier");
        }
    }
    
    public MacOsSystemInformation InstalledOperatingSystem 
    {
        get
        {
            return new MacOsSystemInformation();
        }
    }


    protected MacOSAnalyzer macOsAnalyzer;
    
    public MacModel()
    {
        macOsAnalyzer = new MacOSAnalyzer();
    }
}