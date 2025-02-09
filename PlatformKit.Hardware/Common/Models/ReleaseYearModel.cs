/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2022-2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

namespace PlatformKit.Hardware
{
    /// <summary>
    /// 
    /// </summary>
    public class ReleaseYearModel
    {
        public int Month { get; set; }
        public int Year { get; set; }

        public ReleaseYearTimeframe Timeframe { get; set; }
    }
}