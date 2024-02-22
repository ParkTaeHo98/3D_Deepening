using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public Player Player { get;}
    public PlayerIdleStete IdleStete { get;}

    public Transform MainCameraTransform = Camera.main.transform;

    public PlayerStateMachine(Player player)
    {
        this.Player = player;

        IdleStete = new PlayerIdleStete(this);
    }
}
