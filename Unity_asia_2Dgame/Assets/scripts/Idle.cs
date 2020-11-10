
using UnityEngine;
using UnityEngine.UI;

public class Idle : MonoBehaviour
{
    public GameObject final;
    public Text textcount;
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "傳送門")
        {
            final.SetActive(true);
        }
        if (collision.tag == "gem")
        {
            Destroy(collision.gameObject);
            count++;
            textcount.text = "Gem:" + count;
        }
    }


}
