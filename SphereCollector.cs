using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SphereCollector : MonoBehaviour {
  private int pointCount = 0;
  public TMP_Text pointText;
  public TMP_Text msgText;
  public int penaltyAmount = 15;
  public float penaltyDuration = 2f;
    private float penaltyTime;

  void OnEnable() {
    PenalizePlayer.OnPenalize += PenalizeAction;
  }

  void Start() {
    showPoints("Start collecting spheres");
    penaltyTime = penaltyDuration;
  }

  void Update() {
    if(penaltyTime > 0) {
      penaltyTime -= Time.deltaTime;
    }
    Debug.Log(penaltyTime);
  }

  void OnTriggerEnter(Collider other) {
    if(other.gameObject.tag == "Sphere") {
      pointCount += 5;
      showPoints("Normal Sphere collected +5 points", Color.blue);
      Destroy(other.gameObject);
    } else if(other.gameObject.tag == "Sphere Alt") {
      pointCount += 10;
      showPoints("Special Sphere collected +10 points", Color.green);
      Destroy(other.gameObject);
    }
  }

  void showPoints(string msg, Color color = default(Color)) {
    msgText.color = color;
    if(pointCount < 0) pointText.color = Color.red;
    else pointText.color = new Color(0.7760f, 0.4675152f, 0.9622642f);
    pointText.text = pointCount.ToString();
    msgText.text = msg;
  }

  void PenalizeAction() {
    if(penaltyTime <= 0) {
      pointCount -= penaltyAmount;
      showPoints("Penalty -" + penaltyAmount.ToString() + " points", Color.red);
      penaltyTime = penaltyDuration;
    }
  }
}
