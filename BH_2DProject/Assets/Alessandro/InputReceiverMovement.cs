using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReceiverMovement : MonoBehaviour, IInputProvider
{
    public float speed;

    public Vector2 Direction(Vector2 dir)
    {
        dir *= Time.deltaTime * speed;
        return dir;
    }
}
