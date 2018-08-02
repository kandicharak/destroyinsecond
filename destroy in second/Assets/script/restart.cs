using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
 

public class restart : MonoBehaviour {


 
 public void OnMouseUp()
{
    SceneManager.LoadScene("scene1", LoadSceneMode.Single);
}
}
