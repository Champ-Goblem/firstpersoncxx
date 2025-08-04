using UnrealBuildTool;
using System.Collections.Generic;

public class FirstPersonCxxEditorTarget : TargetRules
{
	public FirstPersonCxxEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		bOverrideBuildEnvironment = true;
		ExtraModuleNames.Add("FirstPersonCxx");
	}
}
