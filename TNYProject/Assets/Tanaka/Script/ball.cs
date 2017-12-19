using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    public int destroyCount = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(destroyCount > (60 * 10))
        {
            Destroy(gameObject);
        }
        destroyCount++;
	}
}
