using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement; //////<----


public class CambiarEscena : MonoBehaviour
{
  
  public void change(int indexScene){
    SceneManager.LoadScene(indexScene);
  }




}
