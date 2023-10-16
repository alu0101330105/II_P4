using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAltEvent : MonoBehaviour {

  void OnEnable() {
    CollisionDetector2.OnCollision2 += CollisionAction;
    CollisionDetector2.OnAproaching += AproachingAction;
  }

  void OnDisable() {
    CollisionDetector2.OnCollision2 -= CollisionAction;
  }

  void Start() {
    Rigidbody rb = GetComponent<Rigidbody>();
    rb.AddForce(Vector3.forward * 100f);
  }

  void CollisionAction() {
    EnlargeSphere();
  }

  void EnlargeSphere() {
    Vector3 scale = transform.localScale;
    scale *= 1.1f;
    transform.localScale = scale;
  }

  void AproachingAction() {
    OrientateSphere();
  }

  void OrientateSphere() {
    // draw a 2 unit line in the forward direction of the sphere after rotarion
    Debug.DrawLine(transform.position, transform.position + transform.forward * 2, Color.red, 1f);
    GameObject Cylinder = GameObject.FindGameObjectsWithTag("LookAtMe")[0];
    Vector3 direction = Cylinder.transform.position - transform.position;
    direction.Normalize();
    transform.rotation = Quaternion.LookRotation(direction);
  }
}
