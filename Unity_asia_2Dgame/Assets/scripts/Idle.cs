
using UnityEngine;

public class Idle : MonoBehaviour
{
    public GameObject final;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送門囉");
        final.SetActive(true);
    }


}
