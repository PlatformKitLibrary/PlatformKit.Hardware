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
    /// 
    /// </summary>
    public class BatteryModel : HardwareComponentModel
    {

        public BatteryModel() : base()
        {
            
        }
        
        public string Name { get; set; }
        
        public string ExpectedBatteryLife { get; set; }
        public string FullCapacityCharge { get; set; }

        public string EstimatedRunTime { get; set; }
        
        public string MaxRechargeTime { get; set; }
        public string TimeToFullCharge { get; set; }
        
        public string Status { get; set; }

#if NET5_0_OR_GREATER
        [SupportedOSPlatform("windows")]
 #endif
        protected override void DetectWindows()
        {
            ExpectedBatteryLife = WMISearcher.GetWMIValue("ExpectedBatteryLife", "Win32_Battery");
            FullCapacityCharge = WMISearcher.GetWMIValue("FullChargeCapacity", "Win32_Battery");
            EstimatedRunTime = WMISearcher.GetWMIValue("EstimatedRunTime", "Win32_Battery");
            TimeToFullCharge = WMISearcher.GetWMIValue("TimeToFullCharge", "Win32_Battery");
            MaxRechargeTime = WMISearcher.GetWMIValue("MaxRechargeTime", "Win32_Battery");
            Status = WMISearcher.GetWMIValue("Status", "Win32_Battery");
            Name = WMISearcher.GetWMIValue("Name", "Win32_Battery");
        }
    }
}