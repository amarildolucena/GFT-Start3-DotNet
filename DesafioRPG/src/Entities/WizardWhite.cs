namespace DesafioRPG.src.Entities
{
    public class WizardWhite : Wizard
    {

        public WizardWhite(string Name, int Level, int Hearts) : base(Name, Level, Hearts)
        {
            this.Type = "White Wizard";
        }
        
        public override string Attack(){
            return $"O {Name} atacou com sua magia de defesa!";
        }

    }
}