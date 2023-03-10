using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* (Turkish)
 * Yapılması gerekenler:
 * enemy'ler sadece player'a saldırabilsin
 */

public class EnemyAttackController : MonoBehaviour
{
    [SerializeField] GameObject Bullet;

    [SerializeField] float AttackDelay = 2;

    [SerializeField] float Damage = 5;

    float lastAttackTime;

    void AttackPlayer()
    {
        GameObject CreatedBullet = Instantiate(Bullet, transform.position, Quaternion.identity);
        CreatedBullet.GetComponent<IBullet>().GoTo(GameManager.Instance.Player.position, Damage);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
    }


}
