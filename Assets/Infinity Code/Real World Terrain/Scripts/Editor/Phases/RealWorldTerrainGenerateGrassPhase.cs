/*     INFINITY CODE 2013-2018      */
/*   http://www.infinity-code.com   */

using InfinityCode.RealWorldTerrain.Generators;
using InfinityCode.RealWorldTerrain.Windows;

namespace InfinityCode.RealWorldTerrain.Phases
{
    public class RealWorldTerrainGenerateGrassPhase : RealWorldTerrainPhase
    {
        public override string title
        {
            get { return "Generate Grass..."; }
        }

        public override void Enter()
        {
            if (prefs.grassEngine == "Standard") RealWorldTerrainGrassGenerator.Generate(RealWorldTerrainWindow.container);
#if VOLUMEGRASS
            else if (prefs.grassEngine == "Volume Grass") RealWorldTerrainVolumeGrassGenerator.Generate(RealWorldTerrainWindow.container);
#endif

            progress = phaseProgress;
            if (phaseComplete) Complete();
        }
    }
}