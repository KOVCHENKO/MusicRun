using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject.GetComponent<CharacterControllerMovable>().GetIsAttacking())
        {
            Debug.Log("Starting colliding with enemy");
            {
                Debug.Log("Is it attacking right now?");
                // tell the enemy to be stunned
                this.GetComponentInParent<Enemy>().Stunned();
            }
        }
        else
        {
            other.gameObject.GetComponent<CharacterControllerMovable>().FallDeath();
        }
    }
}