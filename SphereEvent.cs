using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereEvent : MonoBehaviour {

  public float force = 50f;

  void OnEnable() {
    CollisionDetector2.OnCollision1 += CollisionAction;
    CollisionDetector2.OnAproaching += AproachingAction;
  }

  void OnDisable() {
    CollisionDetector2.OnCollision1 -= CollisionAction;
  }

  void CollisionAction() {
    MoveSphere();
  }

  void MoveSphere() {
    GameObject Cylinder = GameObject.FindGameObjectsWithTag("Cylinder")[0];
    Vector3 direction = Cylinder.transform.position - transform.position;
    direction.Normalize();
    Rigidbody rb = GetComponent<Rigidbody>();
    rb.AddForce(direction * force);
  }

  void AproachingAction() {
    // Debug.Log("Its aproaching");
    SphereJump();
  }

  void SphereJump() {
    Rigidbody rb = GetComponent<Rigidbody>();
    rb.AddForce(Vector3.up * force);
  }
}
