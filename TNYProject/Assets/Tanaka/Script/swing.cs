using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing : MonoBehaviour {

    public bool inSwingFlag = false;
    public int swingcount = 0;
    public float s = 0.0f;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            // Space キーを押したらバットを振る
            inSwingFlag = true;
        }
        transform.eulerAngles = Vector3.Slerp(new Vector3(0, 450, 0), new Vector3(0, 270, 0), s);

        if (inSwingFlag == true)

        {
            s += Time.deltaTime * 5;
        }

        

        if(s >= 1)
        {
            s = 0;
            inSwingFlag = false;
        }
    }
}
