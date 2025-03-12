namespace DepartTP2
{
    public class Program
    {
        // PROF : petite réflexion supplémentaire : après avoir lu l'énoncé (sinon commencez par ça), avez-vous remarqué qu'il y a beaucoup d'utilisations de nombre aléatoires?
        // C'est une suggestion à prendre ou à laisser, mais il pourrait être une bonne idée de se faire une classe utilitaire permettant d'obtenir les nombres qu'on veut sans
        // toujours recréer un objet Random. Vous venez d'ailleurs de voir un mot-clé qui pourrait vous aider dans cette tâche !
        public static void Main(string[] args)
        {
          Personnage personnage=new Personnage("blz",ClassePersonnage.Archer,Arme.EpeeBouclier,null);
          Console.WriteLine(personnage.StatisticPersonnage.PtsVieMax);
          Console.WriteLine(personnage.StatisticPersonnage.PtsVie);
          Console.WriteLine(personnage.StatisticPersonnage.PtsAttaque);
          personnage.StatisticPersonnage.PtsExperience = 10;
          personnage.StatisticPersonnage.PtsArmureSupplementaires = 5;
          Console.WriteLine(personnage.StatisticPersonnage.PtsExperience);
          Console.WriteLine(personnage.StatisticPersonnage.PtsArmureSupplementaires);

        }
    }
}
