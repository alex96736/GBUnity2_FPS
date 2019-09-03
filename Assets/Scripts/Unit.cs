using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : BaseObject, ISetDamage
{
    [SerializeField] private int _health;

    public int Health { get => _health; set => _health = value; }

    public void SetDamage(int damage)
    {
        if (_health > 0)
        {
            _health -= damage;
            Debug.Log($"SetDamage: {damage}");
        }
        else
        {
            _health = 0;
            Destroy(_GameObject);
        }
        Debug.Log($"Health: {_health}");
    }
}
