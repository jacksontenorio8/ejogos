using Models;
using System.Collections.Generic;

namespace EJOGOS.Interface
{
    public interface IEQUIPE
    {
         //CONTRATO.
        //Representa os métodos que são obrigatorios em uma classe.

        void Criar(Equipe novaequipe);
        List<Equipe> LerEquipes();   
    }
}