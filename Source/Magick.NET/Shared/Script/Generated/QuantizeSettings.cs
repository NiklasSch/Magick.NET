//=================================================================================================
// Copyright 2013-2017 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================
// <auto-generated/>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick
{
    public sealed partial class MagickScript
    {
        private QuantizeSettings CreateQuantizeSettings(XmlElement element)
        {
            if (element == null)
                return null;
            QuantizeSettings result = new QuantizeSettings();
            result.Colors = Variables.GetValue<Int32>(element, "colors");
            result.ColorSpace = Variables.GetValue<ColorSpace>(element, "colorSpace");
            result.DitherMethod = Variables.GetValue<Nullable<DitherMethod>>(element, "ditherMethod");
            result.MeasureErrors = Variables.GetValue<Boolean>(element, "measureErrors");
            result.TreeDepth = Variables.GetValue<Int32>(element, "treeDepth");
            return result;
        }
    }
}
