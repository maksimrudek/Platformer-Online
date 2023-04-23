using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerTeleport : MonoBehaviour
{
    private SpriteRenderer renderer;
    public float teleportTime = 1;
    public float teleportTimeLeft;
    public string nextLevel;

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();

        teleportTimeLeft = teleportTime;
    }

    private void Update()
    {
        renderer.color = new Color(1, 1, 1, teleportTimeLeft);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Teleporter")) return;

        teleportTimeLeft -= Time.deltaTime;

        if (teleportTimeLeft <= 0)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        teleportTimeLeft = teleportTime;
    }
}