using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeBaseState : State
{
    public float duration;

    protected Animator animator;
    protected bool shouldCombo;
    protected int attackIndex;
    protected int blockIndex;
    protected bool shouldBlock;
    protected static int count = 0;
    public override void OnEnter(StateMachine _stateMachine)
    {
        base.OnEnter(_stateMachine);
        animator = GetComponent<Animator>();
    }
    public override void OnUpdate()
    {
        base.OnUpdate();
        if (Input.GetMouseButtonDown(0) == true)
        {
            shouldCombo = true;
            //Debug.Log("Attack Done");
        }
        else if (Input.GetMouseButtonDown(1) ==  true)
        {
            shouldBlock = true;
            //count++;
        }
    }
    public override void OnExit()
    {
        base.OnExit();
    }
}