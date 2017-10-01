// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class BuildingEscapeUE4EditorTarget : TargetRules
{
	public BuildingEscapeUE4EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

        bUseUnityBuild = false;
        bUsePCHFiles = false;

		ExtraModuleNames.AddRange( new string[] { "BuildingEscapeUE4" } );
	}
}
