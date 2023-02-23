using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBullet
{
    void GoTo(Vector2 destination, float Damage);

    protected float Speed { get; set; }
}
