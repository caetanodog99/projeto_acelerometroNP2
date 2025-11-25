using UnityEngine;
using TMPro;

public class collectManager : MonoBehaviour
{
    public int pontos = 0;
    [SerializeField] public TextMeshProUGUI textoPontos;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
            Debug.Log("Coletou a bola!");
            pontos++;
            Debug.Log("total coletados: " +pontos);
            Destruir(true);
        }
    }

    private void Destruir(bool coletado)
    {
        this.gameObject.SetActive(false);
    }

    
}
