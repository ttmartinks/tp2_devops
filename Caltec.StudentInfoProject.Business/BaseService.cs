using Caltec.StudentInfoProject.Persistence;

namespace Caltec.StudentInfoProject.Business
{
    public abstract class BaseService
    {
        public readonly StudentInfoDbContext StudentInfoDbContext;

        public BaseService(StudentInfoDbContext studentInfoDbContext)
        {
            StudentInfoDbContext = studentInfoDbContext;
        }
        
        // Méthode de test pour SonarQube : boucle infinie
        public void InfiniteLoopTest()
        {
            while (true)
            {
                // boucle infinie pour test SonarQube
            }
        }
        
    }
}
