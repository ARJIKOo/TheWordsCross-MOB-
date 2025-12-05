using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRotation : MonoBehaviour
{
    [SerializeField] private float speed = 20f;

    
    void Update()
    {
        transform.Rotate(Vector3.forward * (speed * Time.deltaTime));
    }
}
