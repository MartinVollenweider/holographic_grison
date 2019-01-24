using UnityEngine;
using System.Collections;
using InfinityCode.RealWorldTerrain;

public class RenderLine : MonoBehaviour
{
    public RealWorldTerrainContainer container;
    public int numCapVertices = 0;
    public int numCornerVertices = 0;
   
    public Color c1 = Color.yellow;
    public Color c2 = Color.red;
    // public int lengthOfLineRenderer = 8;
    private LineRenderer lineRenderer;
    private double[,] coords =  {
          {
            9.638537,
            46.7893663
          },
          {
            9.6386267,
            46.7894976
          },
          {
            9.638848,
            46.7897616
          },
          {
            9.6391699,
            46.789679
          },
          {
            9.6391672,
            46.7899838
          },
          {
            9.6389043,
            46.7902428
          },
          {
            9.6383625,
            46.7904503
          },
          {
            9.6379092,
            46.7904668
          },
          {
            9.6375391,
            46.790408
          },
          {
            9.6374586,
            46.7904742
          },
          {
            9.6375364,
            46.790566
          },
          {
            9.6383089,
            46.7909461
          },
          {
            9.6390768,
            46.7911556
          },
          {
            9.6393826,
            46.7912654
          },
          {
            9.6397516,
            46.7913579
          },
          {
            9.6399665,
            46.7916586
          },
          {
            9.6401221,
            46.7919855
          },
          {
            9.6407873,
            46.7923436
          },
          {
            9.6421867,
            46.7929281
          },
          {
            9.642404,
            46.7930888
          },
          {
            9.6423779,
            46.7932078
          },
          {
            9.642178,
            46.7935232
          },
          {
                            9.6421432,
            46.7937315
          },
          {
            9.6422215,
            46.7938207
          },
          {
            9.6427761,
            46.7939278
          },
          {
            9.6436646,
            46.7939407
          },
          {
            9.6446287,
            46.7936301
           },
          {
            9.6450823,
            46.7934239
           },
                                 {
            9.64544,
            46.793416
            },
        {
            9.6457385,
            46.7935288
            },
        {
            9.6458459,
            46.7939669
            },
        {
            9.6462536,
            46.7940496
            },
        {
            9.6469197,
            46.793862
            },
        {
            9.6475381,
            46.7937749
            },
        {
            9.6478764,
            46.7935797
            },
        {
            9.6485318,
            46.7923271
            },
        {
            9.6496531,
            46.7914463
            },
        {
            9.6500703,
            46.791244
            },
        {
            9.6501051,
            46.7909941
            },
        {
            9.6496183,
            46.7903394
            },
        {
            9.6495836,
            46.789911
            },
        {
            9.6504875,
            46.7886969
            },
        {
            9.6513822,
            46.7877971
            },
        {
            9.6517479,
            46.7874293
            },
        {
            9.6527301,
            46.7866139
            },
        {
            9.6560506,
            46.7857473
            },
        {
            9.6582343,
            46.785574
            },
        {
            9.6590353,
            46.7855104
        },
        {
            9.6608843,
            46.7853478
            },
        {
            9.6625237,
            46.7849156
            },
        {
            9.66231,
            46.7842984
            },
        {
            9.6610566,
            46.7833531
                },
        {
            9.6599319,
            46.7820872
            }
    };


    void Start()
    {

		//transform.localScale.Scale (new Vector3 (0.1f, 0.1f, 0.1f));
		transform.position.Set(0,0,0);
         lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Particles/Standard Unlit"));
        lineRenderer.SetColors(c1, c2);
        lineRenderer.SetWidth(0.01F, 0.01F);
        lineRenderer.SetVertexCount(coords.GetLength(0));

      

        //LineRenderer lineRenderer = GetComponent<LineRenderer>();
        Vector3[] points = new Vector3[coords.GetLength(0)];
        //Debug.Log(coords.GetLength(0));
        //Debug.Log(coords[53, 0] + " , " + coords[53, 1]);
        for (int i = 0; i < coords.GetLength(0); i++)
        {
            //Debug.Log(i);

            double lon = coords[i, 0];
            double lat = coords[i, 1];
           // Debug.Log(coords[i, 0]);
            Vector3 pos = new Vector3();
            container.GetWorldPosition(lon, lat, out pos);
            pos.y += 0.01f;
            points[i] = pos;
        }

        //float t = Time.time;
        //int i = 0;
        //while (i < lengthOfLineRenderer)
        //{
        //    points[i] = new Vector3(i * 0.5F, Mathf.Sin(i + t), 0);
        //    i++;
        //}
        lineRenderer.SetPositions(points);
        lineRenderer.alignment = LineAlignment.View;
    }
    void Update()
    {

        lineRenderer.numCapVertices = numCapVertices;
        lineRenderer.numCornerVertices = numCornerVertices;
        //Vector3 p1 = new Vector3(9.638442555664028f, 46.790664176219366f, 0);
        //Vector3 p2 = new Vector3(9.66213182568356f, 46.79089923707998f, 0);
        //Vector3 p3 = new Vector3(9.66213182568356f, 46.78666798451775f, 0);
        //Vector3 p4 = new Vector3(9.664191762206997f, 46.779380047611795f, 0);
        //Vector3 p5 = new Vector3(9.664191762206997f, 46.779380047611795f, 0);
        //Vector3 p6 = new Vector3(9.676551381347622f, 46.77679376833296f, 0);
        //Vector3 p7 = new Vector3(9.682731190917934f, 46.78149600189765f, 0);
        //Vector3 p8 = new Vector3(9.69131425976559f, 46.781731102796286f, 0);
        //Vector3 p9 = new Vector3(9.694404164550747f, 46.779380047611795f, 0);

        //Vector3[] coords = { p1, p2, p3, p4, p5, p6, p7, p8, p9 };




        //LineRenderer lineRenderer = GetComponent<LineRenderer>();
        //Vector3[] points = new Vector3[coords.Length];

        //for (int i = 0; i < coords.Length; i++){
        //    double lon = coords[i,0];
        //    double lat = coords[i, 1];
        //    Vector3 pos = new Vector3();
        //    container.GetWorldPosition(lon,lat, out pos);
        //    points[i] = pos;
        //}

        ////float t = Time.time;
        ////int i = 0;
        ////while (i < lengthOfLineRenderer)
        ////{
        ////    points[i] = new Vector3(i * 0.5F, Mathf.Sin(i + t), 0);
        ////    i++;
        ////}
        //lineRenderer.SetPositions(points);
    }
}