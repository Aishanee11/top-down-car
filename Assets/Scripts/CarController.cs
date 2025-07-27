using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // w/s and up/down keys move the car
    public float rotationSpeed, moveSpeed;

    public Transform cartransform;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");

        float verticalMovement = Input.GetAxis("Vertical");

        Debug.Log("horizontal:" + horizontalMovement + "vertical:" + verticalMovement);

        if(System.Math.Abs(horizontalMovement) > 0.01f)
        {
            cartransform.Rotate(0f,0f, -1 * rotationSpeed * horizontalMovement);
        }
        if(System.Math.Abs(verticalMovement)> 0.01f)
        {
            cartransform.Translate(0f, moveSpeed * verticalMovement, 0f);
        }
    }
}
 