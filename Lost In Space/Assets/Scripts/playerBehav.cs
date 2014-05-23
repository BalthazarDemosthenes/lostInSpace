using UnityEngine;
using System.Collections;

public class playerBehav : MonoBehaviour {
    private float lastFire= 0f;
    private const float fireRate = .1f;
    private int health;
    private int speed;
    private GameObject ammo;
	// Use this for initialization
	void Start () {
        speed = 50;
        health = 5;
        if (ammo == null)
        {
            ammo = Resources.Load("Prefabs/greenLazer") as GameObject;
        }
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal") * (speed * Time.smoothDeltaTime), 0f, 0f);
        transform.position += dir;
        Vector3 dir2 = new Vector3(Input.GetAxis("Horizontal") * (speed * Time.smoothDeltaTime), 0f, 0f);
        transform.position += dir2;
        if (Input.GetButton("Fire1") && Time.time - lastFire > fireRate)
        {
            Instantiate(ammo, new Vector3(transform.position.x, transform.position.y + 1, -.5f), Quaternion.identity);
            lastFire = Time.time;
        }
	}
}
