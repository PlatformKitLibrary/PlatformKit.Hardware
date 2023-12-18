/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

namespace PlatformKit.Hardware{
    /// <summary>
    /// A class to help store hardware component information.
    /// </summary>
    public class HardwareComponentModel : ComponentModel{
        public System.DateTime DateOfManufacture { get; set; }
        public string SerialNumber { get; set; }
        
       // public List<Sensor> ListOfSensors { get; set; }
    }
}