using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatingSystem : MonoBehaviour
{
    public int correctpins;
    private void OnTriggerEnter2D(Collider2D other)
    {
        correctpins = correctpins + 1;
        Debug.Log(correctpins);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        correctpins = correctpins - 1;
    }
}
