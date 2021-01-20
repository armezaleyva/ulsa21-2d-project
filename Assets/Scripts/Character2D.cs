using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2D : MonoBehaviour
{
    Animator anim;

    SpriteRenderer spr;
    
    [SerializeField, Range(0.1f, 20f)]
    float moveSpeed = 2f;

    void Awake() 
    {
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        transform.Translate(Vector2.right * Axis.x * moveSpeed * Time.deltaTime);
        spr.flipX = Flip;
    }

    void LateUpdate()
    {
        anim.SetFloat("moveX", Mathf.Abs(Axis.x));
    }

    Vector2 Axis
    {
        get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    bool Flip
    {
        get => Axis.x > 0 ? false : Axis.x < 0f ? true : spr.flipX;
    }

}
