/*     INFINITY CODE 2013-2018      */
/*   http://www.infinity-code.com   */

using InfinityCode.RealWorldTerrain.Generators;
using InfinityCode.RealWorldTerrain.Windows;

namespace InfinityCode.RealWorldTerrain.Phases
{
    public class RealWorldTerrainGenerateTreesPhase : RealWorldTerrainPhase
    {
        public override string title
        {
            get { return "Generate Trees..."; }
        }

        public override void Enter()
        {
            RealWorldTerrainTreesGenerator.Generate(RealWorldTerrainWindow.container);
            progress = phaseProgress;

            if (phaseComplete) Complete();
        }
    }
}