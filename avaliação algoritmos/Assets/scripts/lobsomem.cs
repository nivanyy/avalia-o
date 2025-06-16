using UnityEngine;

public class lobsomem : Personagem
{
    public enum ArmaDoLobsomem
    {
        GARRAS, FURIADALUA
    }

    private ArmaDoLobsomem armaDoLobsomem;

    public void AtribuirArma(ArmaDoLobsomem arma)
    {
        this.armaDoLobsomem = arma;
    }

    public ArmaDoLobsomem Arma()
    {
        return this.armaDoLobsomem;
    }


    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (armaDoLobsomem)
        {
            case ArmaDoLobsomem.GARRAS:
                dano = Forca_Ataque() + 10;
                break;
            case ArmaDoLobsomem.FURIADALUA:
                dano = Forca_Ataque() + 18;
                break;
          
        }
        
        // dano do ataque com a arma
        
        return dano;
    }
    

    void Start()
    {
        
    }
    void Update()
    {
        
    }
}