using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador : IJogador
    {
        public string _Nome { get; set; }  
        public Jogador(string Nome )
        {
            _Nome = Nome;
        }
        public string Chuta()
        {
            return $"{_Nome} está Chutando Forte!";
        }
        public string Corre()
        {
            return $"{_Nome} está Correndo!";
        }
        public string Passe()
        {
            return $"{_Nome} está Passando!";
        }
    }
}