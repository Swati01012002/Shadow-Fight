using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboCharacter : MonoBehaviour
{
    private StateMachine meleeStateMachine;
    [SerializeField] public Collider2D hitbox;

    private void Start()
    {
        meleeStateMachine = GetComponent<StateMachine>();
    }

    private void Update()
    {
        if(Input.GetMouseButton(0) && meleeStateMachine.CurrentState.GetType() == typeof(IdleCombatState)) 
        {
            meleeStateMachine.SetNextState(new GroundEntryState());
        }
    }
}

