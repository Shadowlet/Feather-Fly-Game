using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//-------NOTE TO SELF!!!!---------//

public class Player : MonoBehaviour {
    //public GameManager gameManager;
    public Camera featherCamera;
    public Rigidbody feather;
    
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

        feather.AddForce(Vector3.right * 600);

        // Fan shit
        if(inFan == true)
        {
            feather.AddForce(Vector3.left * 1600);
        }
        else
        {
            inFan = false;
        }

        // Vacuum shit
        if(inVacuum == true)
        {
            feather.AddForce(Vector3.right * 1300);
        }
        else
        {
            inVacuum = false;
        }



        // Blows feather 
        if (Input.GetKey(KeyCode.S))
        {
            feather.AddForce(Vector3.up * 1000); // <----
        }


    }

    // Wind related blocks
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "vacuumArea")
        {
            inVacuum = true;
            Debug.Log("Vacuum True");
        }
        if (other.gameObject.tag == "fanArea")
        {
            inFan = true;
            Debug.Log("Fan True");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "vacuumArea")
        {
            inVacuum = false;
            Debug.Log("Vacuum False");
        }
        if (other.gameObject.tag == "fanArea")
        {
            inFan = false;
            Debug.Log("Fan False");
        }
    }
    private void OnCollisionEnter(Collision windBox)
    {
        
        

    }

    private void OnCollisionExit(Collision windBox)
    {
        
    }

    public void gameOver(int status)
    {
        // collision stuff
    }


}
