using System.Collections.Generic;
using Avalonia.Media.Imaging;

namespace PluginCore;

public struct ScreenCaptureInfo()
{
    public int Index = 0;
    public int X = -1;
    public int Y = -1;
    public int Width = -1;
    public int Height = -1;
}

public interface IScreenCapture
{
    public (Queue<Bitmap>, Queue<Bitmap>) CaptureAllScreen();


    public (Bitmap?, Bitmap?)? CaptureScreen(ScreenCaptureInfo screenCaptureInfo, bool withMosaic = false);

    public ScreenCaptureInfo GetScreenCaptureInfoByUserManual();
}