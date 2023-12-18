/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

using PlatformKit.Mac;

namespace PlatformKit.Hardware.Mac;

public class MacSupportStatus
{
    public bool IsOfficiallySupported { get; set; }
    
    public MacOsSystemInformation MinimumSupportedVersion { get; set; }
    
    public MacOsSystemInformation LastOfficiallySupportedVersion { get; set; }
}