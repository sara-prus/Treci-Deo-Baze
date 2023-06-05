
namespace CudovistaLib.Entiteti
{
    public class Bajalice
    {
        public virtual int ID { get; set; }
        public virtual string Bajalica { get; set; }
        public virtual Cudoviste Id_cudovista { get; set; }
    }
}
