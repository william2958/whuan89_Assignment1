using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeRotation : MonoBehaviour
{
  Vector3 ogPosition;
  public Quaternion ogRotation;
  Vector3 newPosition;
  public Quaternion newRotation;
  // Start is called before the first frame update
  void Start()
  {
    ogPosition = new Vector3(2.97f, -5.52f, -14.1f);
    ogRotation = Quaternion.Euler(25.256f, -17.191f, -11.371f);
    newPosition = new Vector3(-0.15f, 4.35f, -1.37f);
    newRotation = Quaternion.Euler(88.55801f, 57.372f, 57.38f);

  }

  // Update is called once per frame
  void Update()
  {
    // If the user hits the C key
    if (Input.GetKeyDown(KeyCode.C))
    {
      // If the position is the original, set it to the new one
      if (Camera.main.transform.position == ogPosition)
      {
        Camera.main.transform.position = newPosition;
        Camera.main.transform.rotation = newRotation;
      }
      // If the position is the new one, set it to the original
      else
      {
        Camera.main.transform.position = ogPosition;
        Camera.main.transform.rotation = ogRotation;
      }

    }

  }
}