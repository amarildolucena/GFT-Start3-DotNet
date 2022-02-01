namespace DesafioRPG.src.Entities
{
    public class Knight : Hero
    {

        public Knight(string Name, int Level, int Hearts) : base(Name, Level, Hearts)
        {
            this.Type = "Knight";
        }

        public override string Attack(){
            return $"O {Name} atacou com seu golpe!";
        }

        public string Attack(int force){
            return $"O {Name} atacou com seu golpe força {force}!";
        }
        
    }
}