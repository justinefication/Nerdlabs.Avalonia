﻿/*
 * Based on Raffael Zica's MessageBoxSlim.Avalonia
 * 
 * Copyright (C) 2021  Alexis Justine Ang.
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 *
 * You should have received a copy of the GNU Affero General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;

using Avalonia;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace Nerdlabs.Avalonia.Extension
{
    public static class BitmapFactory
    {
        public static Bitmap Load(Uri uri)
        {
            return new Bitmap(
                AvaloniaLocator
                    .Current
                    .GetService<IAssetLoader>()
                    .Open(uri)
            );
        }

        public static Bitmap Load(string uri)
        {
            return new Bitmap(
                AvaloniaLocator
                    .Current
                    .GetService<IAssetLoader>()
                    .Open(new Uri(uri))
            );
        }
    }
}