using UnrealBuildTool;

public class TowerClimberServerTarget : TargetRules
{
	public TowerClimberServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("TowerClimber");
	}
}
