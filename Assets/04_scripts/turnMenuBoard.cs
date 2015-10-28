using UnityEngine;
using System.Collections;

public class turnMenuBoard : MonoBehaviour {
    
    public Transform startHere;     //Put the local spin axis here
    public Transform endHere;       //Put the spin target here
    public float turnSpeed = 0.5f;      //Speed of spin

	void Update () {
        transform.rotation = Quaternion.Slerp(startHere.rotation, endHere.rotation, turnSpeed);     //Smoothly follow the spin of the target object
    }
}