using UnrealBuildTool;

public class TreasureHunt : ModuleRules
{
	public TreasureHunt(TargetInfo Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore"/*, "RHI", "Render Core"*/ });

		PrivateDependencyModuleNames.AddRange(new string[] { "UnrealEnginePython" });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
