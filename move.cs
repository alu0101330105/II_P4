using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
  Rigidbody rb;
  public float force = 1f;
  // Start is called before the first frame update
  void Start() {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update() {

    //make object look in the direction of the movement horizontally only
    if(rb.velocity.magnitude > 0.1f) {
      Vector3 lookDirection = rb.velocity;
      lookDirection.y = 0;
      transform.LookAt(transform.position + lookDirection);
    }
    // prevent the cilinder from aumenting the y coordinate
    if(transform.position.y > 0.5f)
    transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
    if(rb.velocity.magnitude < 5) {
      if (Input.GetKey(KeyCode.UpArrow)) {
        rb.AddForce(Vector3.forward * force);
      }
      if (Input.GetKey(KeyCode.DownArrow)) {
        rb.AddForce(Vector3.back * force);
      }
      if (Input.GetKey(KeyCode.LeftArrow)) {
        rb.AddForce(Vector3.left * force);
      }
      if (Input.GetKey(KeyCode.RightArrow)) {
        rb.AddForce(Vector3.right * force);
      }
    }
  }
}
