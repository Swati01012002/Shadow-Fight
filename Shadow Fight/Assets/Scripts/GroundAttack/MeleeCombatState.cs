using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeCombatState : State
{
    public override void OnEnter(StateMachine _stateMachine)
    {
        base.OnEnter(_stateMachine);
        State nextState = (State)new GroundEntryState();
        stateMachine.SetNextState(nextState);
    }
}