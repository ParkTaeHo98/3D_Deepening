using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine
{
    protected InterState interState;
    public void ChangeState(InterState newState)
    {
        interState?.Exit();

        interState = newState;

        interState?.Enter();
    }
    public void HandleInput()
    {
        interState?.HandleInput();
    }
    public void Update()
    {
        interState?.Update();
    }
    public void PhysicsUpdate()
    {
        interState?.PhysicsUpdate();
    }
}
