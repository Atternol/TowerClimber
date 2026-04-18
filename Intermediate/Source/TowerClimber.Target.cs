using UnrealBuildTool;

public class TowerClimberTarget : TargetRules
{
	public TowerClimberTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TowerClimber");
	}
}
