using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int type;
    public GameController GC;
    //-------------------------------------------------------------------------------
    void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameController>();
    }
    //-------------------------------------------------------------------------------
    void Update()
    {
        
    }
    //-------------------------------------------------------------------------------
    private void OnTriggerStay(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            switch (type)
            {
                #region Entrada das 10 perguntas base
                case 1:
                    if (GC.hits == 0 & GC.misses1 == 0)
                    {
                        GC.camera[1].SetActive(false);
                        GC.camera[0].SetActive(true);
                        StartCoroutine(Q1());
                        GC.Player.SetActive(false);
                        GC.Text_dica.text = "Padroniza��o e Integra��o s�o fatores para denominar modelos operacionais.";
                    }
                    break;
                case 2:
                    if (GC.hits == 1)
                    {
                        GC.camera[1].SetActive(false);
                        GC.camera[0].SetActive(true);
                        StartCoroutine(Q2());
                        GC.Player.SetActive(false);
                        GC.Text_dica.text = "O modelo operacional trata de como uma organiza��o determina os produtos que oferece, para quem oferece, como arrecada o valor, e de quem arrecada.";
                    }
                    break;
                case 3:
                    if (GC.hits == 2)
                    {
                        GC.camera[1].SetActive(false);
                        GC.camera[0].SetActive(true);
                        StartCoroutine(Q3());
                        GC.Player.SetActive(false);
                        GC.Text_dica.text = "A nomenclatura dos modelos faz men��o ao seu funcionamento.";
                    }
                    break;
                case 4:
                    if (GC.hits == 3)
                    {
                        GC.camera[1].SetActive(false);
                        GC.camera[0].SetActive(true);
                        StartCoroutine(Q4());
                        GC.Player.SetActive(false);
                        GC.Text_dica.text = "A diversifica��o � um modelo com baixa padroniza��o.";
                    }
                    break;
                case 5:
                    if (GC.hits == 4)
                    {
                        GC.camera[1].SetActive(false);
                        GC.camera[0].SetActive(true);
                        StartCoroutine(Q5());
                        GC.Player.SetActive(false);
                        GC.Text_dica.text = "O modelo em quest�o tem baixa integra��o e alta padroniza��o.";
                    }
                    break;
                case 6:
                    if (GC.hits == 5)
                    {
                        GC.camera[1].SetActive(false);
                        GC.camera[0].SetActive(true);
                        StartCoroutine(Q6());
                        GC.Player.SetActive(false);
                        GC.Text_dica.text = "Esse modelo tamb�m t�m suas frentes de neg�cio atuando como clientes, fornecedores e parceiros.";
                    }
                    break;
                case 7:
                    if (GC.hits == 6)
                    {
                        GC.camera[1].SetActive(false);
                        GC.camera[0].SetActive(true);
                        StartCoroutine(Q7());
                        GC.Player.SetActive(false);
                        GC.Text_dica.text = "A replica��o tem independ�ncia padronizada.";
                    }
                    break;
                case 8:
                    if (GC.hits == 7)
                    {
                        GC.camera[1].SetActive(false);
                        GC.camera[0].SetActive(true);
                        StartCoroutine(Q8());
                        GC.Player.SetActive(false);
                        GC.Text_dica.text = "A primeira empresa tem Alta integra��o, e a segunda, baixa integra��o.";
                    }
                    break;
                case 9:
                    if (GC.hits == 8)
                    {
                        GC.camera[1].SetActive(false);
                        GC.camera[0].SetActive(true);
                        StartCoroutine(Q9());
                        GC.Player.SetActive(false);
                        GC.Text_dica.text = "Esse modelo tem uma padroniza��o alta.";
                    }
                    break;
                case 10:
                    if (GC.hits == 9)
                    {
                        GC.camera[1].SetActive(false);
                        GC.camera[0].SetActive(true);
                        StartCoroutine(Q10());
                        GC.Player.SetActive(false);
                        GC.Text_dica.text = "Lideran�a de custos se trata de gastar menos para produzir do que a concorr�ncia, podendo vender mais barato e a padroniza��o � uma quest�o que ajuda a definir o modelo de cada empresa.";
                    }
                    break;
                    #endregion
            }
        }
    }
    #region Coroutines Paineis
    IEnumerator Q1()
    {
        yield return new WaitForSeconds(1f);
        GC.Quests[0].SetActive(true);
    }
    IEnumerator Q2()
    {
        yield return new WaitForSeconds(1f);
        GC.Quests[1].SetActive(true);
    }
    IEnumerator Q3()
    {
        yield return new WaitForSeconds(1f);
        GC.Quests[2].SetActive(true);
    }
    IEnumerator Q4()
    {
        yield return new WaitForSeconds(1f);
        GC.Quests[3].SetActive(true);
    }
    IEnumerator Q5()
    {
        yield return new WaitForSeconds(1f);
        GC.Quests[4].SetActive(true);
    }
    IEnumerator Q6()
    {
        yield return new WaitForSeconds(1f);
        GC.Quests[5].SetActive(true);
    }
    IEnumerator Q7()
    {
        yield return new WaitForSeconds(1f);
        GC.Quests[6].SetActive(true);
    }
    IEnumerator Q8()
    {
        yield return new WaitForSeconds(1f);
        GC.Quests[7].SetActive(true);
    }
    IEnumerator Q9()
    {
        yield return new WaitForSeconds(1f);
        GC.Quests[8].SetActive(true);
    }
    IEnumerator Q10()
    {
        yield return new WaitForSeconds(1f);
        GC.Quests[9].SetActive(true);
    }
    #endregion
}
