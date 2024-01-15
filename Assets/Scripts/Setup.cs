using System.Collections;
using System.Collections.Generic;
using UnityEngine;


  
public class Setup : MonoBehaviour
{
   public Movement movement;
   public GameObject camera;

  public void islocalplayer ()
  {
    movement.enabled = true;
    camera.SetActive(true);
  }
}
