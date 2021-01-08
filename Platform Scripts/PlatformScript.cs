﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{

    public float move_Speed = 2f;
    public float bound_Y = 6f;
    public bool moving_Platform_Left, moving_Platform_Right, is_Breakable, is_Spike, is_Platform;

    private Animator anim; 

    private void Awake() {
        if(is_Breakable)
            anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move () {
        Vector2 temp = transform.position;
        temp.y += move_Speed * Time.deltaTime;
        transform.position = temp;

        if (temp.y >= bound_Y) {
            gameObject.SetActive(false);
        }
    } //move

    void BreakableDeactivate() {
        Invoke("DeactivateGameObject", 0.3f);
    }

    void DeactivateGameObject() {
        //SoundManager.instance.IceBreakSound();
        gameObject.SetActive(false); 
    }




} //class
