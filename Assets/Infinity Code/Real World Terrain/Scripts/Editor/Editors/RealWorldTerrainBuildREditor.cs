/*     INFINITY CODE 2013-2018      */
/*   http://www.infinity-code.com   */

using UnityEditor;
using UnityEngine;

namespace InfinityCode.RealWorldTerrain.Editors
{
    [CustomEditor(typeof(RealWorldTerrainBuildRBuilding))]
    public class RealWorldTerrainBuildREditor : Editor
    {
        public override void OnInspectorGUI()
        {
            if (GUILayout.Button("Invert normals"))
            {
#if BUILDR
                RealWorldTerrainBuildRBuilding t = (RealWorldTerrainBuildRBuilding)target;
                BuildrEditMode editMode = t.GetComponent<BuildrEditMode>();
                editMode.data.plan.volumes[0].points.Reverse();
                editMode.UpdateRender(BuildrEditMode.renderModes.full);
                editMode.stage = BuildrEditMode.stages.facades;
#endif
            }
        }
    }
}