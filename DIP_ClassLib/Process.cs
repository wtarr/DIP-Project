namespace DIP_ClassLib
{
    public enum Process
    {
        Binarize,
        NeibhourhoodAveraging,
        NeibhourhoodAveragingWithThresholding,
        MedianFiltering,
        RobertsGradientWithThresholding,
        RobertsGradientWithPseudoColor,
        RobertsGradientDirect,
        SobelGx,
        SobelGy,
        SobelGxGy,
        Sobel45,
        Laplacian,
        PointDetection,
        HorizontalLine,
        VerticalLine, 
        Negative45DegreeLine,
        Pos45DegreeLine
    }
}