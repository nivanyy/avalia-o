using UnityEngine;

public class teste : MonoBehaviour
{
    void Start()
    {
        
        lobsomem lobsomem = new GameObject("Lobsomem").AddComponent<lobsomem>();
        lobsomem.AtribuirNome("sopro");
        lobsomem.AtribuirAtaque(20);
        lobsomem.AtribuirArma(lobsomem.ArmaDoLobsomem.GARRAS);

        
        Personagem Personagem = new GameObject("personagem").AddComponent<Personagem>();
        Personagem.AtribuirNome("sol");
        Personagem.AtribuirEnergia(80);
        Personagem.AtribuirAtaque(10);
        Personagem.AtribuirVelocidade(3);

      
        Debug.Log("--- Combate Iniciado ---");
        Debug.Log( lobsomem.Nome() + " (Lobsomem) VS " + Personagem.Nome());
        Debug.Log("Lobsomem ataca com: " +  lobsomem.Arma());
        Debug.Log("Dano causado: " +  lobsomem.Arma());
        Debug.Log( lobsomem + " recebeu " + " de dano. Vida restante: " + 100);

        
        Personagem.AtribuirEnergia( lobsomem.DanoDoInimigo());
    }

    void Update()
    {
        
    }
}