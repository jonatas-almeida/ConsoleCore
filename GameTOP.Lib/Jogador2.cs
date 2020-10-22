using GameTOP.Interface;

namespace GameTOP.Lib
{
  public class Jogador2 : iJogador
  {
    public string Chutar()
    {
      return "Maradona estás pateando";
    }

    public string Correr()
    {
      return "Maradona estás corriendo";
    }

    public string Passe()
    {
      return "Maradona estás pasando";
    }
  }
}