using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] private string shapeName = "name";
    public string ShapeName
    {
        get { return shapeName; }
        protected set
        {
            if(value != null)
            {
                shapeName = value;
            }
        }
    }

    [SerializeField] private string message = "message";
    public string Message
    {
        get { return message; }
        protected set
        {
            if(value != null)
            {
                message = value;
            }
        }
    }

    [SerializeField]private Vector3 rotation = Vector3.one;
    public Vector3 Rotation
    {
        get { return rotation; }
        protected set
        {
            rotation = value;
        }
    }

    [SerializeField] private float turnSpeed = 1f;
    public float TurnSpeed
    {
        get { return turnSpeed; }
        protected set
        {
            turnSpeed = value;
        }
    }

    protected virtual void Update()
    {
        transform.Rotate(rotation * turnSpeed * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        HandleMouseDown();
    }

    protected virtual void HandleMouseDown()
    {
        Debug.Log(message);
    }

}
