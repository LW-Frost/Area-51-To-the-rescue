﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoveToPlayer : MonoBehaviour
{
    private Animator _anim;
    private static readonly int Walk = Animator.StringToHash("Walk");

    private void Awake()
    {
        _anim = GetComponentInChildren<Animator>();
    }

    void Start()
    {
        _anim.SetBool(Walk,true);
    }

    // Update is called once per frame
    void Update() {
        MoveToPlayer();
    }

    private void MoveToPlayer() {
        GameObject findPlayer = GameObject.FindGameObjectWithTag("Player");
        var moveToPlayer = findPlayer.transform.position;
        NavMeshAgent enemyNavMoveTowardPlayer = GetComponent<NavMeshAgent>();
        enemyNavMoveTowardPlayer.destination = moveToPlayer;
        if(findPlayer = null) {
            Debug.LogError("Player not found");
        }
    }
}
