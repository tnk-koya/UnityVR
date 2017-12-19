using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitcher : MonoBehaviour {

    public Rigidbody ball;

    public Vector3 power;

    public int throwCount = 180;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject obj = Instantiate(ball.gameObject, transform.position, transform.rotation);
            obj.GetComponent<Rigidbody>().AddForce(power, ForceMode.Impulse);
        }

        throwCount--;
        if(throwCount <= 0)
        {
            GameObject obj = Instantiate(ball.gameObject, transform.position, transform.rotation);
            obj.GetComponent<Rigidbody>().AddForce(power, ForceMode.Impulse);
            throwCount = 180;
        }
    }
}
