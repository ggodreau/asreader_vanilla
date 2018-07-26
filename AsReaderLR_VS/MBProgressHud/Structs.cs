namespace MBProgressHud
{
    public enum MBProgressHUDMode : uint
    {
        Indeterminate,
        Determinate,
        DeterminateHorizontalBar,
        AnnularDeterminate,
        CustomView,
        Text
    }

    public enum MBProgressHUDAnimation : uint
    {
        Fade,
        Zoom,
        ZoomOut = Zoom,
        ZoomIn
    }
}