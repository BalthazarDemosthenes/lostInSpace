using UnityEngine;
using System.Collections;

public class enemyLazer : MonoBehaviour {
    private float speed;
	// Use this for initialization
	void Start () {
        speed = 50;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, speed * Time.smoothDeltaTime, 0));
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "lazer")
            Destroy(this.gameObject);

        if (other.gameObject.tag == "enemy")
            Destroy(other.gameObject);
    }
}
