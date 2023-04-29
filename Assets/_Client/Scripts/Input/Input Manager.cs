using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput _input;
    private PlayerInput.OnFootActions _onFoot;
    private PlayerMotor _motor;

    private void Awake()
    {
        _input = new PlayerInput();
        _onFoot = _input.OnFoot;
        _motor = GetComponent<PlayerMotor>();
    }

    private void OnEnable()
    {
        _onFoot.Enable();
    }

    private void OnDisable()
    {
        _onFoot.Disable();
    }

    private void FixedUpdate()
    {
        _motor.ProcessMove(_onFoot.Movement.ReadValue<Vector2>());
    }
}