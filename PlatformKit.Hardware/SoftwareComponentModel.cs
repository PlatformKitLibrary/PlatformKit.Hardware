/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */


namespace PlatformKit.Hardware{
    /// <summary>
    /// A class to help store software component information.
    /// </summary>
    public class SoftwareComponentModel : ComponentModel{

        public bool IsProprietary { get; set; }
        public bool Is64Bit { get; set; }
        
        public Version SoftwareVersion { get; set; }

        public string Developer { get; set; }
        public string Publisher { get; set; }
    }
}