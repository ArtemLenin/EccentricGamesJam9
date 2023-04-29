using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _velocity;

    public void ProcessMove(Vector2 input)
    {
        Vector2 moveDirection = input;
        transform.Translate(input * _speed * Time.deltaTime);
    }

}