using UnrealBuildTool;

public class ConferenceRoomTarget : TargetRules
{
	public ConferenceRoomTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ConferenceRoom");
	}
}
