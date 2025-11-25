using UnityEngine;
using TMPro;

public class colision : MonoBehaviour
{
    private int pontos;
    [SerializeField] private TextMeshProUGUI textoPontos;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Vitoria"))
        {
            if (pontos>=8)
            {
                Debug.Log("Parabéns, você venceu!!s");
                Time.timeScale = 0f;
            }
            else
            {
                Debug.Log("Colete as bolas restantes!");
            }
        }

        if (collision.gameObject.CompareTag("Coletavel"))
        {

            pontos++;
            textoPontos.text = ("Pontuação: "+ pontos);
            Debug.Log(collision.gameObject);
            Destroy(collision.gameObject);
        }
    }
}