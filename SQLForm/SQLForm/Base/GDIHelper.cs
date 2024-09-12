using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.Runtime.InteropServices;
using System.IO;
using OpenCvSharp.Extensions;
using System.Windows.Forms.VisualStyles;

namespace SQLForm.Base
{
    public static class GDIHelper
    {
        public static Bitmap GrayPic(Bitmap bitmap)
        {
            Bitmap grayPic = new Bitmap(bitmap.Width, bitmap.Height);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    int grayValue = (int)(0.299 * color.R + 0.587 * color.G + 0.114 * color.B);
                    //int grayValue = (color.R + color.G + color.B) / 3;
                    grayPic.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue));
                }
            }
            return grayPic;
        }


        public static Bitmap ConvertBitmapToSketch(Bitmap bitmap)
        {
            // 将Bitmap转换为Mat
            using (Mat srcMat = bitmap.ToMat())
            {
                // 灰度化
                Mat grayMat = new Mat();
                Cv2.CvtColor(srcMat, grayMat, ColorConversionCodes.BGR2GRAY);

                // 高斯模糊降噪
                Mat blurredMat = new Mat();
                Cv2.GaussianBlur(grayMat, blurredMat, new OpenCvSharp.Size(5, 5), 0);

                // Canny边缘检测
                Mat edgesMat = new Mat();
                Cv2.Canny(blurredMat, edgesMat, 100, 200);

                // 创建一个与原图尺寸相同的全白图像
                Mat whiteBackground = new Mat(srcMat.Size(), MatType.CV_8UC3, Scalar.White);
                // 合成素描效果：将边缘图与白色背景进行组合，确保边缘为黑色，背景为白色
                // 注意，直接使用或运算可能不直接产生预期的白底黑线效果，这里需要更精确地处理
                Mat sketchMat = whiteBackground.Clone();
                // 反转边缘图颜色，确保边缘为黑色
                Cv2.BitwiseNot(edgesMat, edgesMat);
                // 将处理后的Mat转换回Bitmap
                return edgesMat.ToBitmap();
            }
        }
    }
}
