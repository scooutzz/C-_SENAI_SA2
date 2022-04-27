using Cadastro_Pessoa_SA2___ER2.Interfaces;

namespace Cadastro_Pessoa_SA2___ER2.Classes
{
    public abstract class Pessoas : IPessoa
    {
        //atributos (propriedades { prop -> snippet } ) 
        public string? nome { get; set; }

        public Endereco? endereco { get; set; }

        public float rendimento { get; set; }



        public abstract float PagarImposto(float rendimento);
    }
}