using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float speed;

   [SerializeField] PlayerManager playerManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        speed = playerManager.moveSpeed;
    }
}
