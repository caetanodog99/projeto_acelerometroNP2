using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class colision : MonoBehaviour
{
    private int pontos;
    [SerializeField] private TextMeshProUGUI textoPontos;
    [SerializeField] private GameObject painelVitoria;
    [SerializeField] private GameObject painelRestantes;
    [SerializeField] private string fase1;
    [SerializeField] private string fase2;
    [SerializeField] private string menu;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Vitoria"))
        {
            if (pontos>=8)
            {
                painelVitoria.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                painelRestantes.SetActive(true);
                StartCoroutine(DesativarRestantes(2f));
            }
        }

        IEnumerator DesativarRestantes(float time)
        {
            yield return new WaitForSeconds(time);
            painelRestantes.SetActive(false);
        }


        if (collision.gameObject.CompareTag("Coletavel"))
        {

            pontos++;
            textoPontos.text = ("Pontuação: "+ pontos);
            Destroy(collision.gameObject);
        }
    }

    public void ProximaFase()
    {
        SceneManager.UnloadScene(fase1);
        SceneManager.LoadScene(fase2);
        Time.timeScale = 1f;
    }

    public void Rejogar()
    {
        SceneManager.UnloadScene(fase2);
        SceneManager.LoadScene(menu);
        Time.timeScale = 1f;
    }
}