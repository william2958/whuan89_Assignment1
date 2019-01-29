using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

  Vector3 ogPosition;
  public Quaternion ogRotation;

  // Called before first frame update
  void Start()
  {
    ogPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    ogRotation = transform.rotation;
  }

  // Called once per frame
  void Update()
  {

  }

  private void OnMouseOver()
  {
    // If it's the right mouse button
    if (Input.GetMouseButtonDown(1))
    {
      // Reset the positions
      gameObject.transform.position = ogPosition;
      gameObject.transform.rotation = ogRotation;
    }

  }
}