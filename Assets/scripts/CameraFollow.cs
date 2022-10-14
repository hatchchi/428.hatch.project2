using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform targetBoard;
    //public Vector3 offset;
    public bool airTravel;

   

       


    // Update is called once per frame
    void Update()
    {

        //Vector3 boardPos = transform.position;

        //tilePos.y = 15;
        


        if (airTravel == true)
        {
            //Debug.Log("transform position.y = _____" + transform.position.y);

            //if (targetBoard.position.y <= 3.61)
            //{
            // transform.position.y = targetBoard.position.y + offset;
            //Debug.Log("targetBoard.transform.position.y is ___" + targetBoard.transform.position.y);
            //Debug.Log("transform.position.y is ___" + transform.position.y);
            transform.position = new Vector3(transform.position.x, targetBoard.transform.position.y, transform.position.z);
            //}

            
            //else
            //{
             //  airTravel = false;
            //}

        }
    }
}
