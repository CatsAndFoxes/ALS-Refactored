using UnrealBuildTool;

public class ALSEditor : ModuleRules
{
	public ALSEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;

		bEnableNonInlinedGenCppWarnings = true;
		// UnsafeTypeCastWarningLevel = WarningLevel.Warning;

		PrivateDependencyModuleNames.AddRange(new[]
        {
            "AnimGraphRuntime"
        });
        
        PublicDependencyModuleNames.AddRange(new[]
		{
			"Core", "CoreUObject", "Engine", "AnimGraphRuntime", "AnimationModifiers", "AnimationBlueprintLibrary", "ALS"
		});

		if (Target.bBuildEditor)
		{
			PublicDependencyModuleNames.AddRange(new[]
			{
				"AnimGraph",
				"AnimGraphRuntime",
			});

			PrivateDependencyModuleNames.AddRange(new[]
			{
				"BlueprintGraph"
			});
		}
	}
}