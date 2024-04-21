using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private float myScale;

    protected override void HandleMouseDown()
    {
        myScale = Random.Range(0.5f, 3f);
        transform.localScale = new Vector3(myScale, myScale, myScale);
        base.HandleMouseDown();
        Debug.Log("Cindy does it all.");
    }
}
