using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//-------NOTE TO SELF!!!!---------//

// * Remove velocity garbage
public class Player : MonoBehaviour {
    //public GameManager gameManager;
    public Camera featherCamera;
    public Rigidbody feather;
    public Transform player;

    public float featherX;
    public float featherY;
    public bool inVacuum = false;
    public bool inFan = false;

  

    


    // Use this for initialization
    void Start() {

        featherX = feather.transform.position.x;
        featherY = feather.transform.position.y;

        //player = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {

        feather.AddForce(Vector3.right * 700);

        // Vacuum shit
        if(inVacuum == true)
        {
            feather.AddForce(Vector3.left * 1200);
        }



        // Blows feather 
        if (Input.GetKey(KeyCode.S))
        {
            feather.AddForce(Vector3.up * 1000); // <----
        }


    }



    private void OnTriggerEnter(Collider windBox)
    {
        if(windBox.gameObject.tag == "vacuumArea")
        {
            inVacuum = true;
        }
        if (windBox.gameObject.tag == "fanArea")
        {
            inFan = true;
        }

    }

    private void OnTriggerExit(Collider windBox)
    {
        if(windBox.gameObject.tag == "vacuumArea")
        {
            inVacuum = false;
        }
        if (windBox.gameObject.tag == "vacuumArea")
        {
            inFan = false;
        }
    }

    public void gameOver(int status)
    {
        // collision stuff
    }


}
