using System.Text.RegularExpressions;
using Cadastro_Pessoa_SA2___ER2.Interfaces;

namespace Cadastro_Pessoa_SA2___ER2.Classes
{
    public class PessoaJuridica : Pessoas, IPessoaJuridica
    {
        //atributos
        public string ?cnpj { get; set; }

        public string ?razaoSocial { get; set; }
        
        

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        //XX.XXX.XXX/0001-XX - XXXXXXXX0001XX
        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                return true;
            }

            return false;
        }


    }
}