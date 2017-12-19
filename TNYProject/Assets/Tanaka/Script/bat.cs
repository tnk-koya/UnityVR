using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour {
    
    public Rigidbody ball;
    
    public Vector3 power;

    
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        


    }

    // ボールが当たったら飛ばす
    void OnTriggerEnter(Collider other)
    {
        
        other.GetComponent<Rigidbody>().AddForce(0, 0, 20, ForceMode.Impulse);
        
        other.GetComponent<Rigidbody>().AddForce(Random.Range(-5,5), 15, 20, ForceMode.Impulse);
      

    }
}
