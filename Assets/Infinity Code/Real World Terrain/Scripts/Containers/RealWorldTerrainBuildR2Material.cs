/*     INFINITY CODE 2013-2018      */
/*   http://www.infinity-code.com   */

#if BUILDR2
using System.Collections.Generic;
using BuildR2;
#endif

namespace InfinityCode.RealWorldTerrain
{
#if BUILDR2
    public class RealWorldTerrainBuildR2Material
    {
        public Facade applyFacade;
        public Surface roofSurface;
        public Roof.Types roofType = Roof.Types.Flat;
        public List<Facade> facades;
    }
#endif
}