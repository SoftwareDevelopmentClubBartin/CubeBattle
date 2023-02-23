using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackController
{
    protected GameObject Bullet { get; set; }
    protected float AttackDelay { get; set; }
    protected float Damage { get; set; }

    protected void AttackTo(Transform Target);
}
