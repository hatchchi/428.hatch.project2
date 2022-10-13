using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform targetBoard;
    public Vector3 offset;
    public bool airTravel;

   

       


    // Update is called once per frame
    void Update()
    {

        //Vector3 boardPos = transform.position;

        //tilePos.y = 15;
        


        if (airTravel == true)
        {
            //Debug.Log("transform position.y = _____" + transform.position.y);
            
            if (targetBoard.position.y <= 3.61)
            {
                transform.position = targetBoard.position + offset;
            }
                

            else
            {
               airTravel = false;
            }

        }
    }
}
