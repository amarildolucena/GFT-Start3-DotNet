namespace DesafioRPG.src.Entities
{
    public class Ninja : Hero
    {
        
        public Ninja(string Name, int Level, int Hearts) : base(Name, Level, Hearts)
        {
            this.Type = "Ninja";
        }

        public override string Attack(){
            return $"O {Name} atacou com sua espada!";
        }

    }

}