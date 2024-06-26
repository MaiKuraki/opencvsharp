﻿#pragma warning disable CA1008 // Enums should have zero value

namespace OpenCvSharp;

/// <summary>
/// Miscellaneous flags for cv::kmeans
/// </summary>
[Flags]
public enum KMeansFlags
{
    /// <summary>
    /// Select random initial centers in each attempt.
    /// </summary>
    RandomCenters = 0,

    /// <summary>
    /// Use kmeans++ center initialization by Arthur and Vassilvitskii [Arthur2007].
    /// </summary>
    PpCenters = 2,

    /// <summary>
    /// During the first (and possibly the only) attempt, use the
    /// user-supplied labels instead of computing them from the initial centers. 
    /// For the second and further attempts, use the random or semi-random centers. 
    /// Use one of KMEANS_\*_CENTERS flag to specify the exact method.
    /// </summary>
    UseInitialLabels = 1,
}
