using UnityEngine;
using UnityEngine.SceneManagement; 

public class touchMenu : MonoBehaviour
{

    [SerializeField] public string menu;
    [SerializeField] public string fase1;

    void Update()
    {
  
        if (Input.touchCount > 0)
        {
            Touch toque = Input.GetTouch(0);

            if (toque.phase == TouchPhase.Began)
            {
                SceneManager.UnloadScene(menu);
                SceneManager.LoadScene(fase1);
            }
        }

     
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.UnloadScene(menu);
            SceneManager.LoadScene(fase1);
        }
    }
}
