using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
  public float speed = 1f;
  public float distance = 10f;
  private Vector3 initialPosition;
  private Vector3 finalPosition;
  public bool xMovement = false;
  void Start() {
    initialPosition = transform.position;
    
    if(xMovement) {
      finalPosition = new Vector3(initialPosition.x + distance, initialPosition.y, initialPosition.z);
    } else {
      finalPosition = new Vector3(initialPosition.x, initialPosition.y, initialPosition.z + distance);
    }
  }

  // Update is called once per frame
  void Update() {
    transform.position = Vector3.Lerp(initialPosition, finalPosition, Mathf.PingPong(Time.time * speed, 1.0f));
  }
}
