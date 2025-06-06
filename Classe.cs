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

public void Alteracao003()
{
Console.WriteLine("Resolvendo o conflito das duas features.");
}