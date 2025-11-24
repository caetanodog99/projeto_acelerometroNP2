using UnityEngine;

public class colision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Vitoria"))
        {
            Debug.Log("Colisão detectada com o objeto específico!");
        }
    }
}