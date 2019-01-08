using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawCannon : MonoBehaviour {
    public GameObject saw;
    public Transform sawSpawn;
    public float sawSpeed = 0.5f;
    private bool check = false;



	// Use this for initialization
	void Start () {
        InvokeRepeating("shootSaw", 1, 1);

	}
	

    void shootSaw()
    {
        GameObject temp = Instantiate(saw, this.transform.position, this.transform.rotation);
        temp.GetComponent<Rigidbody>().AddForce(Vector3.left * 9700);

        //Time.deltaTime = 300;
    }
    // OnCollisionEnter instead. Make saw spawn right outside of cannon so that they don't collide.
    private void OnCollisionExit(Collision saws)
    {
        // When colliding with blocks, destroy saws

        if (saws.gameObject.tag == "saw")
        {

            Destroy(saws.gameObject);
        }
    }

    void Update()
    {
        //Debug.Log(check);
    }

}  
