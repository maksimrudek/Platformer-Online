using UnityEngine;
using TMPro;
public class CoinCollector : MonoBehaviour
{
    public TMP_Text coinsText;
    public float coinsCount = 0;
    public GameObject teleporter;
    public int coinsToTeleporter;

    void Update()
    {
        coinsText.text = coinsCount.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coinsCount++;
            if(coinsCount >= 3)
            {
                teleporter.SetActive(true);
            }
            Destroy(collision.gameObject);

        }
    }
}