using Cadastro_Pessoa_SA2___ER2.Interfaces;

namespace Cadastro_Pessoa_SA2___ER2.Classes
{
    //erdar primeiro super classe (Pessoas) depois Interface 
    public class PessoaFisica : Pessoas, IPessoaFisica
    {

        public string ?cpf { get; set; }

        public DateTime ?dataNascimento { get; set; }
        
        
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}