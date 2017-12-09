using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuButtons : MonoBehaviour {

    // Use this for initialization
    public void StartApplication()
    {
        //SceneManager.LoadScene("Scenes/ManipulateByGestureMain", LoadSceneMode.Single);
        Destroy(GameObject.Find("Canvas"));
    }
}
