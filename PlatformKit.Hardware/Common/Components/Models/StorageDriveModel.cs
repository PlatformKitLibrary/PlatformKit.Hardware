/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

namespace PlatformKit.Hardware.Components{

    /// <summary>
    /// A class to help store Storage Drive Information.
    /// </summary>
    public class StorageDriveModel : HardwareComponentModel{
        public int? TotalTBWritten { get; set; }
        public int? TotalTBRead { get; set; }

        public StorageDriveType? DriveType { get; set; }
        public int? CapacityGB { get; set; }
        public int? CapacityTB => CapacityGB / 1000;
    }
}