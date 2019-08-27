using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Базовый класс для оружия
/// </summary>
public abstract class BaseWeapon : BaseObject
{
    // точка, из которой производится выстрел
    protected Transform _SpawnBullet;
    // сила выстрела
    protected float _force;
    // прицел
    protected GameObject _crossHair;
    // кол-во патронов
    protected int _magazine;
    // Время задержки между выстрелами           
    [SerializeField] protected float _rechargeTime = 0.2f;

    protected ParticleSystem _muzzleFlash;
    protected Light _mazzleLight;
    protected GameObject _hitParticle;

    public abstract void Fire();

    protected override void Awake()
    {
        base.Awake();
    }

    void Update()
    {
        
    }
}
