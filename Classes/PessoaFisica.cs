using Cadastro_Pessoa_SA2___ER2.Interfaces;

namespace Cadastro_Pessoa_SA2___ER2.Classes
{
    //erdar primeiro super classe (Pessoas) depois Interface 
    public class PessoaFisica : Pessoas, IPessoaFisica
    {

        public string ?cpf { get; set; }

        public string ?dataNascimento { get; set; }


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
            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {

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


        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}