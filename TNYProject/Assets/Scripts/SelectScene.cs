using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScene : MonoBehaviour {

    public string SceneName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SelectSceneLoad()
    {
        SceneManager.LoadScene(SceneName);

        //Application.LoadLevel("Title");
    }
}
