using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGActivator : MonoBehaviour
{
    public static bool startExited;
    [SerializeField] SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        spriteRenderer.enabled = startExited;
 
    }

}
