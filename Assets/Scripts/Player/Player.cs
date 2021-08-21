using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IPlayer
{
    void OnPunch();
    void OnKick();
}

[RequireComponent(typeof(PlayerActions))]
public class Player : MonoBehaviour, IPlayer
{
    private float _rateForIncreasedVibration = 2f;
    private Impact _impact;

    private void Awake()
    {
        _impact = GetComponent<Impact>();
    }

    public void OnPunch()
    {
        _impact.Hit("Punch_RightHand");

        Debug.Log("Punch");
    }

    public void OnKick()
    {
        _impact.Hit("Kick_LeftFoot", _rateForIncreasedVibration);

        Debug.Log("Kick");
    }
}