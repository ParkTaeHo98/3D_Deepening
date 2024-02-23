using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public Player Player { get;}

    public PlayerIdleStete IdleStete { get;}
    public PlayerWalkState WalkState { get; }
    public PlayerRunState RunState { get; }

    public Vector2 MovementInput { get; set; }
    public float MovementSpeed { get; private set; }
    public float RotationDamping { get; private set; }
    public float MovementSpeedModifier { get; set; } = 1f;


    public Transform MainCameraTransform = Camera.main.transform;

    public PlayerStateMachine(Player player)
    {
        this.Player = player;

        IdleStete = new PlayerIdleStete(this);
        WalkState = new PlayerWalkState(this);
        RunState = new PlayerRunState(this);

        MainCameraTransform = Camera.main.transform;

        MovementSpeed = player.PlayerData.GroundedData.BaseSpeed;
        RotationDamping = player.PlayerData.GroundedData.BaseRotationDamping;
    }
}
