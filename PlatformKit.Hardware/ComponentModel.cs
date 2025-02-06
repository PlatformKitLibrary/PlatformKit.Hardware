/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

using System;
using PlatformKit.Mac;
using PlatformKit.Windows;

#if NETSTANDARD2_0 || NETSTANDARD2_1
using OperatingSystem = Polyfills.OperatingSystemPolyfill;
#endif

namespace PlatformKit.Hardware
{
    public abstract class ComponentModel : ManufactureInformation
    {
        protected WindowsAnalyzer _windowsAnalyzer;
        protected MacOsAnalyzer _macOsAnalyzer;
        
        protected WMISearcher _wmiSearcher;

        public ComponentModel()
        {
            _windowsAnalyzer = new WindowsAnalyzer();
            _macOsAnalyzer = new MacOsAnalyzer();
            _wmiSearcher = new WMISearcher();
        }
        
        public bool CanDetectInformation { get; set; }

        protected virtual void DetectWindows()
        {
            throw new NotImplementedException();
        }

        protected virtual void DetectMac()
        {
            throw new NotImplementedException();
        }

        protected virtual void DetectLinux()
        {
            throw new NotImplementedException();
        }

        public void Detect()
        {
            if (OperatingSystem.IsWindows())
            {
                DetectWindows();
            }
            else if (OperatingSystem.IsMacOS())
            {
                 DetectMac();
            }
            else if (OperatingSystem.IsLinux())
            {
                 DetectLinux();
            }

            throw new PlatformNotSupportedException();
        }
    }
}