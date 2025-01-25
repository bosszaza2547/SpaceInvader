using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 10f;
    public int health = 5;
    public int maxhealth = 5;
    public GameManagerScript manager;
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManagerScript>();
        health = maxhealth;
        manager.UpdateMaxHealth(maxhealth);
        manager.SetHealth(health);
    }

    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 tmpDir = mousePosition - transform.position;
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed * 1f / tmpDir.magnitude * Time.deltaTime);
        var ValidX = Mathf.Clamp(transform.position.x, -8.48f, 1.83f);
        var ValidY = Mathf.Clamp(transform.position.y, -4.75f, 4.15f);
        transform.position = new Vector3(ValidX, ValidY, 0f);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if(health > maxhealth)
        {
            health = maxhealth;
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        manager.SetHealth(health);
    }
}
