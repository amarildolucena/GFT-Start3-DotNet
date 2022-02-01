namespace DesafioRPG.src.Entities
{
    public class WizardBlack : Wizard
    {

        public WizardBlack(string Name, int Level, int Hearts) : base(Name, Level, Hearts)
        {
            this.Type = "Black Wizard";
        }
        
        public override string Attack(){
            return $"O {Name} atacou com sua magia negra!";
        }

    }
}