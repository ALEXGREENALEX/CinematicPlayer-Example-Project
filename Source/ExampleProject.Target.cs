// Copyright 2023 - 2026 Alex Zelenskyi. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ExampleProjectTarget : TargetRules
{
	public ExampleProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

		ExtraModuleNames.Add("ExampleProject");

		// Test for Build Errors
		// bUseUnityBuild = bUsePCHFiles = false;
	}
}
