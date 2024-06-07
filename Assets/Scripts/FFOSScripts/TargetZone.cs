using UnityEngine;

public class TargetZone : MonoBehaviour
{
    public int points;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile") )
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddScore(points);
                Debug.Log("Collision detected with projectile. Points added: " + points);
            }
            else
            {
                Debug.LogError("GameManager.Instance is null");
            }
        }
    }
}
