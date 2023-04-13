#include "FirstPersonCxxGameMode.h"
#include "FirstPersonCxxCharacter.h"
#include "UObject/ConstructorHelpers.h"

AFirstPersonCxxGameMode::AFirstPersonCxxGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPerson/Blueprints/BP_FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;
}
