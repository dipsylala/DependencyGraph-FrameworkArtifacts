namespace FrameworkMain
{
    public class Main
    {
        public string DoIt()
        {
            var dependency = new FrameworkDependency.Dependency();

            return dependency.DoIt();
        }
    }
}
