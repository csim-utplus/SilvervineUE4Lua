using System.IO;
using UnrealBuildTool;

namespace UnrealBuildTool.Rules
{
	public class SilvervineUE4LuaCodeGen : ModuleRules
	{
		public SilvervineUE4LuaCodeGen(ReadOnlyTargetRules Target) : base(Target)
        {
            PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

            PublicIncludePaths.AddRange(new string[]
            {
            });

            PrivateIncludePaths.AddRange(new string[]
            {
            });
            
            PublicDependencyModuleNames.AddRange(new string[]
            {
                "Core",
                "CoreUObject"
            });

            PrivateDependencyModuleNames.AddRange(new string[]
            {
				"Projects",
            });

            PublicDefinitions.Add("HACK_HEADER_GENERATOR=1");
        }
	}
}
