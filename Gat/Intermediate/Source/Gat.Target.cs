using UnrealBuildTool;

public class GatTarget : TargetRules
{
	public GatTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Gat");
	}
}
