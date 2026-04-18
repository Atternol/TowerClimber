using UnrealBuildTool;

public class TowerClimberClientTarget : TargetRules
{
	public TowerClimberClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("TowerClimber");
	}
}
