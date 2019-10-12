using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MyImage : MonoBehaviour {

    VertexHelper vertexHelper = new VertexHelper();
    private Mesh mesh;
    public Camera camera;
    public Color color;
    private MeshFilter meshFilter;
    public Texture2D texture;

    public MeshFilter Meshfileter {
        get {
            if (meshFilter==null)
            {
                meshFilter = GetComponent<MeshFilter>();
            }
            return meshFilter;
        }
    }

    private MeshCollider meshcollider;
    private MeshCollider meshCollider {
        get {
            if (meshcollider==null)
            {
                meshcollider = GetComponent<MeshCollider>();
            }
            return meshcollider;
        }
    }
    private MeshRenderer meshrender;
    public MeshRenderer Meshrender
    {
        get
        {
            if (meshrender == null)
            {
                meshrender = GetComponent<MeshRenderer>();
            }
            return meshrender;
        }
    }

    // Use this for initialization
    void Start () {
        InitMesh();

    }
	
	// Update is called once per frame
	void Update () {
        var ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            if (hit.collider!=null && hit.collider.gameObject!=null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Image click");
                }
            }
        }
        Debug.DrawLine(ray.origin, ray.origin + ray.direction*100, Color.red);

        Meshrender.material.color = color;
        Meshrender.material.mainTexture = texture;

    }

    private void InitMesh()
    {
        mesh = new Mesh();
        vertexHelper.Clear();
        vertexHelper.AddVert(new Vector2(0, 0), color, new Vector2(0, 0));
        vertexHelper.AddVert(new Vector2(0, 1), color, new Vector2(0, 1));
        vertexHelper.AddVert(new Vector2(1, 1), color, new Vector2(1, 1));
        vertexHelper.AddVert(new Vector2(1, 0), color, new Vector2(1, 0));

        vertexHelper.AddTriangle(0, 1, 2);
        vertexHelper.AddTriangle(2, 3, 0);
        vertexHelper.FillMesh(mesh);
        Meshfileter.mesh = mesh;
        meshCollider.sharedMesh = mesh;
    }
}
