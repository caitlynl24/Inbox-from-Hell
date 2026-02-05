// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Inbox_from_Hell : ModuleRules
{
	public Inbox_from_Hell(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Inbox_from_Hell",
			"Inbox_from_Hell/Variant_Horror",
			"Inbox_from_Hell/Variant_Horror/UI",
			"Inbox_from_Hell/Variant_Shooter",
			"Inbox_from_Hell/Variant_Shooter/AI",
			"Inbox_from_Hell/Variant_Shooter/UI",
			"Inbox_from_Hell/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
