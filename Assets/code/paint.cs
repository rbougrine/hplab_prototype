using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class paint : MonoBehaviour
{

    Color paintColor = Color.white;
    GameObject toBePaintedObject;
    public GameObject Camera;



    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {



    }

    /*
     If its a object that can be painted on
     then saves clicked object in variable toBePainted.
     */
    public void chosenObject()
    {
        RaycastHit hit;


        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, Mathf.Infinity))
        {
            var ObjectParent = hit.collider.gameObject.transform.parent.parent.name;

            switch (ObjectParent)
            {
                case "Painting":
                    toBePaintedObject = hit.collider.gameObject;
                 //   Debug.Log(toBePaintedObject + "to be painted");
                    break;
                case "paintBucket":
                    paintColor = Color.blue;
                //    Debug.Log(paintColor + "Paint color");
                    break;
            }

            if (toBePaintedObject != null && paintColor != Color.white)
            {
                paintBlue(toBePaintedObject, paintColor);
            }
            else {
              //  Debug.Log("not done yet");
            }
        }
   }
   
    /*
      Gets variable paintColor and toBePainted and paints the chosen object 
      the given color.
    */
    void paintBlue(GameObject toBePaintedObject, Color paintColor)
    {

        RaycastHit hit;
        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.transform.parent.parent.name == "Painting")
            {
                toBePaintedObject.transform.Find("Left").GetComponent<Renderer>().material.color = Color.blue;

            }
        }


    }
}

