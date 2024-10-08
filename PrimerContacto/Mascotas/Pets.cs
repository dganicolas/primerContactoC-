namespace PrimerContacto.Mascotas;

public abstract class Pets
{
    public String Nombre { get; set; }
    public int Ataque { get; set; }
    public int vida { get; set; }

    public int ataque()
    {
        return Ataque;
    }

    public int recibirAtaque(int dano)
    {
        vida -= dano;
        return vida;
    }
}