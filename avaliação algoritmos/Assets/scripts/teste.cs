using UnityEngine;

public class Teste : MonoBehaviour
{
    Personagem Jota = new Personagem();
    lobsomem sopro = new lobsomem();

    void Start()
    {
        Jota.AtribuirNome("Jota");
        Jota.AtribuirEnergia(10);
        Jota.AtribuirForca_Ataque(12);
        
        Jota.AtribuirVelocidade(8);

        sopro.AtribuirNome("sopro");
        sopro.AtribuirEnergia(12);
        sopro.AtribuirForca_Ataque(15);
        sopro.AtribuirVelocidade(10);
        sopro.AtribuirArma(lobsomem.ArmaDoLobsomem.GARRAS);
       sopro.AtribuirArma(lobsomem.ArmaDoLobsomem.FURIADALUA);

        if (Jota.Energia() <= 0)
        {
            Debug.Log("O " + Jota.Nome() + " ficou sem energia");

        }
        else
        {
            Debug.Log("O " + Jota.Nome() + " aonde tem "+ Jota.Energia() + "energia");
        }
        

    }

    void Update()
    {
        
    }
}