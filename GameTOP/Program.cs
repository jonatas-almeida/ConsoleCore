using GameTOP.Interface;
using GameTOP.Lib;

namespace GameTOP
{
  class Program
  {
    static void Main(string[] args)
    {

      var jogo = new JogoNice(
        new Jogador1(),
        new Jogador3()
      );
      jogo.IniciarJogo();
    }
  }

}
