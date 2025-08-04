using UnrealBuildTool;
using System.Collections.Generic;

public class FirstPersonCxxTarget : TargetRules
{
	public FirstPersonCxxTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		BuildEnvironment = TargetBuildEnvironment.Unique;
		ExtraModuleNames.Add("FirstPersonCxx");
	}
}
