using UnityEngine;

public class Drag : MonoBehaviour {
  private bool dragging = false;
  private Vector3 offset;
    public AudioClip clip;
  

  // Update is called once per frame
  void Update() {
    if (dragging) {
      // Move object, taking into account original offset.
      transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
    }
  }

  private void OnMouseDown() {
    // Record the difference between the objects centre, and the clicked point on the camera plane.
    offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    dragging = true;
  }

  private void OnMouseUp() {
 
    dragging = false;
    GetComponent<AudioSource>().Play();

    }
}

