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

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }


    }
}