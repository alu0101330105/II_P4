using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetector2 : MonoBehaviour {

  public delegate void CollisionAction();
  public delegate void AproachingAction();
  public static event CollisionAction OnCollision1;
  public static event CollisionAction OnCollision2;
  public static event AproachingAction OnAproaching;

  private bool isNear = false;

  // void OnCollisionEnter(Collision collision) {
  //   if(collision.gameObject.tag != "Sphere") {
      
  //     if(OnCollision1 != null) {
  //       OnCollision1();
  //     }
  //   } 
  //   if(collision.gameObject.tag == "Sphere") {
        
  //     if(OnCollision2 != null) {
  //       OnCollision2();
  //     } 
  //   }
  // }

  void Update() {
    // if object is near of cylinder, trigger event
    if(Vector3.Distance(transform.position, GameObject.FindGameObjectsWithTag("Cylinder")[0].transform.position) < 2f && !isNear) {
      // Debug.Log("Oh? You're approaching me? Instead of running away, you come right to me?");
      if(OnAproaching != null) {
        OnAproaching();
      }
      isNear = true;
    }

    if(Vector3.Distance(transform.position, GameObject.FindGameObjectsWithTag("Cylinder")[0].transform.position) > 2f) {
      isNear = false;
    }

    Debug.Log(isNear);
  }
}
