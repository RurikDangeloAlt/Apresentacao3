using System;

namespace Apresentacao {
  public class ClasseGenerica < T > {

    private T valor;
    public ClasseGenerica(T valor) {
      this.valor = valor;
    }
    public void ExibirValor() {
      Console.WriteLine($"Valor armazenado: {valor}");
    }
    public T ObterValor() {
      return valor;
    }
  }
}

public void Alteracao01()
{
Console.WriteLine("Esta é a primeira feature.");
}