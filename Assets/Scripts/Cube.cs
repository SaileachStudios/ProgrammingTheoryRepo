using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    protected override void HandleMouseDown()
    {
        Debug.Log("Cubin' in 3D");
        base.HandleMouseDown();
        Debug.Log("Cubes are so Awesome.");
    }
}
