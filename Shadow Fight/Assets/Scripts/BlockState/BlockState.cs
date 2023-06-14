using UnityEngine;

public class BlockState : MeleeBaseState
{
     // Counter for consecutive blocks

    public override void OnEnter(StateMachine _stateMachine)
    {
        base.OnEnter(_stateMachine);
        blockIndex = 1;
        duration = 0.5f;
        animator.SetTrigger("Block" + blockIndex);
        //blockCount++;
        count++;
        Debug.Log("Block count: " + count);
    }

public override void OnUpdate()
    {
        base.OnUpdate();

        if (fixedtime >= duration)
        {
            if (shouldCombo)
            {
                stateMachine.SetNextState(new GroundComboState());
            }
            else if (count >= 2) // Allow only two consecutive blocks
            {
                count = 0;
                stateMachine.SetNextStateToMain();
            }
            else
            {
                stateMachine.SetNextStateToMain();
            }
        }
    }
}
