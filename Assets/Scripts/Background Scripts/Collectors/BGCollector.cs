using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGCollector : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D target)
    {
       
        if (target.tag == "Background")
        {
            /*
                I removed the background spawner script entirely and replaced
                the collector logic here with a "move" collected 
                bg down by 3x the height of one bg.
                this simplified the code, removed a couple unneccessary bg's
                and removed bug where BG's would spawn for a while, then 
                after a few cycles start not spawning until all 5 stayed inactive
                now its smooth constantly with less code, objects and files
                - Jeremy
            */

            float height = ((BoxCollider2D)target).size.y;
            float move = -height * 3f;

            Vector3 temp = target.transform.position;
            temp.y += move;
            target.transform.position = temp;
        }
    }
}
