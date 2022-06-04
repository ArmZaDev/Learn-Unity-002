using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    //Getting Components
    private Rigidbody2D myBody;
    private BoxCollider2D myCollider;
    private AudioSource audioSource;
    private Animator animator;

    private Transform myTransform;
    //------------------------------
    

    Player warrior;
    Player archer;

    // awake is the first funtion that is called
    private void Awake()
    {
        
    }

    //2nd function called
    private void OnEnable()
    {
        
    }

    //3rd function called
    private void Start()
    {

        myBody = GetComponent<Rigidbody2D>();

        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

        animator = GetComponent<Animator>();

        myTransform = transform;
        myTransform.position = new Vector3(10, 20, 30);

        /*
        Warrior warrior = new Warrior(40, 30, "Warrior");
        
        warrior.Attack();

        warrior = new Player(100, 50, "Lizard");
        archer = new Player(100, 50, "archer");

        warrior.Health = 50;

        Debug.Log("The health is: " + warrior.Health);
        //warrior.Info();
        //archer.Info();

        //warrior.Attack();
        */

    }

    private void Update()
    {
        
    }





}//class
