using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainPlayer : MonoBehaviour {

    
void Start () {
    if(InputGetKey(KeyCode.Escape)){
      SceneManager.LoadScene(scenename);  
    }
    
  void Update () {
    
}
    }
}