namespace DIP_ClassLib
{
    public enum Process
    {
        Inverse,
        Brighten,
        Darken,
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
        Pos45DegreeLine,
        EqualisedHistogram
    }
}