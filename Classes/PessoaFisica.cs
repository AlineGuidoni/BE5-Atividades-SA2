using BE5.Interfaces;

namespace BE5.Classes
{
  public class PessoaFisica : Pessoa, IPessoaFisica
  {

    public string? cpf { get; set; }
    public string? dataNascimento { get; set; }

    public bool ValidarDataNascimento(DateTime dataNasc)
    {
      DateTime dataAtual = DateTime.Today;
      double anos = (dataAtual - dataNasc).TotalDays / 365;

      if (anos >= 18)
      {
        return true;
      }
      return false;
    }

    public bool ValidarDataNascimento(string dataNasc)
    {
      DateTime dataConvertida;
      // verificar se a string está em formato valido
      if (DateTime.TryParse(dataNasc, out dataConvertida))
      { //tryParse tenta converter e coloca na saida a data convertida
        //Console.WriteLine($"{dataConvertida}");
        DateTime dataAtual = DateTime.Today;
        double anos = (dataAtual - dataConvertida).TotalDays / 365;
        if (anos >= 18)
        {
          return true;
        }
        return false;
      }
      return false;

    }
    /*
    Rendimento menor ou igual a 1500 - imposto 0
    Rendimento maior que 1500 e menor igual a 3500 - imposto 2%
    Rendimento maior que 3500 e menor ou igual a 6000 - imposto é 7%
    Rendimento acima de 6000 - imposto 5%
    */
    public override float PagarImposto(float rendimento)
    {
      if (rendimento <= 1500)
      {
        return 0;
      }
      else if (rendimento > 1500 && rendimento <= 3500)
      {
        return (rendimento / 100) * 2;
      }
      else if (rendimento > 3500 && rendimento <= 6000)
      {
        return (rendimento / 100) * 3.5f;
      }
      else
      {
        return (rendimento / 100) * 5;
      }
    }

  }
}