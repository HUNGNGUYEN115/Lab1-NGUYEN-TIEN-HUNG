using GameMath.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CraneRotation : MonoBehaviour
{
    public float rotationSpeed = 10f;

    // Reference to your HoldableButton components
    public HoldableButton clockwiseButton;
    public HoldableButton counterClockwiseButton;

    void Update()
    {
        // Rotate clockwise 
        if (counterClockwiseButton.IsHeldDown)
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }

        // Rotate counterclockwise
        if (clockwiseButton.IsHeldDown)
        {
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }
    }
}

