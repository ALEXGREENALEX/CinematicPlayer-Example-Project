using UnrealBuildTool;
using System.Collections.Generic;

public class ExampleProjectEditorTarget : TargetRules
{
	public ExampleProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

		ExtraModuleNames.Add("ExampleProject");

		// Test for Build Errors
		// bUseUnityBuild = bUsePCHFiles = false;
	}
}
