using GameTOP.Interface;

namespace GameTOP
{
  public class JogoNice
  {
    private readonly iJogador _jogadorA;
    private readonly iJogador _jogadorB;

    public JogoNice(iJogador jogadorA, iJogador jogadorB)
    {
      _jogadorA = jogadorA;
      _jogadorB = jogadorB;
    }
    public void IniciarJogo()
    {
      System.Console.Write(_jogadorA.Correr());
      System.Console.Write(_jogadorA.Chutar());
      System.Console.Write(_jogadorA.Passe());

      System.Console.Write("\n PRÓXIMO JOGADOR \n");

      System.Console.Write(_jogadorB.Correr());
      System.Console.Write(_jogadorB.Chutar());
      System.Console.Write(_jogadorB.Passe());
    }
  }
}