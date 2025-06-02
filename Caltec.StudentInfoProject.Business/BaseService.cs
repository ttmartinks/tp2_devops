using Caltec.StudentInfoProject.Persistence;

// Commentaire içi !!! ///
// Pour tester runner //

namespace Caltec.StudentInfoProject.Business
{
    public abstract class BaseService
    {
        public readonly StudentInfoDbContext StudentInfoDbContext;

        public BaseService(StudentInfoDbContext studentInfoDbContext)
        {
            StudentInfoDbContext = studentInfoDbContext;
        }
        
    }
}
