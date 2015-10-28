using UnityEngine;
using System.Collections;

public class leadSpinner : MonoBehaviour {

    public Quaternion turnBoard;        //Rotation variable
    public float turnAmount = 0.0f;     //Turn radius variable
	

	void Update () {
        turnBoard = Quaternion.Euler(0, turnAmount, 0);     //Set up the rotation
        transform.rotation = turnBoard;     //Rotate the object
        if (Input.GetKeyUp("z")) {
            turnAmount -= 60.0f;        //Turn to the left
        }
        if (Input.GetKeyUp("x")) {
            turnAmount += 60.0f;        //Turn to the right
        }
    }
}
