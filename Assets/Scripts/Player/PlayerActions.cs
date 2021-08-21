using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private PlayerInput _playerInput;
    private Player _player;

    private void Awake()
    {
        _player = GetComponent<Player>();
        _playerInput = new PlayerInput();
        
        _playerInput.Player.Punch.performed += ctx => _player.OnPunch();
        _playerInput.Player.Kick.performed += ctx => _player.OnKick();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }
}