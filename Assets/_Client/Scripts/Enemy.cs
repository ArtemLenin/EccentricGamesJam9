using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Windows.Speech;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _level;
    [SerializeField] private List<Spell> _weakness;

    private Transform _player;
    private Vector2 _movementDirection;
    private NavMeshAgent agent;

    private void Start()
    {
        _player = FindObjectOfType<PlayerMotor>().transform;

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        _weakness = new List<Spell>();
        Spell[] spells = GameManager.Instance.GetSpells();
        for (int i = 0; i < _level; i++)
        {
            int index = Random.Range(0, spells.Length);
            Spell spell = spells[index];
            _weakness.Add(spell);
        }
    }

    private void Update()
    {
        _movementDirection = (_player.position - transform.position).normalized;
        agent.SetDestination(_player.position);
    }
}