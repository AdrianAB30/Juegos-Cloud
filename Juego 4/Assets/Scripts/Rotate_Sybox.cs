using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Sybox : MonoBehaviour
{
    [SerializeField] public float rotationSpeed;
    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}
