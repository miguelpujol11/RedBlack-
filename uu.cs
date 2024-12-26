using UnityEngine;
using System.Collections;

public class MainPlayer : MonoBehaviour {

    // Use this for initialization
    void Start () {
    if(InputGetKey(KeyCode.Escape)){
      SceneManager.LoadScene(scenename);  
    }
    }
    
    // Update is called once per frame
    void Update () {
    
    }
}