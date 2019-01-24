/*     INFINITY CODE 2013-2018      */
/*   http://www.infinity-code.com   */

namespace InfinityCode.RealWorldTerrain
{
    public enum RealWorldTerrainBuildRCollider
    {
        none,
        simple,
        complex
    }

    public enum RealWorldTerrainBuildRRenderMode
    {
        full,
        lowDetail,
        box
    }

    public enum RealWorldTerrainBuildR2Collider
    {
        none,
        primitive,
        simple,
        complex
    }

    public enum RealWorldTerrainBuildR2RenderMode
    {
        none,
        box,
        simple,
        full
    }

    public enum RealWorldTerrainBuildingType
    {
        house,
        wall
    }

    public enum RealWorldTerrainByteOrder
    {
        Windows,
        Mac
    }

    public enum RealWorldTerrainElevationProvider
    {
        SRTM,
        BingMaps,
        SRTM30,
        Mapbox
    }

    public enum RealWorldTerrainElevationRange
    {
        autoDetect,
        fixedValue,
        realWorldValue
    }

    public enum RealWorldTerrainElevationType
    {
        realWorld,
        heightmap
    }

    public enum RealWorldTerrainGenerateBuildingPhaseEnum
    {
        house,
        wall
    }

    public enum RealWorldTerrainGenerateType
    {
        full,
        terrain,
        texture,
        additional
    }

    public enum RealWorldTerrainMaxElevation
    {
        autoDetect,
        realWorldValue
    }

    public enum RealWorldTerrainRawType
    {
        RAW,
        mapboxRGB
    }

    public enum RealWorldTerrainResultType
    {
        terrain,
        mesh,
        gaiaStamp,
        rawFile
    }

    public enum RealWorldTerrainRoadType
    {
        motorway,
        trunk,
        primary,
        secondary,
        tertiary,
        unclassified,
        residential,
        service,
        motorway_link,
        trunk_link,
        primary_link,
        secondary_link,
        tertiary_link,
        living_street,
        pedestrian,
        track,
        bus_guideway,
        raceway,
        road,
        footway,
        cycleway,
        bridleway,
        steps,
        path
    }

    /// <summary>
    /// Type of building roof.
    /// </summary>
    public enum RealWorldTerrainRoofType
    {
        /// <summary>
        /// Dome roof.
        /// </summary>
        dome,

        /// <summary>
        /// Flat roof.
        /// </summary>
        flat
    }

    public enum RealWorldTerrainTextureFileType
    {
        png,
        jpg
    }

    public enum RealWorldTerrainTextureProvider
    {
        arcGIS,
        google,
        mapQuest,
        nokia,
        virtualEarth,
        openStreetMap,
        custom = 999
    }

    public enum RealWorldTerrainTextureType
    {
        satellite,
        terrain,
        relief
    }

    public enum RealWorldTerrainUpdateType
    {
        all,
        alpha,
        beta,
        releaseCandidate,
        stable
    }

    public enum RealWorldTerrainVolumeGrassOutsidePoints
    {
        removeOutsidePoints,
        noMakeAllMeshes,
        noMakeMeshesWithOutsidePoints
    }
}