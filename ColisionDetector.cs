using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetector : MonoBehaviour {

  public delegate void CollisionAction();
  public static event CollisionAction OnCollision;

  void OnCollisionEnter(Collision collision) {
    if(collision.gameObject.tag == "Cube" && gameObject.tag == "Cylinder" ||
      collision.gameObject.tag == "Cylinder" && gameObject.tag == "Cube") {
      
      if(OnCollision != null) {
        OnCollision();
      }
    }
  }
}
