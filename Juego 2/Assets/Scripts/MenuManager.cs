using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_Text nombreTexto;

    public void ChangeScene(int i)
    {
        SceneManager.LoadScene(i);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void RecibirNombre(string nombre)
    {
        Debug.Log("Nombre recibido desde React: " + nombre);
        nombreTexto.text = nombre; 
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            RecibirNombre("PruebaLocal");
        }
    }

}
