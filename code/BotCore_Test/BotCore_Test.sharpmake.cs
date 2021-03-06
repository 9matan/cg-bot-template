using Sharpmake;

[Generate]
public class BotCoreTestProject : CommonProject
{
    public BotCoreTestProject()
    {
        Name = "BotCore_Test";
        SourceRootPath = @"[project.SharpmakeCsPath]";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.IncludePrivatePaths.Add(@"[project.SourceRootPath]");

        conf.AddPrivateDependency<BotCoreProject>(target);
    }
}