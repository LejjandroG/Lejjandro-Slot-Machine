using UnityEngine;

public class ReelManager : MonoBehaviour
{
    public int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = Random.Range(5, 10);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
