using UnityEngine;
using System.Collections;

public class backgroundBehav : MonoBehaviour {
    private float speed;
    private Bounds worldBound;
    private Camera mainCam;
    private Vector2 worldMin;
    private Vector2 worldMax;
    private Vector2 worldCenter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void UpdateWorldWindowBound()
    {
        if (mainCam != null)
        {
            float maxY = mainCam.orthographicSize;
            float maxX = mainCam.orthographicSize * mainCam.aspect;
            float sizeX = 2 * maxX;
            float sizeY = 2 * maxY;
            float sizeZ = Mathf.Abs(mainCam.farClipPlane - mainCam.nearClipPlane);

            Vector3 c = mainCam.transform.position;
            c.z = 0.0f;
            worldBound.center = c;
            worldBound.size = new Vector3(sizeX, sizeY, sizeZ);

            worldCenter = new Vector2(c.x, c.y);
            worldMin = new Vector2(worldBound.min.x, worldBound.min.y);
            worldMax = new Vector2(worldBound.max.x, worldBound.max.y);
        }
    }
}
