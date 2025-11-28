using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class timeManager : MonoBehaviour
{
    public float time = 45f;
    [SerializeField] private TextMeshProUGUI textoTempo;
    [SerializeField] private GameObject painelDerrota;
    private bool playerLost = false;
    [SerializeField] private string fase;

    void Update()
    {
        if (!playerLost)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
                UpdateTimerDisplay();
            }
            else
            {
                time = 0;
                PlayerLose();
            }
        }
    }

    void UpdateTimerDisplay()
    {
        if (textoTempo != null)
        {
            textoTempo.text = ("Tempo restante: " + Mathf.Ceil(time).ToString()+" segundos");
        }
    }

    void PlayerLose()
    {
        playerLost = true;
        painelDerrota.SetActive(true);
        Time.timeScale = 0f;  
    }

    public void TentarNovamente()
    {      
        SceneManager.LoadScene(fase);
        Time.timeScale = 1f;
    }
}
