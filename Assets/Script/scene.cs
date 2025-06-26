using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("Cena1");
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
   public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
