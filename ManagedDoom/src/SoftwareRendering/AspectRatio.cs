//
// Copyright (C) 2019-2021 Nobuaki Tanaka
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//



using System;
using System.Collections.Generic;

namespace ManagedDoom.SoftwareRendering
{
    public enum AspectRatio
    {
        FitScreen,
        FourThree,
        EightFive
    }

    public static class AspectRatioEx
    {
        public static AspectRatio Parse(string value)
        {
            switch (value)
            {
                case "4:3":
                    return AspectRatio.FourThree;
                case "8:5":
                    return AspectRatio.EightFive;
                case "16:10":
                    return AspectRatio.EightFive;
                default:
                    return AspectRatio.FitScreen;
            }
        }

        public static string ToString(AspectRatio value)
        {
            switch (value)
            {
                case AspectRatio.FourThree:
                    return "4:3";
                case AspectRatio.EightFive:
                    return "8:5";
                default:
                    return "fitscreen";
            }
        }
    }
}
