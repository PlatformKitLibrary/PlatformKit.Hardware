/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

using System;

namespace PlatformKit.Hardware
{
    public class ManufactureInformation
    {
        public string ManufacturerName { get; set; }
        
        public string ProductName { get; set; }

        public string Description { get; set; }

        protected Version ComponentVersion { get; set; }
    }
}