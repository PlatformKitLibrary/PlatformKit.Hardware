/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

using PlatformKit.Windows;

namespace PlatformKit.Hardware.Windows
{
    public class WindowsOperatingSystemModel : AbstractOperatingSystemModel
    {
        public new bool IsProprietary => true;

        public WindowsEdition Edition { get; set; }
        public WindowsVersion Version { get; set; }
    
        public string ReleaseName { get; set; }
    
        public string ReleaseChannel { get; set; }
        public int BuildNumber { get; set; }
        public string ProductId { get; set; }
    }
}