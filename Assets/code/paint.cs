using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class paint : MonoBehaviour {

    public GameObject wall_front;
    public GameObject wall_back;
    public GameObject wall_right;
    public GameObject wall_left;

    public GameObject paintRed;
    public GameObject paintBlue;
   
    // Use this for initialization
    void Start () {

     
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Jump"))
        {
            var Colour = paintRed.transform.GetComponent<Renderer>().material.color;
            Debug.Log(Colour);
          // paintRed.transform.GetComponent<Renderer>().material.color = Color.green;
          

        }
    }

        public void paintGreen() {
        paintRed.transform.GetComponent<Renderer>().material.color = Color.green;
        Debug.Log("WORKSSSSSSSSSSSSS");
    }





    //choosing buckets
    void onTriggerEnter() {

        if (Input.GetKeyDown(KeyCode.F))
        {

         


        } else if (Input.GetKeyDown(KeyCode.G))
        
        {





        }



    }


}
