using System.Globalization;

namespace InfinityCode.RealWorldTerrain
{
    public static class RealWorldTerrainCultureInfo
    {
        public static CultureInfo cultureInfo
        {
            get { return CultureInfo.InvariantCulture; }
        }

        public static NumberFormatInfo numberFormat
        {
            get { return cultureInfo.NumberFormat; }
        }
    }
}