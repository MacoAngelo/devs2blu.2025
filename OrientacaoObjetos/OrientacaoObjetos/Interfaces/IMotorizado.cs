namespace OrientacaoObjetos.Interfaces
{
    public interface IMotorizado
    {
        double Temperatura { get; set; }

        bool Ligar();
        bool Desligar();
    }
}