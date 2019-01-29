using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  private void OnMouseOver()
  {
    // If the left button is clicked
    if (Input.GetMouseButtonDown(0))
    {
      // Then rotate the entire box
      transform.Rotate(new Vector3(-2.3f, 4, 3));
    }

  }
}
