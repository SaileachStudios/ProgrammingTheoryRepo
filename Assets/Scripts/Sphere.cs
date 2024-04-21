using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private float normalSpeed;
    private bool shouldSlowDown = false;

    private void Start()
    {
        normalSpeed = TurnSpeed;
    }

    protected override void Update()
    {
        if (shouldSlowDown)
        {
            TurnSpeed -= 0.1f;
        }
        if (TurnSpeed < normalSpeed)
        {
            TurnSpeed = normalSpeed;
            shouldSlowDown = false;
        }
        base.Update();
    }

    protected override void HandleMouseDown()
    {
        TurnSpeed *= 2f;
        shouldSlowDown = true;
        base.HandleMouseDown();
        Debug.Log("Spheres gor faster.");
    }
}
