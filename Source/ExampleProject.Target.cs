using UnrealBuildTool;
using System.Collections.Generic;

public class ExampleProjectTarget : TargetRules
{
	public ExampleProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

		ExtraModuleNames.Add("ExampleProject");

		// Test for Build Errors
		// bUseUnityBuild = bUsePCHFiles = false;
	}
}
