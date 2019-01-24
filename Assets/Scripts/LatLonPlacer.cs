using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InfinityCode.RealWorldTerrain;

public class LatLonPlacer : MonoBehaviour {


  // private RealWorldTerrainContainer container;

	private RealWorldTerrainContainer container;

    public double lat = 46.7820872;
    public double lon = 9.6599319;
    // Use this for initialization
    void Start () {

		GameObject gameObj = GameObject.Find("Terrain");
		Debug.Log (gameObj);
		if (gameObj != null)
		{
			Debug.Log (gameObj.name);
			container = gameObj.GetComponent<RealWorldTerrainContainer>();
		}

	
        transform.position = new Vector3(2f, 0f, 0f);

        Vector3 pos = new Vector3();
        container.GetWorldPosition(lon, lat,out pos);
        Debug.Log(pos);

        transform.position = pos;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
