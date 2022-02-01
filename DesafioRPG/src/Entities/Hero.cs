namespace DesafioRPG.src.Entities
{
    public abstract class Hero
    {

        public Hero() {}

        public Hero(string Name, int Level, int Hearts)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = "";
            this.Hearts = Hearts;            
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }
        public int Hearts { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public virtual string Attack(){
            return $"O {Name} atacou!";
        }

        public override string ToString(){
            return $"Name: {Name} - Level: {Level} - Type: {Type}";
        }
        
    }
}