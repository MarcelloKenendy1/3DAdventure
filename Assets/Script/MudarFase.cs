using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarFase : MonoBehaviour
{
    [SerializeField] private string nomeDaProximaFase;
    [SerializeField]private float tempoDeTransiscao = 1.0f;
    [SerializeField] private GameObject efeitoFade;
    private Animator animator;
    void Start()
    {
        animator = efeitoFade.GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!string.IsNullOrEmpty(nomeDaProximaFase)) 
            {
                StartCoroutine(TransicaoParaProximaFase());
            }
        }


    }
    IEnumerator TransicaoParaProximaFase()
    {
        animator.SetTrigger("MudarFase");
        yield return new WaitForSeconds(tempoDeTransiscao);
        SceneManager.LoadScene(nomeDaProximaFase);
    }
}
    