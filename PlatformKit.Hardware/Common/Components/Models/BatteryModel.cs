/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

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

        protected override void DetectWindows()
        {
            ExpectedBatteryLife = _windowsAnalyzer.GetWMIValue("ExpectedBatteryLife", "Win32_Battery");
            FullCapacityCharge = _windowsAnalyzer.GetWMIValue("FullChargeCapacity", "Win32_Battery");
            EstimatedRunTime = _windowsAnalyzer.GetWMIValue("EstimatedRunTime", "Win32_Battery");
            TimeToFullCharge = _windowsAnalyzer.GetWMIValue("TimeToFullCharge", "Win32_Battery");
            MaxRechargeTime = _windowsAnalyzer.GetWMIValue("MaxRechargeTime", "Win32_Battery");
            Status = _windowsAnalyzer.GetWMIValue("Status", "Win32_Battery");
            Name = _windowsAnalyzer.GetWMIValue("Name", "Win32_Battery");
        }
    }
}