using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

  public GameObject obj;
  // Start is called before the first frame update
  void Start() {
    transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y + 5, obj.transform.position.z - 5);
    transform.LookAt(obj.transform);
  }

  // Update is called once per frame
  void Update() {
    transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y + 5, obj.transform.position.z - 5);
  }
}
