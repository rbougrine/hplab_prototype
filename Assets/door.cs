using UnityEngine;
using System.Collections;

public class door : MonoBehaviour
{
    public bool doorisClosed;
    public Animator anim;
     
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "First Person Controller")
        {

             if (doorisClosed == true)
              {
                anim.Play("openDoor");
                doorisClosed = false;
                yield return new WaitForSeconds(10);
                anim.Play("closeDoor");
                doorisClosed = true;
              }
            
            }
        }
    }
 