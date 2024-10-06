using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//-------------------------------------------------------------------------------
public class GameController : MonoBehaviour
{
    public GameObject[] Quests, camera, extra, Aviso, portas;
    public GameObject Player, dica;
    public int hits, hitsExtra, missesExtra, click, used1, used2, used3, used4, used5, used6, used7, used8, used9, used10;
    public int misses1, misses2, misses3, misses4, misses5, misses6, misses7, misses8, misses9, misses10;
    public int hitsE1, hitsE2, hitsE3, hitsE4, hitsE5, hitsE6, hitsE7, hitsE8, hitsE9, hitsE10;
    public Text pontos, Text_dica;
    public Animator DoorC, DoorB;
    //-------------------------------------------------------------------------------
    void Start()
    {
        StartCoroutine(Door_1());
    }
    //-------------------------------------------------------------------------------
    void Update()
    {
        if(hits == 10)
        {
            StartCoroutine(Vitória());
        }
        //-------------------------------------------------------------------------------
        #region Saída das 10 Perguntas base
        switch (hits)
        {
            case 1:
                Quests[0].SetActive(false);
                camera[0].SetActive(false);
                camera[1].SetActive(true);
                Player.SetActive(true);
                misses1 = 0;
                break;
            case 2:
                misses2 = 0;
                Quests[1].SetActive(false);
                camera[0].SetActive(false);
                camera[1].SetActive(true);
                Player.SetActive(true);
                break;
            case 3:
                misses3 = 0;
                Quests[2].SetActive(false);
                camera[0].SetActive(false);
                camera[1].SetActive(true);
                Player.SetActive(true);
                break;
            case 4:
                misses4 = 0;
                Quests[3].SetActive(false);
                camera[0].SetActive(false);
                camera[1].SetActive(true);
                Player.SetActive(true);
                break;
            case 5:
                misses5 = 0;
                Quests[4].SetActive(false);
                camera[0].SetActive(false);
                camera[1].SetActive(true);
                Player.SetActive(true);
                break;
            case 6:
                misses6 = 0;
                Quests[5].SetActive(false);
                camera[0].SetActive(false);
                camera[1].SetActive(true);
                Player.SetActive(true);
                break;
            case 7:
                misses7 = 0;
                Quests[6].SetActive(false);
                camera[0].SetActive(false);
                camera[1].SetActive(true);
                Player.SetActive(true);
                break;
            case 8:
                misses8 = 0;
                Quests[7].SetActive(false);
                camera[0].SetActive(false);
                camera[1].SetActive(true);
                Player.SetActive(true);
                break;
            case 9:
                misses9 = 0;
                Quests[8].SetActive(false);
                camera[0].SetActive(false);
                camera[1].SetActive(true);
                Player.SetActive(true);
                break;
            case 10:
                misses10 = 0;
                Quests[9].SetActive(false);
                camera[0].SetActive(false);
                camera[1].SetActive(true);
                Player.SetActive(true);
                break;
        }
        #endregion
        //-------------------------------------------------------------------------------
        #region Entrada dos 20 extras
        if (misses1 == 1)
        {
            used1 = 1;
            extra[0].SetActive(true);
            Text_dica.text = "Considere como a unificação pode centralizar recursos e esforços para aumentar a eficiência.";
        }
        if(misses1 == 2)
        {
            used1 = 2;
            extra[0].SetActive(false);
            extra[1].SetActive(true);
            Text_dica.text = "Reflita sobre como a replicação pode ser mais simples e econômica para unidades menores.";
        }
        if(misses1 == 3)
        {
            extra[1].SetActive(false);
            StartCoroutine(Derrota());
        }
        //-------------------------------------------------------------------------------
        if (misses2 == 1)
        {
            extra[2].SetActive(true);
            used2 = 1;
            Text_dica.text = "Pense nos obstáculos que podem surgir ao tentar integrar diferentes unidades sob um único modelo operacional.";
        }
        if (misses2 == 2)
        {
            used2 = 2;
            extra[2].SetActive(false);
            extra[3].SetActive(true);
            Text_dica.text = "Reflita sobre como a padronização pode simplificar a gestão e garantir a consistência nas operações.";
        }
        if (misses2 == 3)
        {
            extra[3].SetActive(false);
            StartCoroutine(Derrota());
        }
        //-------------------------------------------------------------------------------
        if (misses3 == 1)
        {
            extra[4].SetActive(true);
            used3 = 1;
            Text_dica.text = "Considere como a diversificação pode permitir que uma empresa atenda a uma variedade de necessidades do mercado.";
        }
        if (misses3 == 2)
        {
            used3 = 2;
            extra[4].SetActive(false);
            extra[5].SetActive(true);
            Text_dica.text = "Lembre-se de que estamos buscando o tipo de modelo operacional que enfatiza a harmonização de processos e a criação de padrões eficientes.";
        }
        if (misses3 == 3)
        {
            extra[5].SetActive(false);
            StartCoroutine(Derrota());
        }
        //-------------------------------------------------------------------------------
        if (misses4 == 1)
        {
            extra[6].SetActive(true);
            used4 = 1;
            Text_dica.text = "Pense em como a inovação pode impulsionar a diferenciação, melhorar a experiência do cliente e manter a relevância no mercado.";
        }
        if (misses4 == 2)
        {
            used4 = 2;
            extra[6].SetActive(false);
            extra[7].SetActive(true);
            Text_dica.text = "Esse modelo tem uma padronização alta.";
        }
        if (misses4 == 3)
        {
            extra[7].SetActive(false);
            StartCoroutine(Derrota());
        }
        //-------------------------------------------------------------------------------
        if (misses5 == 1)
        {
            extra[8].SetActive(true);
            used5 = 1;
            Text_dica.text = "Pense em como a diversificação envolve expandir as áreas de atuação da organização, abrangendo diferentes produtos, serviços ou mercados.";
        }
        if (misses5 == 2)
        {
            extra[8].SetActive(false);
            extra[9].SetActive(true);
            used5 = 2;
            Text_dica.text = "Pense em como a diversificação pode expandir as oportunidades de mercado e reduzir riscos.";
        }
        if (misses5 == 3)
        {
            extra[9].SetActive(false);
            StartCoroutine(Derrota());
        }
        //-------------------------------------------------------------------------------
        if (misses6 == 1)
        {
            used6 = 1;
            extra[10].SetActive(true);
            Text_dica.text = "Considere como a unificação pode melhorar a experiência do cliente e otimizar os processos de estoque.";
        }
        if (misses6 == 2)
        {
            used6 = 2;
            extra[10].SetActive(false);
            extra[11].SetActive(true);
            Text_dica.text = "Considere como a coordenação pode melhorar a eficiência e a capacidade de resposta às demandas do mercado.";
        }
        if (misses6 == 3)
        {
            extra[11].SetActive(false);
            StartCoroutine(Derrota());
        }
        //-------------------------------------------------------------------------------
        if (misses7 == 1)
        {
            used7 = 1;
            extra[12].SetActive(true);
            Text_dica.text = "Considere como uma autonomia bem definida pode promover a responsabilidade e a eficiência em cada unidade operacional.";
        }
        if (misses7 == 2)
        {
            used7 = 2;
            extra[12].SetActive(false);
            extra[13].SetActive(true);
            Text_dica.text = "Reflita sobre como uma maior eficiência operacional pode conferir vantagens competitivas em termos de custo, qualidade e tempo de resposta.";
        }
        if (misses7 == 3)
        {
            extra[13].SetActive(false);
            StartCoroutine(Derrota());
        }
        //-------------------------------------------------------------------------------
        if (misses8 == 1)
        {
            used8 = 1;
            extra[14].SetActive(true);
            Text_dica.text = "Pense nos obstáculos que podem surgir ao tentar integrar diferentes unidades sob um único modelo operacional.";
        }
        if (misses8 == 2)
        {
            used8 = 2;
            extra[14].SetActive(false);
            extra[15].SetActive(true);
            Text_dica.text = "Reflita sobre como a padronização pode simplificar a gestão e garantir a consistência nas operações.";
        }
        if (misses8 == 3)
        {
            extra[15].SetActive(false);
            StartCoroutine(Derrota());
        }
        //-------------------------------------------------------------------------------
        if (misses9 == 1)
        {
            used9 = 1;
            extra[16].SetActive(true);
            Text_dica.text = "Considere como a diversificação pode permitir que uma empresa atenda a uma variedade de necessidades do mercado.";
        }
        if (misses9 == 2)
        {
            used9 = 2;
            extra[16].SetActive(false);
            extra[17].SetActive(true);
            Text_dica.text = "Pense em como a replicação pode facilitar a adoção de melhores práticas em várias unidades operacionais.";
        }
        if (misses9 == 3)
        {
            extra[17].SetActive(false);
            StartCoroutine(Derrota());
        }
        //-------------------------------------------------------------------------------
        if (misses10 == 1)
        {
            used10 = 1;
            extra[18].SetActive(true);
            Text_dica.text = "Executar atividades básicas para uma empresa.";
        }
        if (misses10 == 2)
        {
            used10 = 2;
            extra[18].SetActive(false);
            extra[19].SetActive(true);
            Text_dica.text = "Pense na relação entre a eficiência operacional e a capacidade de adaptação das organizações no cenário competitivo.";
        }
        if (misses10 == 3)
        {
            extra[19].SetActive(false);
            StartCoroutine(Derrota());
        }
        #endregion

        #region Saída das 20 extras
        switch (hitsE1)
        {
            case 1:
                if (used1 == 1)
                {
                    extra[0].SetActive(false);
                    used1 = 0;
                }
                if (used1 == 2)
                {
                    extra[1].SetActive(false);
                    used1 = 0;
                }
                break;
        }
        switch (hitsE2)
        {
            case 1:
                if (used2 == 1)
                {
                    extra[2].SetActive(false);
                    used2 = 0;
                }
                if (used2 == 2)
                {
                    extra[3].SetActive(false);
                    used2 = 0;
                }
                break;
        }
        switch (hitsE3)
        {
            case 1:
                if (used3 == 1)
                {
                    extra[4].SetActive(false);
                    used3 = 0;
                }
                if (used3 == 2)
                {
                    extra[5].SetActive(false);
                    used3 = 0;
                }
                break;
        }
        switch (hitsE4)
        {
            case 1:
                if (used4 == 1)
                {
                    extra[6].SetActive(false);
                    used4 = 0;
                }
                if (used4 == 2)
                {
                    extra[7].SetActive(false);
                    used4 = 0;
                }
                break;
        }
        switch (hitsE5)
        {
            case 1:
                if (used5 == 1)
                {
                    extra[8].SetActive(false);
                    used5 = 0;
                }
                if (used5 == 2)
                {
                    extra[9].SetActive(false);
                    used5 = 0;
                }
                break;
        }
        switch (hitsE6)
        {
            case 1:
                if (used6 == 1)
                {
                    extra[10].SetActive(false);
                    used6 = 0;
                }
                if (used6 == 2)
                {
                    extra[11].SetActive(false);
                    used6 = 0;
                }
                break;
        }
        switch (hitsE7)
        {
            case 1:
                if (used7 == 1)
                {
                    extra[12].SetActive(false);
                    used7 = 0;
                }
                if (used7 == 2)
                {
                    extra[13].SetActive(false);
                    used7 = 0;
                }
                break;
        }
        switch (hitsE8)
        {
            case 1:
                if (used8 == 1)
                {
                    extra[14].SetActive(false);
                    used8 = 0;
                }
                if (used8 == 2)
                {
                    extra[15].SetActive(false);
                    used8 = 0;
                }
                break;
        }
        switch (hitsE9)
        {
            case 1:
                if (used9 == 1)
                {
                    extra[16].SetActive(false);
                    used9 = 0;
                }
                if (used9 == 2)
                {
                    extra[17].SetActive(false);
                    used9 = 0;
                }
                break;
        }
        switch (hitsE10)
        {
            case 1:
                if (used10 == 1)
                {
                    extra[18].SetActive(false);
                    used10 = 0;
                }
                if (used10 == 2)
                {
                    extra[19].SetActive(false);
                    used10 = 0;
                }
                break;
        }
        #endregion
        //-------------------------------------------------------------------------------
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        //-------------------------------------------------------------------------------
    }
    //-------------------------------------------------------------------------------
    #region Buttons Answers, Errors and ExtraAnswers
    public void Answers()
    {
        hits += 1;
    }
    public void AnswersExtra(int hitsExtra)
    {
        switch (hitsExtra)
        { 
            case 1: hitsE1 += 1;break;  
            case 2: hitsE2 += 1; break;
            case 3: hitsE3 += 1; break;
            case 4: hitsE4 += 1; break;
            case 5: hitsE5 += 1; break;
            case 6: hitsE6 += 1; break;
            case 7: hitsE7 += 1; break;
            case 8: hitsE8 += 1; break;
            case 9: hitsE9 += 1; break;
            case 10: hitsE10 += 1; break;

        }
    }
    public void Errors(int errors)
    {
        switch(errors)
        {
            case 1:
                misses1 += 1;
                break;
            case 2:
                misses2 += 1;
                break;
            case 3:
                misses3 += 1;
                break;
            case 4:
                misses4 += 1;
                break;
            case 5:
                misses5 += 1;
                break;
            case 6:
                misses6 += 1;
                break;
            case 7:
                misses7 += 1;
                break;
            case 8:
                misses8 += 1;
                break;
            case 9:
                misses9 += 1;
                break;
            case 10:
                misses10 += 1;
                break;
        }
    }
    #endregion
    //-------------------------------------------------------------------------------
    public void Dica()
    {
        #region Dica
        click += 1;
        switch (click)
        {
            case 1:
                dica.SetActive(true);
                break;
            case 2:
                dica.SetActive(false);
                click = 0;
                break;
        }
        #endregion
    }
    //-------------------------------------------------------------------------------
    IEnumerator Door_1()
    {
        DoorC.SetFloat("Habilita", 1);
        DoorB.SetFloat("Habilita", 1);
        yield return new WaitForSeconds(2f);
        portas[0].SetActive(false);
        portas[1].SetActive(false);
    }
    IEnumerator Vitória()
    {
        if(hits == 10)
        {
            yield return new WaitForSeconds(5f);
            SceneManager.LoadScene("Scene_Fim");
        }
    }
    IEnumerator Derrota()
    {
        Aviso[0].SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scene_Menu");
    }
}
