using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.AI;

// проверка необходимых компонентов
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(ThirdPersonCharacter))]


public class Bot : Unit
{
    private NavMeshAgent _agent;
    private ThirdPersonCharacter _controller;
    private Transform _playerPos;
    private Vector3 _StartPos;
    private Transform _traget;

    protected override void Awake()
    {
        base.Awake();
        Health = 100;
        _agent = GetComponent<NavMeshAgent>();
        _controller = GetComponent<ThirdPersonCharacter>();
        _agent.updatePosition = true;
        _agent.updateRotation = true;
        _playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        _StartPos = Position;
    }

    void Update()
    {
        _agent.SetDestination(_playerPos.position);

        if (_agent.remainingDistance > _agent.stoppingDistance)
        {
            _controller.Move(_agent.desiredVelocity, false, false);
            _animator.SetBool("Move", true);
        }
        else
        {
            _controller.Move(Vector3.zero, false, false);
            _animator.SetBool("Move", false);
        }
    }
}
