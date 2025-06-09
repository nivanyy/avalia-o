using System.Collections;
using UnityEditor;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    [ SerializeField ]
    private string nome;
    [ SerializeField ]
    private int forca_ataque;
    [ SerializeField ]
    private float forca_do_pulo;
    [ SerializeField ]
    private float velocidade;
    [ SerializeField ]
   

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
        return this.nome;
    }
    
    public void AtribuirForca_Ataque(int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }

    public int Forca_Ataque()
    {
        return this.forca_ataque;
    }

    public void AtribuirForca_do_pulo(float forca_do_pulo)
    {
        this.forca_do_pulo = forca_do_pulo;
    }

    public float Forca_do_pulo()
    {
        return this.forca_do_pulo;
    }


    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }

   
    }





    void Start()
    {
        
    }
    void Update()
    {
        
    }
