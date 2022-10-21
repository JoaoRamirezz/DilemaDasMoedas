public abstract class Player
{
    public int Moeda {get; protected set;}
    public abstract bool Decididr();
    public virtual void Recebe(int valor)
    { 
        this.Moeda += valor;
    }
}
