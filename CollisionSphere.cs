using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSphere : MonoBehaviour {

  Material thisMaterial;
  public float force = 1f;

  void OnEnable() {
    Debug.Log("CollisionSphere enabled");
    CollisionDetector.OnCollision += CollisionAction;
  }

  void OnDisable() {
    Debug.Log("CollisionSphere disabled");
    CollisionDetector.OnCollision -= CollisionAction;
  }

  void Start() {
    thisMaterial = GetComponent<Renderer>().material;
  }


  void CollisionAction() {
    if(tag == "Sphere") {
      ColorChange();
    } else if (tag == "Sphere Alt") {
      MoveSphere();
    }
  }

  void ColorChange() {
    float HueShift = Random.Range(0.05f, 0.95f);
    Color currentColor = thisMaterial.color;
    float H, S, V; H = S = V = 0;
    Color.RGBToHSV(currentColor, out H, out S, out V);
    H += HueShift;
    if(H > 1f) H -= 1f;
    Color newColor = Color.HSVToRGB(H, S, V);
    thisMaterial.color = newColor;
  }

  void MoveSphere() {
    GameObject Cylinder = GameObject.FindGameObjectsWithTag("Cylinder")[0];
    Vector3 direction = Cylinder.transform.position - transform.position;
    direction.Normalize();
    Rigidbody rb = GetComponent<Rigidbody>();
    rb.AddForce(direction * force);
  }
}
