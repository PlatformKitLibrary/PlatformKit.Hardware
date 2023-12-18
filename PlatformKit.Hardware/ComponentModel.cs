/*
      PlatformKit.Hardware
      
      Copyright (c) Alastair Lundy 2023
      
      This Source Code Form is subject to the terms of the Mozilla Public
      License, v. 2.0. If a copy of the MPL was not distributed with this
      file, You can obtain one at http://mozilla.org/MPL/2.0/.
   */

using PlatformKit.Mac;
using PlatformKit.Windows;

namespace PlatformKit.Hardware
{
    public abstract class ComponentModel : ManufactureInformation
    {
        protected WindowsAnalyzer _windowsAnalyzer;
        protected MacOSAnalyzer _macOsAnalyzer;

        public ComponentModel()
        {
            _windowsAnalyzer = new WindowsAnalyzer();
            _macOsAnalyzer = new MacOSAnalyzer();
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
            if (OSAnalyzer.IsWindows())
            {
                DetectWindows();
            }
            else if (OSAnalyzer.IsMac())
            {
                 DetectMac();
            }
            else if (OSAnalyzer.IsLinux())
            {
                 DetectLinux();
            }

            throw new PlatformNotSupportedException();
        }
    }
}