﻿using ILGPU;
using SixLabors.ImageSharp.PixelFormats;

namespace Magimage.Shaders
{
    public static class BlackAndWhiteByGreenPixelShader
    {
        public static void PerformShading(Index index, ArrayView<Rgba32> image)
        {
            byte pixelBrightness = image[index].B;

            image[index] = new Rgba32
            {
                R = pixelBrightness,
                G = pixelBrightness,
                B = pixelBrightness,
                A = pixelBrightness
            };
        }
    }
}
