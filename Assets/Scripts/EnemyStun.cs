using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

public class EnemyStun : MonoBehaviour {

	public bool boss = false;
	public int bossLives = 3;
	public int lives = 0;

	// if Player hits the stun point of the enemy, then call Stunned on the enemy
	void OnCollisionEnter2D(Collision2D other)
	{
	
		if (other.gameObject.tag == "Player")
		{
			// tell the enemy to be stunned
			this.GetComponentInParent<Enemy>().Stunned();
			other.gameObject.GetComponent<CharacterController2D>().EnemyBounce();
			if (boss)
			{
				if (bossLives > 0)
				{
					bossLives -= 1;
				}
				else
				{
					other.gameObject.GetComponent<CharacterController2D>().Victory();
					Destroy(this.GetComponentInParent<Enemy>());
				}
			}
            else
            {
                if (lives > 0)
                {
					lives--;
                }
                else
                {
					Destroy(transform.parent.gameObject);
                }

            }
		}
	}
}
