using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOffset : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    public float maxOffset = 10;
    public string stateName = "Idle"; // Name of animation
    private const int ALL_LAYERS = 0;


    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play(stateName, ALL_LAYERS, Random.Range(0, maxOffset));
    }

}