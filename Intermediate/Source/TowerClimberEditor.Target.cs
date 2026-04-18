using UnrealBuildTool;

public class TowerClimberEditorTarget : TargetRules
{
	public TowerClimberEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("TowerClimber");
	}
}
